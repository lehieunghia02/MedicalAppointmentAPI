using HospitalManagement.DTOs.Patients;
using MedicalAppointmentAPI.Common.Constants;
using MedicalAppointmentAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
namespace MedicalAppointmentAPI.Controllers;

[ApiController]
[Route("api/patients")]
public class PatientsController : ControllerBase
{
  private readonly IAuthService _authService; 
  private readonly ILogger<PatientsController> _logger; 
  private readonly IPatientService _patientService;
  public PatientsController(IAuthService authService, ILogger<PatientsController> logger, IPatientService patientService)
  {
    _authService = authService;
    _logger = logger;
    _patientService = patientService;
  }
  //Cập nhật thông tin bệnh nhân
  [HttpPost("cap-nhat-thong-tin")]
  [Authorize(Policy = SystemConstants.Policies.RequirePatient)]
  public async Task<IActionResult> UpdateProfile([FromBody] UpdatePatientRequest request)
  {
    try
    {
      var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      if(string.IsNullOrEmpty(userId))
      {
        return Unauthorized();
      }
      var patient = await _authService.UpdatePatient(userId, request);
      return Ok(patient);
    }
    catch(Exception ex)
    {
      _logger.LogError(ex, "Error updating patient profile");
      return StatusCode(StatusCodes.Status500InternalServerError, "Error updating patient profile");
    }
  }
}
