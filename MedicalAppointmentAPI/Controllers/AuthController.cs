using System.Runtime.CompilerServices;
using MedicalAppointmentAPI.DTOs.Auth;
using MedicalAppointmentAPI.DTOs.Patients;
using MedicalAppointmentAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentAPI.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
  private readonly IAuthService _authService;
  private readonly ILogger<AuthController> _logger;

  public AuthController(IAuthService authService, ILogger<AuthController> logger)
  {
    _authService = authService;
    _logger = logger;
  }

  [HttpPost("login")]
  [ProducesResponseType(typeof(AuthResponse), StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> Login([FromBody] LoginRequest request)
  {
    try
    {
      var result = await _authService.Login(request);
      return Ok(result);
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "An error occurred while logging in");
      return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while logging in");
    }
  }


  [HttpPost("register-patient")]
  [ProducesResponseType(typeof(AuthResponse), StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> RegisterPatient([FromBody] RegisterPatientRequest request)
  {
    try
    {
      var response = await _authService.RegisterPatient(request);
      return Ok(response);
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error occurred while registering patient with email: {Email}", request.Email);
      return BadRequest(new { message = ex.Message });
    }
  }

  [HttpPost("refresh-token")]
  [ProducesResponseType(typeof(AuthResponse), StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  public async Task<IActionResult> RefreshToken([FromBody] string refreshToken)
  {
    try
    {
      var response = await _authService.RefreshToken(refreshToken);
      return Ok(response);
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error occurred while refreshing token");
      return BadRequest(new { message = ex.Message });
    }
  }

  [Authorize]
  [HttpPost("logout")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  public async Task<IActionResult> Logout(string refreshToken)
  {
    try
    {
      await _authService.Logout(refreshToken);
      return Ok(new { message = "Logout sucessful" });
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error occurred while logging out");
      return BadRequest(new { message = ex.Message });
    }
  }
}