using MedicalAppointmentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalAppointmentAPI.Data;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
  {
  }

  public DbSet<ApplicationUser> Users { get; set; }
  // public DbSet<Doctor> Doctors { get; set; }
  // public DbSet<Patient> Patients { get; set; }
  // public DbSet<Appointment> Appointments { get; set; }
  protected override void OnModelCreating(ModelBuilder builder)
  {
    base.OnModelCreating(builder);
    //Configure ApplicationUser 
    builder.Entity<ApplicationUser>(entity =>
    {
      entity.Property(e => e.FirstName).HasMaxLength(50);
      entity.Property(e => e.LastName).HasMaxLength(100);
      entity.Property(e => e.Address).HasMaxLength(255);

      //Indexes for UserName and Email 
      entity.HasIndex(e => e.UserName).IsUnique();
      entity.HasIndex(e => e.RefreshToken).IsUnique();
    });
  }
}