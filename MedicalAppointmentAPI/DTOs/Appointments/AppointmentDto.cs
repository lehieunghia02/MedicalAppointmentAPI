namespace MedicalAppointmentAPI.DTOs.Appointments
{
  /// <summary>
  /// DTO for basic appointment information in list responses
  /// </summary>
  public class AppointmentDto
  {
    public int Id { get; set; }

    public DateTime AppointmentDate { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string Status { get; set; }

    public int DoctorId { get; set; }

    public string DoctorName { get; set; }

    public int PatientId { get; set; }

    public string PatientName { get; set; }

    public string Notes { get; set; }
  }
}