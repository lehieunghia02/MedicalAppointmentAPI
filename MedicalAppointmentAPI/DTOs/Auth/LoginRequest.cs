using System.ComponentModel.DataAnnotations;

namespace MedicalAppointmentAPI.DTOs.Auth;

public class LoginRequest
{
  [Required(ErrorMessage = "Email is required")]
  [EmailAddress(ErrorMessage = "Invalid email address")]
  public string Email { get; set; } = string.Empty;

  [Required(ErrorMessage = "Password is required")]
  [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
  [MaxLength(20, ErrorMessage = "Password must be between 8 and 20 characters")]
  public string Password { get; set; } = string.Empty;
}