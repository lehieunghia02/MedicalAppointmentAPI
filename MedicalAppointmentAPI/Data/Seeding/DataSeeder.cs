using Data.Seeding;
using Microsoft.EntityFrameworkCore;

namespace MedicalAppointmentAPI.Data.Seeding;

public class DataSeeder
{
  public static void Seed(ModelBuilder builder)
  {
    WeekDaySeeder.Seed(builder);
    SpecialtySeeder.Seed(builder);
    ClinicSeeder.Seed(builder);
    AppointmentStatusSeeder.Seed(builder);
    RoleSeeder.Seed(builder);
  }
}