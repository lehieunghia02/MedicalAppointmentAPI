using System.ComponentModel.DataAnnotations;

namespace MedicalAppointmentAPI.DTOs.Appointments
{
  /// <summary>
  /// DTO for updating appointment status
  /// </summary>
  public class UpdateAppointmentStatusDto
  {
    [Required(ErrorMessage = "Status is required")]
    public string Status { get; set; }

    [StringLength(500, ErrorMessage = "Notes cannot exceed 500 characters")]
    public string Notes { get; set; }
  }
}