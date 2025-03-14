namespace MedicalAppointmentAPI.DTOs.Doctor
{
  /// <summary>
  /// DTO for doctor schedule information
  /// </summary>
  public class DoctorScheduleDto
  {
    public int Id { get; set; }

    public int DoctorId { get; set; }

    public string DayOfWeek { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public bool IsAvailable { get; set; }
  }
}