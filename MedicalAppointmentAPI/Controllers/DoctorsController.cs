using MedicalAppointmentAPI.Common.Constants;
using MedicalAppointmentAPI.DTOs.Doctor;
using MedicalAppointmentAPI.DTOs.Paginations;
using MedicalAppointmentAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentAPI.Controllers
{
  [Authorize(Policy = SystemConstants.Policies.RequireDoctor)]
  [Route("api/[controller]")]
  [ApiController]
  public class DoctorsController : ControllerBase
  {
    private readonly IDoctorService _doctorService;

    public DoctorsController(IDoctorService doctorService)
    {
      _doctorService = doctorService;
    }

    /// <summary>
    /// Get all doctors with pagination and filtering
    /// </summary>
    /// <param name="filterDto">Filter parameters</param>
    /// <returns>List of doctors</returns>
    [HttpGet]
    [Authorize]
    public async Task<ActionResult<PaginationResult<DoctorDto>>> GetDoctors([FromQuery] DoctorFilterDto filterDto)
    {
      var result = await _doctorService.GetDoctorsAsync(filterDto);
      return Ok(result);
    }

    /// <summary>
    /// Get doctor details by ID
    /// </summary>
    /// <param name="id">Doctor ID</param>
    /// <returns>Doctor details</returns>
    [HttpGet("{id}")]
    [Authorize]
    public async Task<ActionResult<DoctorDetailDto>> GetDoctorById(int id)
    {
      try
      {
        var doctor = await _doctorService.GetDoctorByIdAsync(id);
        return Ok(doctor);
      }
      catch (KeyNotFoundException ex)
      {
        return NotFound(new { message = ex.Message });
      }
    }

    /// <summary>
    /// Create a new doctor
    /// </summary>
    /// <param name="createDto">Doctor creation data</param>
    /// <returns>Created doctor details</returns>
    [HttpPost]
    [Authorize(Policy = SystemConstants.Policies.RequireAdmin)]
    public async Task<ActionResult<DoctorDetailDto>> CreateDoctor([FromBody] CreateDoctorDto createDto)
    {
      try
      {
        var doctor = await _doctorService.CreateDoctorAsync(createDto);
        return CreatedAtAction(nameof(GetDoctorById), new { id = doctor.Id }, doctor);
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
    /// Update doctor information
    /// </summary>
    /// <param name="id">Doctor ID</param>
    /// <param name="updateDto">Doctor update data</param>
    /// <returns>Updated doctor details</returns>
    [HttpPut("{id}")]
    [Authorize(Policy = SystemConstants.Policies.RequireAdmin)]
    public async Task<ActionResult<DoctorDetailDto>> UpdateDoctor(int id, [FromBody] UpdateDoctorDto updateDto)
    {
      try
      {
        var doctor = await _doctorService.UpdateDoctorAsync(id, updateDto);
        return Ok(doctor);
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
    /// Delete a doctor
    /// </summary>
    /// <param name="id">Doctor ID</param>
    /// <returns>No content</returns>
    [HttpDelete("{id}")]
    [Authorize(Policy = SystemConstants.Policies.RequireAdmin)]
    public async Task<ActionResult> DeleteDoctor(int id)
    {
      try
      {
        await _doctorService.DeleteDoctorAsync(id);
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

    /// <summary>
    /// Get doctors by specialty
    /// </summary>
    /// <param name="specialtyId">Specialty ID</param>
    /// <param name="paginationDto">Pagination parameters</param>
    /// <returns>List of doctors</returns>
    [HttpGet("specialties/{specialtyId}")]
    [Authorize]
    public async Task<ActionResult<PaginationResult<DoctorDto>>> GetDoctorsBySpecialty(int specialtyId, [FromQuery] PaginationRequestDto paginationDto)
    {
      try
      {
        var result = await _doctorService.GetDoctorsBySpecialtyAsync(specialtyId, paginationDto);
        return Ok(result);
      }
      catch (KeyNotFoundException ex)
      {
        return NotFound(new { message = ex.Message });
      }
    }

    /// <summary>
    /// Get available doctors for a specific date/time
    /// </summary>
    /// <param name="availabilityDto">Availability parameters</param>
    /// <returns>List of available doctors</returns>
    [HttpGet("available")]
    [Authorize]
    public async Task<ActionResult<List<DoctorDto>>> GetAvailableDoctors([FromQuery] AvailabilityRequestDto availabilityDto)
    {
      var doctors = await _doctorService.GetAvailableDoctorsAsync(availabilityDto);
      return Ok(doctors);
    }

    /// <summary>
    /// Add doctor schedule
    /// </summary>
    /// <param name="doctorId">Doctor ID</param>
    /// <param name="scheduleDto">Schedule creation data</param>
    /// <returns>Created schedule</returns>
    [HttpPost("{doctorId}/schedule")]
    [Authorize(Policy = SystemConstants.Policies.RequireAdmin)]
    public async Task<ActionResult<DoctorScheduleDto>> AddDoctorSchedule(int doctorId, [FromBody] CreateDoctorScheduleDto scheduleDto)
    {
      try
      {
        var schedule = await _doctorService.AddDoctorScheduleAsync(doctorId, scheduleDto);
        return CreatedAtAction(nameof(GetDoctorById), new { id = doctorId }, schedule);
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
    /// Update doctor schedule
    /// </summary>
    /// <param name="doctorId">Doctor ID</param>
    /// <param name="scheduleId">Schedule ID</param>
    /// <param name="scheduleDto">Schedule update data</param>
    /// <returns>Updated schedule</returns>
    [HttpPut("{doctorId}/schedule/{scheduleId}")]
    [Authorize(Policy = SystemConstants.Policies.RequireAdmin)]
    public async Task<ActionResult<DoctorScheduleDto>> UpdateDoctorSchedule(int doctorId, int scheduleId, [FromBody] UpdateDoctorScheduleDto scheduleDto)
    {
      try
      {
        var schedule = await _doctorService.UpdateDoctorScheduleAsync(doctorId, scheduleId, scheduleDto);
        return Ok(schedule);
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
    /// Delete doctor schedule
    /// </summary>
    /// <param name="doctorId">Doctor ID</param>
    /// <param name="scheduleId">Schedule ID</param>
    /// <returns>No content</returns>
    [HttpDelete("{doctorId}/schedule/{scheduleId}")]
    [Authorize(Policy = SystemConstants.Policies.RequireAdmin)]
    public async Task<ActionResult> DeleteDoctorSchedule(int doctorId, int scheduleId)
    {
      try
      {
        await _doctorService.DeleteDoctorScheduleAsync(doctorId, scheduleId);
        return NoContent();
      }
      catch (KeyNotFoundException ex)
      {
        return NotFound(new { message = ex.Message });
      }
    }
  }
}