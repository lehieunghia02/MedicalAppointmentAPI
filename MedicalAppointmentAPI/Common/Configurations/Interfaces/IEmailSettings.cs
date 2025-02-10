namespace Common.Configurations.Interfaces;
public interface IEmailSettings
{
  string SmtpServer { get; }
  int SmtpPort { get; }
  string SmtpUsername { get; }
  string SmtpPassword { get; }
  string FromEmail { get; }
  string FromName { get; }
  bool EnableSsl { get; }
}
