using MedicalAppointmentAPI.DTOs.Auth;
using MedicalAppointmentAPI.DTOs.Patients;

namespace MedicalAppointmentAPI.Services.Interfaces;

public interface IAuthService
{
  Task<AuthResponse> Login(LoginRequest request);
  Task<AuthResponse> Register(RegisterRequest request);

  Task<AuthResponse> RegisterPatient(RegisterPatientRequest request);
  Task<AuthResponse> RefreshToken(string refreshToken);
  Task<AuthResponse> Logout(string refreshToken);
  Task<bool> RevokeTokenAsync(string userId);
  Task<bool> ValidateTokenAsync(string token);
}