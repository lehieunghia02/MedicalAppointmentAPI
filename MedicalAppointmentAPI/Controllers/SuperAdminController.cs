using MedicalAppointmentAPI.Common.Constants;
using MedicalAppointmentAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Policy = SystemConstants.Policies.RequireSuperAdmin)]
public class SuperAdminController : ControllerBase
{
    private readonly ISuperAdminService _superAdminService;
    private readonly ILogger<SuperAdminController> _logger; 
    public SuperAdminController(ISuperAdminService superAdminService, ILogger<SuperAdminController> logger)
    {
        _superAdminService = superAdminService;
        _logger = logger;
    }

    //GET: api/SuperAdmin/get-patients
    [HttpGet("get-patients")]
    public async Task<IActionResult> GetPatients(int page = 1, int pageSize = 10)
    {
        try
        {
            var (patients, totalCount) = await _superAdminService.GetPatientsAsync(page, pageSize);
            return Ok(new { Patients = patients, TotalCount = totalCount });
        }
        catch (Exception e)
        {
            return StatusCode(500, "Internal server error");
        }
    }
    
}