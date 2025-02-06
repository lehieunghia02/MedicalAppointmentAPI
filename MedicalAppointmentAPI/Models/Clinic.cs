using System.ComponentModel.DataAnnotations;
using MedicalAppointmentAPI.Models;

namespace Models;

public class Clinic : BaseEntity
{

  public int Id { get; set; }
  [Required]
  [StringLength(200)]
  public string Name { get; set; } = string.Empty;

  [StringLength(500)]
  public string? Description { get; set; }

  [Required]
  [StringLength(255)]
  public string Address { get; set; } = string.Empty;

  [StringLength(20)]
  public string? Phone { get; set; }

  [StringLength(100)]
  public string? Email { get; set; }

  [StringLength(2048)]
  public string? ImageUrl { get; set; }

  public string? Website { get; set; }

  [Required]
  public string OpeningHours { get; set; } = string.Empty;

  public bool IsActive { get; set; } = true;

  //Navigation property 
  public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
  public virtual ICollection<Specialty> Specialties { get; set; } = new List<Specialty>();




}