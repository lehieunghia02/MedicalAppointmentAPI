namespace MedicalAppointmentAPI.Common.Constants
{
  public static class Roles
  {
    public const string Admin = "Admin";
    public const string Doctor = "Doctor";
    public const string Patient = "Patient";
    public const string Staff = "Staff";

    public static readonly IReadOnlyCollection<string> All = new[]
    {
            Admin,
            Doctor,
            Patient,
            Staff
    };
  }
}