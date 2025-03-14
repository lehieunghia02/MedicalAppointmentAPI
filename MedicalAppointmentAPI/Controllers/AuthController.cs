using System.Runtime.CompilerServices;
using MedicalAppointmentAPI.DTOs.Auth;
using MedicalAppointmentAPI.DTOs.Auth.Request;
using MedicalAppointmentAPI.DTOs.Patients;
using MedicalAppointmentAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace MedicalAppointmentAPI.Controllers;

[AllowAnonymous]
[ApiController]
[Route("api/[controller]")]
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
      var result = await _authService.LoginAsync(request);
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

  /// <summary>
  /// Register for a new patient account
  /// </summary>
  /// <param name="request"></param>
  /// <returns></returns>
  [HttpPost("register-patient")]
  [ProducesResponseType(typeof(AuthResponse), StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> RegisterPatient([FromBody] RegisterPatientRequest request)
  {
    try
    {
      var response = await _authService.RegisterPatientAsync(request);
      return Ok(response);
    }
    catch (Exception ex)
    {
      return BadRequest(new { message = ex.Message });
    }
  }
  
  /// <summary>
  /// Controllers for refreshing token
  /// </summary>
  /// <param name="refreshToken"></param>
  /// <returns></returns>
  [HttpPost("refresh-token")]
  public async Task<IActionResult> RefreshToken([FromBody] string refreshToken)
  {
    try
    {
      var response = await _authService.RefreshTokenAsync(refreshToken);
      return Ok(response);
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error occurred while refreshing token");
      return BadRequest(new { message = ex.Message });
    }
  }
  
  [HttpPost("logout")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status401Unauthorized)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> Logout()
  {
    try
    {
      var token = Request.Headers["Authorization"].ToString().Split(" ")[1];
      var result = await _authService.Logout(token);
      if (!result.Succeeded)
      {
        return BadRequest(new LogoutResponse
        {
          Status = 400,
          Message = "Đăng xuất thất bại",
          Data = new LogoutResponse.LogoutData
          {
            Succeeded = false,
            Message = result.Message,
            LogoutTime = result.LogoutTime
          }
        });
      }
      return Ok(new LogoutResponse
      {
        Status = 200,
        Message = "Logout successfully",
        Data = new LogoutResponse.LogoutData
        {
          Succeeded = true,
          Message = "Đăng xuất thành công",
          LogoutTime = result.LogoutTime
        }
      });
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Error occurred while logging out");
      return StatusCode(StatusCodes.Status500InternalServerError, new
      {
        status = 500,
        message = "Đã xảy ra lỗi trong quá trình đăng xuất",
        errors = new { general = "Vui lòng thử lại sau hoặc liên hệ hỗ trợ nếu vấn đề vẫn tiếp tục." }
      });
    }
  }

  [HttpPost("revoke-token")]
  public async Task<IActionResult> RevokeToken([FromBody] string token)
  {
    try
    {
      var result = await _authService.RevokeTokenAsync(token);
      if (result)
      {
        return Ok(new {message = "Revoke token successfully"});
      }
      else
      {
        
        return BadRequest(new {message = "Revoke token failed"});
      }
      
    }
    catch (Exception e)
    {
      return BadRequest(new { message = e.Message });
    }
  }
}