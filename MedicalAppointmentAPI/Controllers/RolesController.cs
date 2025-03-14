using MedicalAppointmentAPI.Common.Constants;
using MedicalAppointmentAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
/*[Authorize(Roles = SystemConstants.Roles.SuperAdmin)]*/
[Authorize(Roles = SystemConstants.Roles.Patient)]
public class RolesController : ControllerBase
{
    private readonly IRoleService _roleService;
    private ILogger<RolesController> _logger;

    public RolesController(IRoleService roleService, ILogger<RolesController> logger)
    {
        _roleService = roleService;
        _logger = logger;
    }

    // GET: api/roles 
    // Lấy danh sách tất cả các vai trò 
    [HttpGet]
    public async Task<IActionResult> GetAllRoles()
    {
        try
        {
            var roles = await _roleService.GetAllRolesAsync();
            return Ok(roles);
        }
        catch (Exception e)
        {
            return StatusCode(500, "Internal server error");
        }
    }
    //Get user assigned by role
    [HttpGet("users")]
    public async Task<IActionResult> GetUsersByRole(string roleName, int page = 1, int pageSize = 10)
    {
        try
        {
            var (users, totalCount) = await _roleService.GetUsersByRoleNameAsync(roleName, page, pageSize);
            return Ok(new { Users = users, TotalCount = totalCount });
        }
        catch (Exception e)
        {
            return StatusCode(500, "Internal server error");
        }
    }
}