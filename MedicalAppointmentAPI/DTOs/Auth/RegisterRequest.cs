using System.ComponentModel.DataAnnotations;
using MedicalAppointmentAPI.Common.Enums;

namespace MedicalAppointmentAPI.DTOs.Auth;
public class RegisterRequest
{
  //Tên đăng nhập
  [Required(ErrorMessage = "Username is required")]
  [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters")]
  public string Username { get; set; } = string.Empty;
  //Email
  [Required(ErrorMessage = "Email is required")]
  [EmailAddress(ErrorMessage = "Invalid email address")]
  public string Email { get; set; } = string.Empty;
  //Mật khẩu
  [Required(ErrorMessage = "Password is required")]
  [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
  public string Password { get; set; } = string.Empty;
  //Tên
  [Required(ErrorMessage = "First name is required")]
  [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters")]
  public string FirstName { get; set; } = string.Empty;
  //Họ
  [Required(ErrorMessage = "Last name is required")]
  [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters")]
  public string LastName { get; set; } = string.Empty;
  //Giới tính
  [Required(ErrorMessage = "Gender is required")]
  [EnumDataType(typeof(Gender), ErrorMessage = "Invalid gender")]
  public Gender Gender { get; set; }
  //Ngày sinh
  [Required(ErrorMessage = "Date of birth is required")]
  public DateTime DateOfBirth { get; set; }
  //Địa chỉ
  [Required(ErrorMessage = "Address is required")]
  public string? Address { get; set; }
  //Số điện thoại
  [Required(ErrorMessage = "Phone number is required")]
  public string? PhoneNumber { get; set; }
}