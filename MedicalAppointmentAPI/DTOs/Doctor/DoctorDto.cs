using System.ComponentModel.DataAnnotations;

namespace MedicalAppointmentAPI.DTOs.Doctor
{
  /// <summary>
  /// DTO for basic doctor information in list responses
  /// </summary>
  public class DoctorDto
  {
    public int Id { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string SpecialtyName { get; set; }

    public int SpecialtyId { get; set; }

    public string ProfileImage { get; set; }

    public bool IsAvailable { get; set; }
  }
}