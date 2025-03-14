using System.ComponentModel.DataAnnotations;

namespace MedicalAppointmentAPI.DTOs.Doctor
{
  /// <summary>
  /// DTO for detailed doctor information
  /// </summary>
  public class DoctorDetailDto
  {
    public int Id { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string SpecialtyName { get; set; }

    public int SpecialtyId { get; set; }

    public string ProfileImage { get; set; }

    public bool IsAvailable { get; set; }

    public string Biography { get; set; }

    public string Education { get; set; }

    public string Experience { get; set; }

    public string Address { get; set; }

    public int? ClinicId { get; set; }

    public string ClinicName { get; set; }

    public List<DoctorScheduleDto> Schedules { get; set; } = new List<DoctorScheduleDto>();
  }
}