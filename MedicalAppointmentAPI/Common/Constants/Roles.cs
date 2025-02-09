namespace MedicalAppointmentAPI.Common.Constants
{
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
}