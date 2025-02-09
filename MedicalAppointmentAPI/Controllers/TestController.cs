using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentAPI.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
  [HttpGet]

  public IActionResult Get()
  {
    return Ok("Hello World");
  }
}

