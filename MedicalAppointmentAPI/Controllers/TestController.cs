using Microsoft.AspNetCore.Mvc;
using MedicalAppointmentAPI.Services.Interfaces;

namespace MedicalAppointmentAPI.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
  private readonly IEmailService _emailService;
  private readonly ILogger<TestController> _logger;

  public TestController(IEmailService emailService, ILogger<TestController> logger)
  {
    _emailService = emailService;
    _logger = logger;
  }

  [HttpGet("send-email")]
  public async Task<IActionResult> SendTestEmail()
  {
    try
    {
      await _emailService.SendEmailAsync(
          "lehieunghia2402@gmail.com",
          "Test Email",
          "<h1>This is a test email</h1><p>Testing email service</p>",
          true);

      return Ok(new { message = "Email sent successfully" });
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error sending test email");
      return StatusCode(500, new
      {
        message = "Failed to send email",
        error = ex.Message
      });
    }
  }
}

