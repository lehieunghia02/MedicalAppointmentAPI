using System.ComponentModel.DataAnnotations;
using MedicalAppointmentAPI.Models;

namespace Models;
public class Prescription : BaseEntity
{
  public int Id { get; set; }

  //Link to medical record 
  public int MedicalRecordId { get; set; }
  public MedicalRecord MedicalRecord { get; set; }

  //Link to doctor 
  public int DoctorId { get; set; }
  public Doctor Doctor { get; set; }

  //Link to patient 
  public int PatientId { get; set; }
  public Patient Patient { get; set; }

  //Thông tin đơn thuốc
  [Required]
  public DateTime PrescriptionDate { get; set; } = DateTime.UtcNow;


  [StringLength(500)]
  public string? Diagnosis { get; set; }

  [StringLength(1000)]
  public string? Notes { get; set; }


  // Hướng dẫn sử dụng chung
  [StringLength(1000)]
  public string? GeneralInstructions { get; set; }

  //Trạng thái đơn thuốc 
  public bool IsProcessed { get; set; } = false;

  // Người xử lý đơn thuốc (dược sĩ)
  public string? ProcessedBy { get; set; }
  public DateTime? ProcessedDate { get; set; }


  //Chi tiết đơn thuốc
  public List<PrescriptionDetail> Details { get; set; } = new List<PrescriptionDetail>();
}