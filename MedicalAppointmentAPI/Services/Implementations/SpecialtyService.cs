using MedicalAppointmentAPI.Data;
using MedicalAppointmentAPI.DTOs.Paginations;
using MedicalAppointmentAPI.DTOs.Specialty;
using MedicalAppointmentAPI.Repositories.Interfaces;
using MedicalAppointmentAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace MedicalAppointmentAPI.Services.Implementations
{
  /// <summary>
  /// Service quản lý chuyên khoa
  /// </summary>
  public class SpecialtyService : ISpecialtyService
  {
    private readonly IBaseRepository<Specialty> _specialtyRepository;
    private readonly ApplicationDbContext _dbContext;

    public SpecialtyService(
        IBaseRepository<Specialty> specialtyRepository,
        ApplicationDbContext dbContext)
    {
      _specialtyRepository = specialtyRepository;
      _dbContext = dbContext;
    }

    /// <summary>
    /// Lấy danh sách chuyên khoa có phân trang và lọc
    /// </summary>
    public async Task<PaginationResult<SpecialtyDto>> GetSpecialtiesAsync(SpecialtyFilterDto filterDto)
    {
      // Xây dựng truy vấn với các bộ lọc
      var query = _specialtyRepository.Query()
          .Include(s => s.Doctors)
          .AsQueryable();

      // Áp dụng bộ lọc
      if (!string.IsNullOrWhiteSpace(filterDto.SearchTerm))
      {
        var searchTerm = filterDto.SearchTerm.ToLower();
        query = query.Where(s =>
            s.Name.ToLower().Contains(searchTerm) ||
            s.Description.ToLower().Contains(searchTerm));
      }

      if (filterDto.IsActive.HasValue)
      {
        query = query.Where(s => s.IsActive == filterDto.IsActive.Value);
      }

      // Áp dụng sắp xếp
      query = ApplySorting(query, filterDto.SortBy, filterDto.SortDirection);

      // Lấy tổng số lượng
      var totalCount = await query.CountAsync();

      // Áp dụng phân trang
      var specialties = await query
          .Skip((filterDto.PageNumber - 1) * filterDto.PageSize)
          .Take(filterDto.PageSize)
          .ToListAsync();

      // Chuyển đổi sang DTO
      var specialtyDtos = specialties.Select(s => new SpecialtyDto
      {
        Id = s.Id,
        Name = s.Name,
        Description = s.Description,
        ImageUrl = s.ImageUrl,
        IsActive = s.IsActive,
        DoctorCount = s.Doctors.Count
      }).ToList();

      // Tạo kết quả phân trang
      return new PaginationResult<SpecialtyDto>
      {
        PageNumber = filterDto.PageNumber,
        PageSize = filterDto.PageSize,
        TotalCount = totalCount,
        Items = specialtyDtos
      };
    }

    /// <summary>
    /// Lấy thông tin chi tiết của một chuyên khoa theo ID
    /// </summary>
    public async Task<SpecialtyDto> GetSpecialtyByIdAsync(int id)
    {
      var specialty = await _specialtyRepository.Query()
          .Include(s => s.Doctors)
          .FirstOrDefaultAsync(s => s.Id == id);

      if (specialty == null)
      {
        throw new KeyNotFoundException($"Không tìm thấy chuyên khoa với ID {id}");
      }

      return new SpecialtyDto
      {
        Id = specialty.Id,
        Name = specialty.Name,
        Description = specialty.Description,
        ImageUrl = specialty.ImageUrl,
        IsActive = specialty.IsActive,
        DoctorCount = specialty.Doctors.Count
      };
    }

    /// <summary>
    /// Tạo mới một chuyên khoa
    /// </summary>
    public async Task<SpecialtyDto> CreateSpecialtyAsync(CreateSpecialtyDto createDto)
    {
      // Kiểm tra xem tên chuyên khoa đã tồn tại chưa
      var existingSpecialty = await _specialtyRepository.Query()
          .FirstOrDefaultAsync(s => s.Name.ToLower() == createDto.Name.ToLower());

      if (existingSpecialty != null)
      {
        throw new InvalidOperationException($"Chuyên khoa với tên '{createDto.Name}' đã tồn tại");
      }

      // Tạo chuyên khoa mới
      var specialty = new Specialty
      {
        Name = createDto.Name,
        Description = createDto.Description,
        ImageUrl = createDto.ImageUrl,
        IsActive = createDto.IsActive,
        CreatedAt = DateTime.UtcNow
      };

      await _specialtyRepository.AddAsync(specialty);

      // Trả về thông tin chuyên khoa đã tạo
      return new SpecialtyDto
      {
        Id = specialty.Id,
        Name = specialty.Name,
        Description = specialty.Description,
        ImageUrl = specialty.ImageUrl,
        IsActive = specialty.IsActive,
        DoctorCount = 0
      };
    }

    /// <summary>
    /// Cập nhật thông tin chuyên khoa
    /// </summary>
    public async Task<SpecialtyDto> UpdateSpecialtyAsync(int id, UpdateSpecialtyDto updateDto)
    {
      var specialty = await _specialtyRepository.GetByIdAsync(id);

      if (specialty == null)
      {
        throw new KeyNotFoundException($"Không tìm thấy chuyên khoa với ID {id}");
      }

      // Kiểm tra xem tên mới có trùng với chuyên khoa khác không
      var existingSpecialty = await _specialtyRepository.Query()
          .FirstOrDefaultAsync(s => s.Name.ToLower() == updateDto.Name.ToLower() && s.Id != id);

      if (existingSpecialty != null)
      {
        throw new InvalidOperationException($"Chuyên khoa với tên '{updateDto.Name}' đã tồn tại");
      }

      // Cập nhật thông tin
      specialty.Name = updateDto.Name;
      specialty.Description = updateDto.Description;
      specialty.ImageUrl = updateDto.ImageUrl;
      specialty.IsActive = updateDto.IsActive;
      specialty.UpdatedAt = DateTime.UtcNow;

      await _specialtyRepository.UpdateAsync(specialty);

      // Lấy số lượng bác sĩ
      var doctorCount = await _dbContext.Doctors.CountAsync(d => d.SpecialtyId == id);

      // Trả về thông tin đã cập nhật
      return new SpecialtyDto
      {
        Id = specialty.Id,
        Name = specialty.Name,
        Description = specialty.Description,
        ImageUrl = specialty.ImageUrl,
        IsActive = specialty.IsActive,
        DoctorCount = doctorCount
      };
    }

    /// <summary>
    /// Xóa một chuyên khoa
    /// </summary>
    public async Task<bool> DeleteSpecialtyAsync(int id)
    {
      var specialty = await _specialtyRepository.GetByIdAsync(id);

      if (specialty == null)
      {
        throw new KeyNotFoundException($"Không tìm thấy chuyên khoa với ID {id}");
      }

      // Kiểm tra xem có bác sĩ nào thuộc chuyên khoa này không
      var hasDoctors = await _dbContext.Doctors.AnyAsync(d => d.SpecialtyId == id);

      if (hasDoctors)
      {
        throw new InvalidOperationException("Không thể xóa chuyên khoa đang có bác sĩ");
      }

      await _specialtyRepository.DeleteAsync(id);
      return true;
    }

    /// <summary>
    /// Lấy tất cả chuyên khoa (không phân trang)
    /// </summary>
    public async Task<List<SpecialtyDto>> GetAllSpecialtiesAsync()
    {
      var specialties = await _specialtyRepository.Query()
          .Include(s => s.Doctors)
          .ToListAsync();

      return specialties.Select(s => new SpecialtyDto
      {
        Id = s.Id,
        Name = s.Name,
        Description = s.Description,
        ImageUrl = s.ImageUrl,
        IsActive = s.IsActive,
        DoctorCount = s.Doctors.Count
      }).ToList();
    }

    /// <summary>
    /// Áp dụng sắp xếp cho truy vấn
    /// </summary>
    private IQueryable<Specialty> ApplySorting(IQueryable<Specialty> query, string sortBy, string sortDirection)
    {
      // Mặc định sắp xếp theo ID
      if (string.IsNullOrWhiteSpace(sortBy))
      {
        sortBy = "Id";
      }

      // Xác định hướng sắp xếp
      var isAscending = string.IsNullOrWhiteSpace(sortDirection) || sortDirection.ToLower() == "asc";

      // Áp dụng sắp xếp dựa trên thuộc tính
      switch (sortBy.ToLower())
      {
        case "name":
          return isAscending
              ? query.OrderBy(s => s.Name)
              : query.OrderByDescending(s => s.Name);
        case "isactive":
          return isAscending
              ? query.OrderBy(s => s.IsActive)
              : query.OrderByDescending(s => s.IsActive);
        case "doctorcount":
          return isAscending
              ? query.OrderBy(s => s.Doctors.Count)
              : query.OrderByDescending(s => s.Doctors.Count);
        default:
          return isAscending
              ? query.OrderBy(s => s.Id)
              : query.OrderByDescending(s => s.Id);
      }
    }
  }
}