using System.ComponentModel.DataAnnotations;

namespace MedicalAppointmentAPI.DTOs.Specialty
{
  /// <summary>
  /// DTO cho việc cập nhật chuyên khoa
  /// </summary>
  public class UpdateSpecialtyDto
  {
    /// <summary>
    /// Tên chuyên khoa
    /// </summary>
    [Required(ErrorMessage = "Tên chuyên khoa là bắt buộc")]
    [StringLength(100, ErrorMessage = "Tên chuyên khoa không được vượt quá 100 ký tự")]
    public string Name { get; set; }

    /// <summary>
    /// Mô tả về chuyên khoa
    /// </summary>
    [Required(ErrorMessage = "Mô tả chuyên khoa là bắt buộc")]
    [StringLength(500, ErrorMessage = "Mô tả không được vượt quá 500 ký tự")]
    public string Description { get; set; }

    /// <summary>
    /// URL hình ảnh đại diện
    /// </summary>
    public string ImageUrl { get; set; }

    /// <summary>
    /// Trạng thái hoạt động
    /// </summary>
    public bool IsActive { get; set; }
  }
}