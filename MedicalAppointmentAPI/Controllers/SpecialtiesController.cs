using MedicalAppointmentAPI.Common.Constants;
using MedicalAppointmentAPI.DTOs.Paginations;
using MedicalAppointmentAPI.DTOs.Specialty;
using MedicalAppointmentAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentAPI.Controllers
{
  [Route("api/[controller]")]
  [Authorize(Policy = SystemConstants.Policies.RequireAdmin)]
  [Authorize(Policy = SystemConstants.Policies.RequireDoctor)]
  [Authorize(Policy = SystemConstants.Policies.RequirePatient)]
  [ApiController]
  public class SpecialtiesController : ControllerBase
  {
    private readonly ISpecialtyService _specialtyService;

    public SpecialtiesController(ISpecialtyService specialtyService)
    {
      _specialtyService = specialtyService;
    }

    /// <summary>
    /// Lấy danh sách chuyên khoa có phân trang và lọc
    /// </summary>
    /// <param name="filterDto">Thông tin lọc và phân trang</param>
    /// <returns>Danh sách chuyên khoa đã phân trang</returns>
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<PaginationResult<SpecialtyDto>>> GetSpecialties([FromQuery] SpecialtyFilterDto filterDto)
    {
      var result = await _specialtyService.GetSpecialtiesAsync(filterDto);
      return Ok(result);
    }

    /// <summary>
    /// Lấy thông tin chi tiết của một chuyên khoa theo ID
    /// </summary>
    /// <param name="id">ID của chuyên khoa</param>
    /// <returns>Thông tin chi tiết chuyên khoa</returns>
    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<SpecialtyDto>> GetSpecialtyById(int id)
    {
      try
      {
        var specialty = await _specialtyService.GetSpecialtyByIdAsync(id);
        return Ok(specialty);
      }
      catch (KeyNotFoundException ex)
      {
        return NotFound(new { message = ex.Message });
      }
    }

    /// <summary>
    /// Lấy tất cả chuyên khoa (không phân trang)
    /// </summary>
    /// <returns>Danh sách tất cả chuyên khoa</returns>
    [HttpGet("all")]
    [AllowAnonymous]
    public async Task<ActionResult<List<SpecialtyDto>>> GetAllSpecialties()
    {
      var specialties = await _specialtyService.GetAllSpecialtiesAsync();
      return Ok(specialties);
    }

    /// <summary>
    /// Tạo mới một chuyên khoa
    /// </summary>
    /// <param name="createDto">Thông tin chuyên khoa cần tạo</param>
    /// <returns>Thông tin chuyên khoa đã tạo</returns>
    [HttpPost]
    [Authorize(Policy = SystemConstants.Policies.RequirePatient)]
    public async Task<ActionResult<SpecialtyDto>> CreateSpecialty([FromBody] CreateSpecialtyDto createDto)
    {
      try
      {
        var specialty = await _specialtyService.CreateSpecialtyAsync(createDto);
        return CreatedAtAction(nameof(GetSpecialtyById), new { id = specialty.Id }, specialty);
      }
      catch (InvalidOperationException ex)
      {
        return BadRequest(new { message = ex.Message });
      }
    }

    /// <summary>
    /// Cập nhật thông tin chuyên khoa
    /// </summary>
    /// <param name="id">ID của chuyên khoa</param>
    /// <param name="updateDto">Thông tin cập nhật</param>
    /// <returns>Thông tin chuyên khoa sau khi cập nhật</returns>
    [HttpPut("{id}")]
    [Authorize(Policy = SystemConstants.Policies.RequireAdmin)]
    public async Task<ActionResult<SpecialtyDto>> UpdateSpecialty(int id, [FromBody] UpdateSpecialtyDto updateDto)
    {
      try
      {
        var specialty = await _specialtyService.UpdateSpecialtyAsync(id, updateDto);
        return Ok(specialty);
      }
      catch (KeyNotFoundException ex)
      {
        return NotFound(new { message = ex.Message });
      }
      catch (InvalidOperationException ex)
      {
        return BadRequest(new { message = ex.Message });
      }
    }

    /// <summary>
    /// Xóa một chuyên khoa
    /// </summary>
    /// <param name="id">ID của chuyên khoa</param>
    /// <returns>Thông báo kết quả</returns>
    [HttpDelete("{id}")]
    [Authorize(Policy = SystemConstants.Policies.RequireAdmin)]
    public async Task<ActionResult> DeleteSpecialty(int id)
    {
      try
      {
        await _specialtyService.DeleteSpecialtyAsync(id);
        return NoContent();
      }
      catch (KeyNotFoundException ex)
      {
        return NotFound(new { message = ex.Message });
      }
      catch (InvalidOperationException ex)
      {
        return BadRequest(new { message = ex.Message });
      }
    }
  }
}