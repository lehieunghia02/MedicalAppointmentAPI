using MedicalAppointmentAPI.Models;
using Microsoft.AspNetCore.Identity;
using Models;

namespace MedicalAppointmentAPI.Repositories.Interfaces;

public interface IAuthRepository
{
  // User management
  Task<ApplicationUser?> GetUserByEmailAsync(string email);
  Task<ApplicationUser?> GetUserByIdAsync(string userId);
  Task<ApplicationUser?> GetUserByRefreshTokenAsync(string refreshToken);
  Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password);
  Task<bool> UpdateUserAsync(ApplicationUser user);
  Task<bool> DeleteUserAsync(string userId);

  // Role management
  Task<IdentityResult> AddToRoleAsync(ApplicationUser user, string role);
  Task<IList<string>> GetUserRolesAsync(ApplicationUser user);

  // Authentication
  Task<bool> CheckPasswordAsync(ApplicationUser user, string password);
  Task<bool> IsEmailConfirmedAsync(ApplicationUser user);
  Task<bool> VerifyPasswordAsync(ApplicationUser user, string password);

  // Token management
  Task<bool> UpdateRefreshTokenAsync(ApplicationUser user, string refreshToken, DateTime expiryTime);
  Task<bool> RevokeRefreshTokenAsync(string userId);

  // Patient specific
  Task<Patient?> GetPatientByUserIdAsync(string userId);
  Task<Patient> CreatePatientProfileAsync(Patient patient);

  // Doctor specific
  Task<Doctor?> GetDoctorByUserIdAsync(string userId);
  Task<Doctor> CreateDoctorProfileAsync(Doctor doctor);

}
