using MedicalAppointmentAPI.DTOs.Paginations;
using MedicalAppointmentAPI.DTOs.Specialty;

namespace MedicalAppointmentAPI.Services.Interfaces
{
  /// <summary>
  /// Interface định nghĩa các phương thức quản lý chuyên khoa
  /// </summary>
  public interface ISpecialtyService
  {
    /// <summary>
    /// Lấy danh sách chuyên khoa có phân trang và lọc
    /// </summary>
    /// <param name="filterDto">Thông tin lọc và phân trang</param>
    /// <returns>Danh sách chuyên khoa đã phân trang</returns>
    Task<PaginationResult<SpecialtyDto>> GetSpecialtiesAsync(SpecialtyFilterDto filterDto);

    /// <summary>
    /// Lấy thông tin chi tiết của một chuyên khoa theo ID
    /// </summary>
    /// <param name="id">ID của chuyên khoa</param>
    /// <returns>Thông tin chi tiết chuyên khoa</returns>
    Task<SpecialtyDto> GetSpecialtyByIdAsync(int id);

    /// <summary>
    /// Tạo mới một chuyên khoa
    /// </summary>
    /// <param name="createDto">Thông tin chuyên khoa cần tạo</param>
    /// <returns>Thông tin chuyên khoa đã tạo</returns>
    Task<SpecialtyDto> CreateSpecialtyAsync(CreateSpecialtyDto createDto);

    /// <summary>
    /// Cập nhật thông tin chuyên khoa
    /// </summary>
    /// <param name="id">ID của chuyên khoa</param>
    /// <param name="updateDto">Thông tin cập nhật</param>
    /// <returns>Thông tin chuyên khoa sau khi cập nhật</returns>
    Task<SpecialtyDto> UpdateSpecialtyAsync(int id, UpdateSpecialtyDto updateDto);

    /// <summary>
    /// Xóa một chuyên khoa
    /// </summary>
    /// <param name="id">ID của chuyên khoa</param>
    /// <returns>True nếu xóa thành công, ngược lại là False</returns>
    Task<bool> DeleteSpecialtyAsync(int id);

    /// <summary>
    /// Lấy tất cả chuyên khoa (không phân trang)
    /// </summary>
    /// <returns>Danh sách tất cả chuyên khoa</returns>
    Task<List<SpecialtyDto>> GetAllSpecialtiesAsync();
  }
}