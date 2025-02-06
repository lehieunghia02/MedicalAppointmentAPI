using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Models;

namespace MedicalAppointmentAPI.Models;

public class ApplicationUser : IdentityUser
{
  //First name
  [Required(ErrorMessage = "First name is required")]
  [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters")]
  [Display(Name = "First Name")]
  public string FirstName { get; set; } = string.Empty;
  [Required(ErrorMessage = "Last name is required")]
  [StringLength(100, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 100 characters")]
  [Display(Name = "Last Name")]
  public string LastName { get; set; } = string.Empty;
  [Display(Name = "Avatar")]
  [StringLength(2048, ErrorMessage = "Avatar URL must be less than 2048 characters")]
  public string? AvatarUrl { get; set; }
  [Required(ErrorMessage = "Date of birth is required")]
  [Display(Name = "Date of Birth")]
  public DateTime DateOfBirth { get; set; }
  [Required(ErrorMessage = "Gender is required")]
  [Display(Name = "Gender")]
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

  //Navigation property
  public virtual Doctor? Doctor { get; set; }
  public virtual Patient? Patient { get; set; }

}