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
  public int RefreshTokenValidityDays => Convert.ToInt32(_configuration["JwtSettings:RefreshTokenValidityDays"]);

  public SigningCredentials GetSigningCredentials()
  {
    var key = Encoding.ASCII.GetBytes(SecretKey);
    return new SigningCredentials(
        new SymmetricSecurityKey(key),
        SecurityAlgorithms.HmacSha256Signature
    );
  }

  public TokenValidationParameters GetTokenValidationParameters()
  {
    return new TokenValidationParameters
    {
      ValidateIssuer = true,
      ValidateAudience = true,
      ValidateLifetime = true,
      ValidateIssuerSigningKey = true,
      ValidIssuer = Issuer,
      ValidAudience = Audience,
      IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.ASCII.GetBytes(SecretKey)
        ),
      ClockSkew = TimeSpan.Zero
    };
  }
}