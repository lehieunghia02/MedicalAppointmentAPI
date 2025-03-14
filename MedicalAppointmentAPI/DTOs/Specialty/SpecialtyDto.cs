using System.ComponentModel.DataAnnotations;

namespace MedicalAppointmentAPI.DTOs.Specialty
{
  /// <summary>
  /// DTO cho thông tin chuyên khoa
  /// </summary>
  public class SpecialtyDto
  {
    /// <summary>
    /// ID của chuyên khoa
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Tên chuyên khoa
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Mô tả về chuyên khoa
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// URL hình ảnh đại diện
    /// </summary>
    public string ImageUrl { get; set; }

    /// <summary>
    /// Trạng thái hoạt động
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Số lượng bác sĩ thuộc chuyên khoa
    /// </summary>
    public int DoctorCount { get; set; }
  }
}