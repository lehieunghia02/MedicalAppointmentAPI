using Common.Configurations.Interfaces;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using MailKit.Security;
using MedicalAppointmentAPI.Services.Interfaces;

namespace MedicalAppointmentAPI.Services.Implementations;

public class EmailService : IEmailService
{
  private readonly IEmailSettings _emailSettings;
  private readonly ILogger<EmailService> _logger;

  public EmailService(IEmailSettings emailSettings, ILogger<EmailService> logger)
  {
    _emailSettings = emailSettings;
    _logger = logger;
  }

  public async Task SendEmailAsync(string to, string subject, string body, bool isHtml = true)
  {
    try
    {
      var message = new MimeMessage();
      message.From.Add(new MailboxAddress(_emailSettings.FromName, _emailSettings.FromEmail));
      message.To.Add(MailboxAddress.Parse(to));
      message.Subject = subject;

      message.Body = new TextPart(isHtml ? TextFormat.Html : TextFormat.Plain)
      {
        Text = body
      };

      using var client = new SmtpClient();
      await client.ConnectAsync(
        _emailSettings.SmtpServer,
        _emailSettings.SmtpPort,
        SecureSocketOptions.StartTls
      );
      await client.AuthenticateAsync(_emailSettings.SmtpUsername, _emailSettings.SmtpPassword);
      await client.SendAsync(message);
      await client.DisconnectAsync(true);

      _logger.LogInformation("Email sent successfully to {Email}", to);
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Failed to send email to {Email}. Error: {Error}", to, ex.Message);
      throw new Exception($"Failed to send email: {ex.Message}", ex);
    }
  }

  public async Task SendEmailConfirmationAsync(string email, string confirmationLink)
  {
    var subject = "Xác nhận email của bạn";
    var body = $@"
            <h2>Xin chào!</h2>
            <p>Vui lòng xác nhận email của bạn bằng cách nhấp vào liên kết dưới đây:</p>
            <p><a href='{confirmationLink}'>Xác nhận email</a></p>
            <p>Nếu bạn không yêu cầu xác nhận này, vui lòng bỏ qua email này.</p>
            <p>Trân trọng,<br>Medical Appointment Team</p>";

    await SendEmailAsync(email, subject, body);
  }

  public async Task SendPasswordResetAsync(string email, string resetLink)
  {
    var subject = "Đặt lại mật khẩu";
    var body = $@"
            <h2>Xin chào!</h2>
            <p>Bạn đã yêu cầu đặt lại mật khẩu. Vui lòng nhấp vào liên kết dưới đây để đặt lại mật khẩu của bạn:</p>
            <p><a href='{resetLink}'>Đặt lại mật khẩu</a></p>
            <p>Nếu bạn không yêu cầu đặt lại mật khẩu, vui lòng bỏ qua email này.</p>
            <p>Trân trọng,<br>Medical Appointment Team</p>";

    await SendEmailAsync(email, subject, body);
  }
}