using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
  [HttpGet("login")]
  public async Task<IActionResult> Login()
  {
    return Ok();
  }
}