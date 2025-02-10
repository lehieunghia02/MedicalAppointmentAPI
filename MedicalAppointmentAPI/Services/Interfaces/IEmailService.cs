namespace Services.Interfaces;

public interface IEmailService
{
  Task SendEmailAsync(string to, string subject, string body, bool isHtml = false);
  Task SendEmailConfirmationAsync(string to, string confirmationLink);
  Task SendPasswordResetAsync(string email, string resetLink);
}