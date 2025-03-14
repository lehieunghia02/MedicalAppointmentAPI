using MedicalAppointmentAPI.DTOs.Doctor;

namespace MedicalAppointmentAPI.DTOs.Appointments
{
  /// <summary>
  /// DTO for detailed appointment information
  /// </summary>
  public class AppointmentDetailDto
  {
    public int Id { get; set; }

    public DateTime AppointmentDate { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string Status { get; set; }

    public int DoctorId { get; set; }

    public string DoctorName { get; set; }

    public string DoctorSpecialty { get; set; }

    public int PatientId { get; set; }

    public string PatientName { get; set; }

    public string PatientEmail { get; set; }

    public string PatientPhone { get; set; }

    public string Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
  }
}