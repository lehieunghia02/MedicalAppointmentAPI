using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MedicalAppointmentAPI.Common.Enums;
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
  [Column(TypeName = "datetime2(0)")]
  public DateTime DateOfBirth { get; set; }
  [Required(ErrorMessage = "Gender is required")]
  [Display(Name = "Gender")]
  public Gender Gender { get; set; }
  public string Address { get; set; } = string.Empty;
  public bool IsActive { get; set; }
  [Column(TypeName = "datetime2(0)")]
  public DateTime CreatedAt { get; set; }
  [Column(TypeName = "datetime2(0)")]
  public DateTime? UpdatedAt { get; set; }
  public string? RefreshToken { get; set; }
  [Column(TypeName = "datetime2(0)")]
  public DateTime? RefreshTokenExpiryTime { get; set; }


  // Helper properties
  public string FullName => $"{FirstName} {LastName}";
  public int Age => DateTime.Today.Year - DateOfBirth.Year;

  //Navigation property
  public virtual Doctor? Doctor { get; set; }
  public virtual Patient? Patient { get; set; }

}