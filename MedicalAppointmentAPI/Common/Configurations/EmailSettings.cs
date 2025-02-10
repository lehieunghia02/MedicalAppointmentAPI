using Common.Configurations.Interfaces;

namespace Common.Configurations;
public class EmailSettings : IEmailSettings
{
  private readonly IConfiguration _configuration;
  public EmailSettings(IConfiguration configuration)
  {
    _configuration = configuration;
  }

  public string SmtpServer => _configuration["EmailSettings:SmtpServer"]!;
  public int SmtpPort => Convert.ToInt32(_configuration["EmailSettings:SmtpPort"]);
  public string SmtpUsername => _configuration["EmailSettings:SmtpUsername"]!;
  public string SmtpPassword => _configuration["EmailSettings:SmtpPassword"]!;
  public string FromEmail => _configuration["EmailSettings:FromEmail"]!;
  public string FromName => _configuration["EmailSettings:FromName"]!;
  public bool EnableSsl => Convert.ToBoolean(_configuration["EmailSettings:EnableSsl"]);

}
