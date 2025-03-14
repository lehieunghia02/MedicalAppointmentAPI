using System.ComponentModel.DataAnnotations;

namespace MedicalAppointmentAPI.DTOs.Doctor
{
  /// <summary>
  /// DTO for creating a doctor schedule
  /// </summary>
  public class CreateDoctorScheduleDto
  {
    [Required(ErrorMessage = "Day of week is required")]
    [Range(0, 6, ErrorMessage = "Day of week must be between 0 (Sunday) and 6 (Saturday)")]
    public int DayOfWeek { get; set; }

    [Required(ErrorMessage = "Start time is required")]
    public TimeSpan StartTime { get; set; }

    [Required(ErrorMessage = "End time is required")]
    public TimeSpan EndTime { get; set; }
  }
}