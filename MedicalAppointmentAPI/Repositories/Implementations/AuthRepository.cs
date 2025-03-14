using MedicalAppointmentAPI.Data;
using MedicalAppointmentAPI.Models;
using MedicalAppointmentAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models;

namespace MedicalAppointmentAPI.Repositories.Implementations;

public class AuthRepository : IAuthRepository
{
  private readonly UserManager<ApplicationUser> _userManager;
  private readonly RoleManager<IdentityRole> _roleManager;
  private readonly IConfiguration _configuration;
  private readonly ILogger<AuthRepository> _logger;
  private readonly ApplicationDbContext _context;
  public AuthRepository(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, ILogger<AuthRepository> logger, ApplicationDbContext context)
  {
    _userManager = userManager;
    _roleManager = roleManager;
    _configuration = configuration;
    _logger = logger;
    _context = context;
  }
  //User management
  public async Task<ApplicationUser?> GetUserByEmailAsync(string email)
  {
    return await _userManager.FindByEmailAsync(email);
  }

  public async Task<ApplicationUser?> GetUserByIdAsync(string userId)
  {
    return await _userManager.FindByIdAsync(userId);
  }
  public async Task<ApplicationUser?> GetUserByRefreshTokenAsync(string refreshToken)
  {
    return await _userManager.Users.FirstOrDefaultAsync(u => u.RefreshToken == refreshToken);
  }
  public async Task<bool> VerifyPasswordAsync(ApplicationUser user, string password)
  {
    return await _userManager.CheckPasswordAsync(user, password);
  }

  public async Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password)
  {
    return await _userManager.CreateAsync(user, password);
  }

  public async Task<bool> UpdateUserAsync(ApplicationUser user)
  {
    var result = await _userManager.UpdateAsync(user);
    return result.Succeeded;
  }

  public async Task<bool> DeleteUserAsync(string userId)
  {
    var user = await GetUserByIdAsync(userId);
    if (user == null) return false;

    var result = await _userManager.DeleteAsync(user);
    return result.Succeeded;
  }

  // Role management
  public async Task<IdentityResult> AddToRoleAsync(ApplicationUser user, string role)
  {
    return await _userManager.AddToRoleAsync(user, role);
  }

  public async Task<IList<string>> GetUserRolesAsync(ApplicationUser user)
  {
    return await _userManager.GetRolesAsync(user);
  }

  // Authentication
  public async Task<bool> CheckPasswordAsync(ApplicationUser user, string password)
  {
    return await _userManager.CheckPasswordAsync(user, password);
  }

  public async Task<bool> IsEmailConfirmedAsync(ApplicationUser user)
  {
    return await _userManager.IsEmailConfirmedAsync(user);
  }

  // Token management
  public async Task<bool> UpdateRefreshTokenAsync(ApplicationUser user, string refreshToken, DateTime expiryTime)
  {
    user.RefreshToken = refreshToken;
    user.RefreshTokenExpiryTime = expiryTime;
    user.UpdatedAt = DateTime.UtcNow;

    var result = await _userManager.UpdateAsync(user);
    return result.Succeeded;
  }

  public async Task<bool> RevokeRefreshTokenAsync(string token)
  {
    var user = await GetUserByIdAsync(token);
    if (user == null) return false;

    user.RefreshToken = null;
    user.RefreshTokenExpiryTime = null;
    user.UpdatedAt = DateTime.UtcNow;

    var result = await _userManager.UpdateAsync(user);
    return result.Succeeded;
  }

  // Patient specific
  public async Task<Patient?> GetPatientByUserIdAsync(string userId)
  {
    return await _context.Patients
        .Include(p => p.User)
        .FirstOrDefaultAsync(p => p.UserId == userId);
  }

  public async Task<Patient> CreatePatientProfileAsync(Patient patient)
  {
    await _context.Patients.AddAsync(patient);
    await _context.SaveChangesAsync();
    return patient;
  }

  // Doctor specific
  public async Task<Doctor?> GetDoctorByUserIdAsync(string userId)
  {
    return await _context.Doctors
        .Include(d => d.User)
        .Include(d => d.Specialty)
        .Include(d => d.Clinic)
        .FirstOrDefaultAsync(d => d.UserId == userId);
  }

  public async Task<Doctor> CreateDoctorProfileAsync(Doctor doctor)
  {
    await _context.Doctors.AddAsync(doctor);
    await _context.SaveChangesAsync();
    return doctor;
  }
  public async Task<bool> UpdatePatientProfileAsync(Patient patient)
  {
    _context.Patients.Update(patient);
    await _context.SaveChangesAsync();
    return true;
  }

}