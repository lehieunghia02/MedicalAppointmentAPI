using MedicalAppointmentAPI.DTOs.Paginations;

namespace MedicalAppointmentAPI.DTOs.Appointments
{
  /// <summary>
  /// DTO for filtering appointments
  /// </summary>
  public class AppointmentFilterDto : PaginationRequestDto
  {
    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public int? DoctorId { get; set; }

    public int? PatientId { get; set; }

    public string Status { get; set; }
  }
}