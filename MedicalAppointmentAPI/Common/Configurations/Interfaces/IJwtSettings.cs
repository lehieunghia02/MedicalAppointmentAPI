using Microsoft.IdentityModel.Tokens;

namespace Common.Configurations.Interfaces; 

public interface IJwtSettings
{
  string SecretKey { get; }
  string Issuer { get; }
  string Audience { get; }
  int AccessTokenExpirationMinutes { get; }
  int RefreshTokenValidityDays { get; }
  SigningCredentials GetSigningCredentials();
  TokenValidationParameters GetTokenValidationParameters();
}