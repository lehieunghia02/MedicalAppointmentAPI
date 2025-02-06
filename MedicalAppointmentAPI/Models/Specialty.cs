

using System.ComponentModel.DataAnnotations;
using MedicalAppointmentAPI.Models;

namespace Models;

public class Specialty : BaseEntity
{
  [Key]
  public int Id { get; set; }

  [Required]
  [StringLength(100)]
  public string Name { get; set; } = string.Empty;

  [Required]
  [StringLength(500)]
  public string Description { get; set; } = string.Empty;

  public string? ImageUrl { get; set; }

  public bool IsActive { get; set; } = true;

  //Navigation property 
  public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
  // public virtual ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();
}