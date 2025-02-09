using System.ComponentModel.DataAnnotations;

namespace MedicalAppointmentAPI.DTOs.Auth;

public class LoginRequest
{
  [Required(ErrorMessage = "Email is required")]
  [EmailAddress(ErrorMessage = "Invalid email address")]
  public string Email { get; set; } = string.Empty;

  [Required(ErrorMessage = "Password is required")]
  [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
  public string Password { get; set; } = string.Empty;
}