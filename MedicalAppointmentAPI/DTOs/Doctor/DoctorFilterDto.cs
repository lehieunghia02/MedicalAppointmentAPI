using MedicalAppointmentAPI.DTOs.Paginations;

namespace MedicalAppointmentAPI.DTOs.Doctor
{
  /// <summary>
  /// DTO for filtering doctors
  /// </summary>
  public class DoctorFilterDto : PaginationRequestDto
  {
    public string SearchTerm { get; set; } = string.Empty;

    public int? SpecialtyId { get; set; }

    public int? ClinicId { get; set; }

    public bool? IsAvailable { get; set; }
  }
}