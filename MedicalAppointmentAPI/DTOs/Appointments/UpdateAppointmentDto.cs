using System.ComponentModel.DataAnnotations;

namespace MedicalAppointmentAPI.DTOs.Appointments
{
  /// <summary>
  /// DTO for updating appointment information
  /// </summary>
  public class UpdateAppointmentDto
  {
    [Required(ErrorMessage = "Appointment date is required")]
    public DateTime AppointmentDate { get; set; }

    [Required(ErrorMessage = "Start time is required")]
    public TimeSpan StartTime { get; set; }

    [Required(ErrorMessage = "End time is required")]
    public TimeSpan EndTime { get; set; }

    [Required(ErrorMessage = "Doctor ID is required")]
    public int DoctorId { get; set; }

    [StringLength(500, ErrorMessage = "Notes cannot exceed 500 characters")]
    public string Notes { get; set; }
  }
}