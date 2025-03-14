namespace MedicalAppointmentAPI.Common.Constants;

public static class SystemConstants
{
  public static class Cache
  {
    public const int DefaultExpirationMinutes = 60;
    public const string UserKey = "User_{0}";
    public const string RolesKey = "Roles_{0}";
  }

  public static class Authentication
  {
    public const int RefreshTokenValidityDays = 7;
    public const int AccessTokenValidityMinutes = 60;
  }
  public static class Validation
  {
    public const int MaxNameLength = 100;
    public const int MinPasswordLength = 8;
    public const string PhoneNumberRegex = @"^\+?[1-9]\d{1,14}$";
  }
  public static class Email
  {
    public const string SmtpServer = "smtp.gmail.com";
    public const int SmtpPort = 587;
    public const string SmtpUsername = "lehieunghia2402@gmail.com";
    public const string SmtpPassword = "nguyenvanphuc123";
    public const string FromEmail = "lehieunghia2402@gmail.com";
    public const string FromName = "Medical Appointment System";
    public const bool EnableSsl = true;
  }
   public static class Roles
  {
    public const string SuperAdmin = "SuperAdmin";
    public const string Admin = "Admin";
    public const string Doctor = "Doctor";
    public const string Patient = "Patient";
    public const string Receptionist = "Receptionist";
    public const string Pharmacist = "Pharmacist";

    public static readonly IReadOnlyCollection<string> All = new[]
    {
      SuperAdmin,
      Admin,
      Doctor,
      Patient,
      Receptionist,
      Pharmacist
    };
  }
    public static class Policies 
  {
    public const string RequireSuperAdmin = "RequireSuperAdmin";
    public const string RequireAdmin = "RequireAdmin";
    public const string RequireDoctor = "RequireDoctor";
    public const string RequirePatient = "RequirePatient";
    public const string RequireReceptionist = "RequireReceptionist";
    public const string RequirePharmacist = "RequirePharmacist";
  }   
  

}