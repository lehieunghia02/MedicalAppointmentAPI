using MedicalAppointmentAPI.Common.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MedicalAppointmentAPI.Data.Seeding;

public static class RoleSeeder
{
  public static void Seed(ModelBuilder builder)
  {
    builder.Entity<IdentityRole>().HasData(
      new IdentityRole
      {
        Name = Roles.SuperAdmin,
        NormalizedName = Roles.SuperAdmin.ToUpper(),
        ConcurrencyStamp = Guid.NewGuid().ToString()
      },
      new IdentityRole
      {
        Name = Roles.Admin,
        NormalizedName = Roles.Admin.ToUpper(),
        ConcurrencyStamp = Guid.NewGuid().ToString()
      },
      new IdentityRole
      {
        Name = Roles.Doctor,
        NormalizedName = Roles.Doctor.ToUpper(),
        ConcurrencyStamp = Guid.NewGuid().ToString()
      },
      new IdentityRole
      {
        Name = Roles.Patient,
        NormalizedName = Roles.Patient.ToUpper(),
        ConcurrencyStamp = Guid.NewGuid().ToString()
      },
      new IdentityRole
      {
        Name = Roles.Receptionist,
        NormalizedName = Roles.Receptionist.ToUpper(),
        ConcurrencyStamp = Guid.NewGuid().ToString()
      },
      new IdentityRole
      {
        Name = Roles.Pharmacist,
        NormalizedName = Roles.Pharmacist.ToUpper(),
        ConcurrencyStamp = Guid.NewGuid().ToString()
      }
    );
  }
}