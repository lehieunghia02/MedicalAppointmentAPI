namespace MedicalAppointmentAPI.DTOs.Auth;

public class AuthResponse
{
  public TokenInfo Tokens { get; set; }
  public UserInfo User { get; set; }
  //Token Info
  public class TokenInfo
  {
    public string AccessToken { get; set; } = string.Empty;
    public string RefreshToken { get; set; } = string.Empty;
    public DateTime ExpiresIn { get; set; } = DateTime.Now;
    public string TokenType { get; set; } = "Bearer";
  }
  //User Info
  public class UserInfo
  {
    public string Id { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string AvatarUrl { get; set; } = string.Empty;
    public List<string> Roles { get; set; } = new List<string>();
    public Dictionary<string, List<string>> Permissions { get; set; } = new Dictionary<string, List<string>>();
  }

}