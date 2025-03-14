using HospitalManagement.DTOs.Patients;
using MedicalAppointmentAPI.DTOs.Auth;
using MedicalAppointmentAPI.DTOs.Patients;
using MedicalAppointmentAPI.DTOs.Auth.Request;
namespace MedicalAppointmentAPI.Services.Interfaces;

public interface IAuthService
{
  Task<AuthResponse> LoginAsync(LoginRequest request);
  Task<AuthResponse> RegisterPatientAsync(RegisterPatientRequest request);
  Task<AuthResponse.PatientInfo> UpdatePatient(string userId, UpdatePatientRequest request);
  Task<AuthResponse> RefreshTokenAsync(string refreshToken);
  Task<LogoutResponse.LogoutData> Logout(string refreshToken);
  Task<bool> RevokeTokenAsync(string token);
  Task<bool> ValidateTokenAsync(string token);
  Task<bool> SendEmailConfirmationAsync(string email, string confirmationLink);
  Task<bool> SendPasswordResetAsync(string email, string resetLink);
}