using System.ComponentModel.DataAnnotations;
using MedicalAppointmentAPI.Common.Enums;
using MedicalAppointmentAPI.Models;

namespace Models;

public class Appointment : BaseEntity
{

  public int Id { get; set; }

  //Thông tin bác sĩ
  public int DoctorId { get; set; }
  public Doctor Doctor { get; set; }

  //Thông tin bệnh nhân

  public int PatientId { get; set; }
  public Patient Patient { get; set; }

  // Ngày giờ hẹn
  [Required]
  public DateTime AppointmentDate { get; set; }

  // Thời gian bắt đầu
  [Required]
  public DateTime StartTime { get; set; }

  //Thời gian kết thúc 
  [Required]
  public DateTime EndTime { get; set; }

  //Trạng thái của cuộc hẹn 
  // Ghi chú (Nếu có)
  public int AppointmentStatusId { get; set; }
  public AppointmentStatus AppointmentStatus { get; set; }

  [StringLength(500)]
  public string? Symptoms { get; set; }

  //Ghi chú (Nếu có)
  [StringLength(1000)]
  public string? Notes { get; set; }
}