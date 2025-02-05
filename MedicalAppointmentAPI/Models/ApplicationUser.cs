using Microsoft.AspNetCore.Identity;

namespace MedicalAppointmentAPI.Models;

public class ApplicationUser : IdentityUser
{
  //First name
  public string FirstName { get; set; } = string.Empty;
  public string LastName { get; set; } = string.Empty;
  public string? AvatarUrl { get; set; }
  public DateTime DateOfBirth { get; set; }
  public string Gender { get; set; } = string.Empty;
  public string Address { get; set; } = string.Empty;
  public bool IsActive { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime? UpdatedAt { get; set; }
  public string? RefreshToken { get; set; }
  public DateTime? RefreshTokenExpiryTime { get; set; }

  // Helper properties
  public string FullName => $"{FirstName} {LastName}";
  public int Age => DateTime.Today.Year - DateOfBirth.Year;

}