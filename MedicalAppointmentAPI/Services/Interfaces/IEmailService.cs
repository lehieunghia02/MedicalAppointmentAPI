namespace MedicalAppointmentAPI.Services.Interfaces;

public interface IEmailService
{
  Task SendEmailAsync(string to, string subject, string body, bool isHtml = true);
  Task SendEmailConfirmationAsync(string email, string confirmationLink);
  Task SendPasswordResetAsync(string email, string resetLink);
}