using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Common.Configurations.Interfaces;
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


  public AuthService(IAuthRepository authRepository, IConfiguration configuration, ILogger<AuthService> logger, IJwtSettings jwtSettings)
  {
    _authRepository = authRepository;
    _configuration = configuration;
    _logger = logger;
    _jwtSettings = jwtSettings;
  }

  public async Task<AuthResponse> Login(LoginRequest request)
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
    var key = Encoding.ASCII.GetBytes(_jwtSettings.SecretKey);
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

  public async Task<AuthResponse> Register(RegisterRequest request)
  {
    throw new NotImplementedException();
  }
  public async Task<AuthResponse> RegisterPatient(RegisterPatientRequest request)
  {
    var user = new ApplicationUser
    {
      UserName = request.Email,
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

    var result = await _authRepository.CreateUserAsync(user, request.Password);
    if (!result.Succeeded)
    {
      throw new Exception(result.Errors.FirstOrDefault()?.Description ?? "Failed to create user");
    }

    // Create patient profile
    var patient = new Patient
    {
      UserId = user.Id,
      BloodType = request.BloodType,
      Allergies = request.Allergies,
      ChronicDiseases = request.ChronicDiseases,
      InsuranceNumber = request.InsuranceNumber,
      InsuranceProvider = request.InsuranceProvider,
      InsuranceExpiryDate = request.InsuranceExpiryDate,
      CreatedAt = DateTime.UtcNow
    };
    await _authRepository.CreatePatientProfileAsync(patient);
    await _authRepository.AddToRoleAsync(user, "Patient");
    return new AuthResponse
    {
      User = new AuthResponse.UserInfo
      {
        Id = user.Id,
        Email = user.Email,
        FirstName = user.FirstName,
        LastName = user.LastName,
        PhoneNumber = user.PhoneNumber,

      }
    };
  }
  public Task<AuthResponse> RefreshToken(string refreshToken)
  {
    throw new NotImplementedException();
  }

  public Task<AuthResponse> Logout(string refreshToken)
  {
    throw new NotImplementedException();
  }

  public Task<bool> RevokeTokenAsync(string userId)
  {
    throw new NotImplementedException();
  }

  public Task<bool> ValidateTokenAsync(string token)
  {
    throw new NotImplementedException();
  }
  public Task<bool> SendEmailConfirmationAsync(string email, string confirmationLink)
  {
    // var confirmationLink = $"{_configuration["FrontendUrl"]}/confirm-email?token={confirmationToken}";
    return null;
  }
  public Task<bool> SendPasswordResetAsync(string email, string resetLink)
  {
    throw new NotImplementedException();
  }
}