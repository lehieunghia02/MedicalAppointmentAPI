using System.ComponentModel.DataAnnotations;

namespace MedicalAppointmentAPI.DTOs.Doctor
{
  /// <summary>
  /// DTO for updating a doctor schedule
  /// </summary>
  public class UpdateDoctorScheduleDto
  {
    [Required(ErrorMessage = "Start time is required")]
    public TimeSpan StartTime { get; set; }

    [Required(ErrorMessage = "End time is required")]
    public TimeSpan EndTime { get; set; }

    public bool IsAvailable { get; set; } = true;
  }
}