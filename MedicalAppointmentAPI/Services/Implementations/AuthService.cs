using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Common.Configurations.Interfaces;
using HospitalManagement.DTOs.Patients;
using MedicalAppointmentAPI.Common.Configurations;
using MedicalAppointmentAPI.Common.Constants;
using MedicalAppointmentAPI.DTOs.Auth;
using MedicalAppointmentAPI.DTOs.Patients;
using MedicalAppointmentAPI.Models;
using MedicalAppointmentAPI.Repositories.Interfaces;
using MedicalAppointmentAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Models;

namespace MedicalAppointmentAPI.Services.Implementations;

public class AuthService : IAuthService
{
  private readonly IAuthRepository _authRepository;
  private readonly IConfiguration _configuration;
  private readonly ILogger<AuthService> _logger;
  private readonly IJwtSettings _jwtSettings;


  public AuthService(IAuthRepository authRepository, 
    IConfiguration configuration, 
    ILogger<AuthService> logger, 
    IJwtSettings jwtSettings)
  {
    _authRepository = authRepository;
    _configuration = configuration;
    _logger = logger;
    _jwtSettings = jwtSettings;
  }

  public async Task<AuthResponse> LoginAsync(LoginRequest request)
  {
    var user = await _authRepository.GetUserByEmailAsync(request.Email);
    if (user == null)
    {
      throw new UnauthorizedAccessException("Invalid email or password");
    }

    //Verify password 
    if (!await _authRepository.VerifyPasswordAsync(user, request.Password))
    {
      throw new UnauthorizedAccessException("Invalid email or password");
    }

    //check if email is confirmed 
    if (!await _authRepository.IsEmailConfirmedAsync(user))
    {
      throw new UnauthorizedAccessException("Please confirm your email before logging in");
    }

    //Check if user is active 
    if (!user.IsActive)
    {
      throw new UnauthorizedAccessException("Your account is not active. Please contact support.");
    }
    //Get user roles 
    var roles = await _authRepository.GetUserRolesAsync(user);
    // Generate JWT token
    var tokenHandler = new JwtSecurityTokenHandler();
    var tokenDescriptor = new SecurityTokenDescriptor
    {
      Subject = new ClaimsIdentity(new[]
     {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Email, user.Email!),
            new Claim(ClaimTypes.Name, user.UserName!),
            new Claim(ClaimTypes.GivenName, user.FirstName),
            new Claim(ClaimTypes.Surname, user.LastName)
        }.Concat(roles.Select(role => new Claim(ClaimTypes.Role, role)))),

      Expires = DateTime.UtcNow.AddMinutes(_jwtSettings.AccessTokenExpirationMinutes),
      SigningCredentials = _jwtSettings.GetSigningCredentials(),
      Issuer = _jwtSettings.Issuer,
      Audience = _jwtSettings.Audience
    };
    var token = tokenHandler.CreateToken(tokenDescriptor);
    var accessToken = tokenHandler.WriteToken(token);

    //Generate refresh token 
    var refreshToken = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
    var refreshTokenExpiryTime = DateTime.UtcNow.AddDays(SystemConstants.Authentication.RefreshTokenValidityDays);

    // Save refresh token
    await _authRepository.UpdateRefreshTokenAsync(user, refreshToken, refreshTokenExpiryTime);


    // Create and return response
    return new AuthResponse
    {
      Tokens = new AuthResponse.TokenInfo
      {
        AccessToken = accessToken,
        RefreshToken = refreshToken,
        ExpiresIn = tokenDescriptor.Expires!.Value,
        TokenType = "Bearer"
      },
      User = new AuthResponse.UserInfo
      {
        Id = user.Id,
        Email = user.Email!,
        Username = user.UserName!,
        FirstName = user.FirstName,
        LastName = user.LastName,
        FullName = user.FullName,
        PhoneNumber = user.PhoneNumber ?? string.Empty,
        AvatarUrl = user.AvatarUrl ?? string.Empty,
        Roles = roles.ToList()
      }
    };
  }

  //Đăng ký tài khoản bệnh nhân
  public async Task<AuthResponse> RegisterPatientAsync(RegisterPatientRequest request)
  {
    //Check if email is already in use
    var existingUser = await _authRepository.GetUserByEmailAsync(request.Email);
    if (existingUser != null)
    {
      throw new Exception("Email already in use");
    }
    // Create new user
    var user = new ApplicationUser
    {
      UserName = request.Username,
      Email = request.Email,
      FirstName = request.FirstName,
      LastName = request.LastName,
      PhoneNumber = request.PhoneNumber,
      Gender = request.Gender,
      Address = request.Address ?? string.Empty,
      DateOfBirth = request.DateOfBirth,
      CreatedAt = DateTime.UtcNow,
      IsActive = true
    };
    _logger.LogInformation("Creating user: {User}", user);
    _logger.LogInformation("Created new user with email: {Email}", request.Email);
    _logger.LogInformation("Create user with user name: {Username}", request.Username);
    var newUserResult = await _authRepository.CreateUserAsync(user, request.Password);
    if (!newUserResult.Succeeded)
    {
      throw new Exception(newUserResult.Errors.FirstOrDefault()?.Description ?? "Failed to create user");
    }

    // Create instance of patient
    var patient = new Patient
    {
      UserId = user.Id,
      CreatedAt = DateTime.UtcNow
    };
    await _authRepository.CreatePatientProfileAsync(patient);
    await _authRepository.AddToRoleAsync(user, SystemConstants.Roles.Patient);
    return new AuthResponse
    {
      User = new AuthResponse.UserInfo
      {
        Id = user.Id,
        Email = user.Email,
        FirstName = user.FirstName,
        LastName = user.LastName,
        PhoneNumber = user.PhoneNumber ?? string.Empty,
        AvatarUrl = user.AvatarUrl ?? string.Empty,
        Roles = new List<string> { SystemConstants.Roles.Patient }
      }
    };
  }
  public Task<AuthResponse> RefreshTokenAsync(string refreshToken)
  {
    throw new NotImplementedException();
  }
  //Function logout 
  public async Task<LogoutResponse.LogoutData> Logout(string refreshToken)
  {
    try
    {
      var result = await _authRepository.RevokeRefreshTokenAsync(refreshToken);
      if (!result)
      {
        return new LogoutResponse.LogoutData
        {
          Succeeded = false,
          Message = "Token is invalid or token is expired"
        };
      }
      return new LogoutResponse.LogoutData
      {
        Succeeded = true,
        Message = "Logout successfully"
      };
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error occurred while logging out");
      throw;
    }
  }
  //Function revoke token 

  public async Task<bool> RevokeTokenAsync(string token)
  {
    try
    {
      var result = await _authRepository.RevokeRefreshTokenAsync(token);
      return true; 
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error occurred while revoking token");
      return false; 
    }
  }

  public Task<bool> ValidateTokenAsync(string token)
  {
    throw new NotImplementedException();
  }
  public Task<bool> SendEmailConfirmationAsync(string email, string confirmationLink)
  {
    throw new NotImplementedException();
  }
  public Task<bool> SendPasswordResetAsync(string email, string resetLink)
  {
    throw new NotImplementedException();
  }
  public async Task<AuthResponse.PatientInfo> UpdatePatient(string userId, UpdatePatientRequest request)
  {
    var patient = await _authRepository.GetPatientByUserIdAsync(userId);
    if (patient == null)
    {
      throw new Exception("Không tìm thấy bệnh nhân");
    }
    patient.BloodType = request.BloodType;
    patient.Allergies = request.Allergies;
    patient.ChronicDiseases = request.ChronicDiseases;
    patient.InsuranceNumber = request.InsuranceNumber;
    await _authRepository.UpdatePatientProfileAsync(patient);
    return new AuthResponse.PatientInfo
    {
      Id = patient.Id.ToString(),
      BloodType = patient.BloodType,
      Allergies = patient.Allergies,
      ChronicDiseases = patient.ChronicDiseases,
      InsuranceNumber = patient.InsuranceNumber,
      InsuranceExpiryDate = patient.InsuranceExpiryDate ?? DateTime.MinValue
    };
  }
}