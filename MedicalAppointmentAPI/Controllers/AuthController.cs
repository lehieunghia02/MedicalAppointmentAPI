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
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  public async Task<IActionResult> Login([FromBody] LoginRequest request)
  {
    try
    {
      var result = await _authService.Login(request);
      return Ok(result);
    }
    catch (UnauthorizedAccessException ex) when (ex.Message.Contains("confirm your email"))
    {
      _logger.LogWarning("Login attempt with unconfirmed email: {Email}", request.Email);
      return BadRequest(new
      {
        status = 400,
        message = "Email chưa được xác thực",
        errors = new
        {
          email = "Vui lòng xác thực email trước khi đăng nhập",
          details = "Chúng tôi đã gửi email xác thực đến địa chỉ email của bạn. Vui lòng kiểm tra hộp thư (bao gồm cả thư rác) và làm theo hướng dẫn.",
          canResend = true
        }
      });
    }
    catch (UnauthorizedAccessException ex) when (ex.Message.Contains("not active"))
    {
      _logger.LogWarning("Login attempt with inactive account: {Email}", request.Email);
      return BadRequest(new
      {
        status = 400,
        message = "Tài khoản chưa được kích hoạt",
        errors = new
        {
          account = "Tài khoản của bạn chưa được kích hoạt",
          details = "Vui lòng liên hệ với quản trị viên để được hỗ trợ."
        }
      });
    }
    catch (UnauthorizedAccessException ex)
    {
      _logger.LogWarning("Login failed for user {Email}: {Message}", request.Email, ex.Message);
      return Unauthorized(new
      {
        status = 401,
        message = "Đăng nhập thất bại",
        errors = new { credentials = "Email hoặc mật khẩu không chính xác" }
      });
    }
    catch (Exception ex) when (ex.Message.Contains("locked out"))
    {
      _logger.LogWarning("Account locked for user {Email}", request.Email);
      return BadRequest(new
      {
        status = 400,
        message = "Tài khoản đã bị khóa",
        errors = new
        {
          account = "Tài khoản của bạn đã bị khóa do đăng nhập sai nhiều lần",
          details = "Vui lòng thử lại sau 5 phút hoặc sử dụng chức năng quên mật khẩu để đặt lại mật khẩu."
        }
      });
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Unexpected error during login for user {Email}", request.Email);
      return StatusCode(StatusCodes.Status500InternalServerError, new
      {
        status = 500,
        message = "Đã xảy ra lỗi trong quá trình đăng nhập",
        errors = new { general = "Vui lòng thử lại sau hoặc liên hệ hỗ trợ nếu vấn đề vẫn tiếp tục." }
      });
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

  // [HttpPost("resend-confirmation-email")]
  // [ProducesResponseType(StatusCodes.Status200OK)]
  // [ProducesResponseType(StatusCodes.Status400BadRequest)]
  // public async Task<IActionResult> ResendConfirmationEmail([FromBody] string email)
  // {
  //   try
  //   {
  //     await _authService.ResendConfirmationEmail(email);
  //     return Ok(new
  //     {
  //       status = 200,
  //       message = "Đã gửi lại email xác thực",
  //       details = "Vui lòng kiểm tra hộp thư (bao gồm cả thư rác) và làm theo hướng dẫn trong email."
  //     });
  //   }
  //   catch (InvalidOperationException ex) when (ex.Message.Contains("already confirmed"))
  //   {
  //     return BadRequest(new
  //     {
  //       status = 400,
  //       message = "Email đã được xác thực",
  //       errors = new { email = "Email này đã được xác thực trước đó. Bạn có thể đăng nhập bình thường." }
  //     });
  //   }
  //   catch (Exception ex)
  //   {
  //     _logger.LogError(ex, "Error sending confirmation email to {Email}", email);
  //     return BadRequest(new
  //     {
  //       status = 400,
  //       message = "Không thể gửi email xác thực",
  //       errors = new { email = "Đã xảy ra lỗi khi gửi email xác thực. Vui lòng thử lại sau." }
  //     });
  //   }
  // }
}