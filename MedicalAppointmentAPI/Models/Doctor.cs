using System.ComponentModel.DataAnnotations;
using Models;

namespace MedicalAppointmentAPI.Models;

public class Doctor : BaseEntity
{
  // Doctor ID
  public int Id { get; set; }

  // Foreign key to ApplicationUser
  public string UserId { get; set; }

  //Navigation property 
  public ApplicationUser User { get; set; }

  // Giấy phép hành nghề
  [Required]
  public string LicenseNumber { get; set; } = string.Empty;

  //Chứng chỉ, bằng cấp
  public string? Qualifications { get; set; }
  // Tiểu sử của bác sĩ
  public string? Biography { get; set; }

  //Chuyên khoa 
  public int SpecialtyId { get; set; }
  public Specialty Specialty { get; set; }


  //Link with Clinic 
  public int ClinicId { get; set; }
  public Clinic Clinic { get; set; }

  //Số năm kinh nghiệm 
  [Range(0, 50)]
  public int YearsOfExperience { get; set; }

  //IsAvailable 
  public bool IsAvailable { get; set; } = true;

  //Navigation properties 
  public virtual ICollection<DoctorSchedule> Schedules { get; set; } = new List<DoctorSchedule>();

  //Link to appointments
  public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();



}