using System.ComponentModel.DataAnnotations;

namespace Models;
public class PrescriptionDetail : BaseEntity
{
  public int Id { get; set; }

  //Link to prescription 
  public int PrescriptionId { get; set; }
  public Prescription Prescription { get; set; }

  [Required]
  [StringLength(200)]
  public string MedicineName { get; set; } = string.Empty;

  [Required]
  [StringLength(100)]
  public string Dosage { get; set; } = string.Empty;


  // Số lượng
  [Required]
  [Range(1, 1000)]
  public int Quantity { get; set; }

  // Đơn vị (viên, chai, gói...)
  [Required]
  [StringLength(50)]
  public string Unit { get; set; } = string.Empty;

  // Tần suất sử dụng
  [Required]
  [StringLength(100)]
  public string Frequency { get; set; } = string.Empty; // Ví dụ: 3 lần/ngày


  // Cách dùng
  [Required]
  [StringLength(200)]
  public string Usage { get; set; } = string.Empty; // Ví dụ: Uống sau ăn

  // Thời gian điều trị
  public int Duration { get; set; } // Số ngày

  // Hướng dẫn đặc biệt
  [StringLength(500)]
  public string? SpecialInstructions { get; set; }

  // Giá tiền
  [Range(0, double.MaxValue)]
  public decimal UnitPrice { get; set; }

  [Range(0, double.MaxValue)]
  public decimal TotalAmount { get; set; }

}