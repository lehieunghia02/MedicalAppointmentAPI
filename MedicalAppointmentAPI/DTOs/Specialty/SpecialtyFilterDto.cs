using MedicalAppointmentAPI.DTOs.Paginations;

namespace MedicalAppointmentAPI.DTOs.Specialty
{
  /// <summary>
  /// DTO cho việc lọc danh sách chuyên khoa
  /// </summary>
  public class SpecialtyFilterDto : PaginationRequestDto
  {
    /// <summary>
    /// Từ khóa tìm kiếm (tên hoặc mô tả)
    /// </summary>
    public string SearchTerm { get; set; }

    /// <summary>
    /// Lọc theo trạng thái hoạt động
    /// </summary>
    public bool? IsActive { get; set; }
  }
}