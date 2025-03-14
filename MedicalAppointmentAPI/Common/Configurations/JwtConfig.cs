using System.Text;
using Common.Configurations.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace MedicalAppointmentAPI.Common.Configurations;

public class JwtConfig : IJwtSettings
{
  private readonly IConfiguration _configuration;
  public JwtConfig(IConfiguration configuration)
  {
    _configuration = configuration;
  }
  public string SecretKey => _configuration["JwtSettings:SecretKey"]!;
  public string Issuer => _configuration["JwtSettings:Issuer"]!;
  public string Audience => _configuration["JwtSettings:Audience"]!;
  public int AccessTokenExpirationMinutes => Convert.ToInt32(_configuration["JwtSettings:AccessTokenExpirationMinutes"]);
  public int RefreshTokenValidityDays => Convert.ToInt32(_configuration["JwtSettings:RefreshTokenExpirationMinutes"]) / (60 * 24); // Convert minutes to days

  public SigningCredentials GetSigningCredentials()
  {
    var key = Encoding.UTF8.GetBytes(SecretKey);
    return new SigningCredentials(
        new SymmetricSecurityKey(key),
        SecurityAlgorithms.HmacSha256Signature
    );
  }

  public TokenValidationParameters GetTokenValidationParameters()
  {
    return new TokenValidationParameters
    {
      ValidateIssuer = false,
      ValidateAudience = false,
      ValidateLifetime = true,
      ValidateIssuerSigningKey = true,
      IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(SecretKey)
        ),
      ClockSkew = TimeSpan.Zero,
      RequireSignedTokens = true,
      RequireExpirationTime = true
    };
  }
}