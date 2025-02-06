using System.ComponentModel.DataAnnotations;
using MedicalAppointmentAPI.Models;

namespace Models;
/// <summary>
/// Table store medical records of patient
/// </summary>
public class MedicalRecord : BaseEntity
{
  public int Id { get; set; }

  //Link to patient
  public int PatientId { get; set; }
  public Patient Patient { get; set; }

  //Link to doctor 
  public int DoctorId { get; set; }
  public Doctor Doctor { get; set; }

  //Link to appointment 
  public int AppointmentId { get; set; }
  public Appointment Appointment { get; set; }

  //Chuẩn đoán của bệnh nhân
  public string Diagnosis { get; set; } = string.Empty;

  // Triệu chứng
  [StringLength(500)]
  public string Symptoms { get; set; } = string.Empty;

  //Phương pháp điều trị 
  [Required]
  [StringLength(1000)]
  public string Treatment { get; set; } = string.Empty;

  // Đơn thuốc
  public string? Prescription { get; set; }

  // Kết quả xét nghiệm/hình ảnh
  public string? TestResults { get; set; }
  // Ghi chú của bác sĩ
  [StringLength(1000)]
  public string? Notes { get; set; }


  // Chi phí khám
  [Range(0, double.MaxValue)]
  public decimal ConsultationFee { get; set; }

  // Theo dõi tái khám
  public bool IsFollowUpRequired { get; set; }
  public DateTime? FollowUpDate { get; set; }
}
