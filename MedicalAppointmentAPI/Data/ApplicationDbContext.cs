using MedicalAppointmentAPI.Data.Seeding;
using MedicalAppointmentAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace MedicalAppointmentAPI.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    #region DbSet
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<DoctorSchedule> DoctorSchedules { get; set; }
    public DbSet<MedicalRecord> MedicalRecords { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<PrescriptionDetail> PrescriptionDetails { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<Clinic> Clinics { get; set; }
    public DbSet<AppointmentStatus> AppointmentStatuses { get; set; }
    public DbSet<WeekDay> WeekDays { get; set; }
    #endregion
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //Cấu hình ApplicationUser 
        builder.Entity<ApplicationUser>(entity =>
        {
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Address).HasMaxLength(255);

            //Indexes for UserName and Email 
            entity.HasIndex(e => e.UserName).IsUnique();
            entity.HasIndex(e => e.RefreshToken).IsUnique();
        });
        // Configure Doctor relationships
        builder.Entity<Doctor>(entity =>
        {
            entity.HasIndex(d => d.LicenseNumber).IsUnique();
            entity.HasOne(d => d.User)
                .WithOne(u => u.Doctor)
                .HasForeignKey<Doctor>(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Specialty)
                .WithMany(s => s.Doctors)
                .HasForeignKey(d => d.SpecialtyId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.Clinic)
                .WithMany(c => c.Doctors)
                .HasForeignKey(d => d.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relationship với DoctorSchedule
            entity.HasMany(d => d.Schedules)
                        .WithOne(ds => ds.Doctor)
                        .HasForeignKey(ds => ds.DoctorId)
                        .OnDelete(DeleteBehavior.Restrict);
        });
        // Configure Patient relationships
        builder.Entity<Patient>(entity =>
        {
            entity.HasIndex(p => p.InsuranceNumber); // đánh index cho số bảo hiểm
            entity.HasOne(p => p.User)
                .WithOne(u => u.Patient)
                .HasForeignKey<Patient>(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        });
        // Configure Appointment relationships
        builder.Entity<Appointment>(entity =>
        {
            entity.HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
            entity.HasIndex(a => a.AppointmentDate); //đánh Index cho ngày hẹn
            entity.HasOne(a => a.AppointmentStatus)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.AppointmentStatusId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(a => a.Patient)
            .WithMany(p => p.Appointments)
            .HasForeignKey(a => a.PatientId)
            .OnDelete(DeleteBehavior.Restrict);
        });
        // Configure MedicalRecord relationships
        builder.Entity<MedicalRecord>(entity =>
        {
            entity.HasOne(mr => mr.Patient)
                    .WithMany(p => p.MedicalRecords)
                    .HasForeignKey(mr => mr.PatientId)
                    .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(mr => mr.Doctor)
                .WithMany()
                .HasForeignKey(mr => mr.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(mr => mr.Appointment)
                .WithOne()
                .HasForeignKey<MedicalRecord>(mr => mr.AppointmentId)
                .OnDelete(DeleteBehavior.Restrict);
        });
        // Configure Prescription relationships
        builder.Entity<Prescription>(entity =>
        {
            entity.HasOne(p => p.MedicalRecord)
                .WithMany()
                .HasForeignKey(p => p.MedicalRecordId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(p => p.Doctor)
                .WithMany()
                .HasForeignKey(p => p.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(p => p.Patient)
                .WithMany()
                .HasForeignKey(p => p.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(p => p.Details)
                .WithOne(pd => pd.Prescription)
                .HasForeignKey(pd => pd.PrescriptionId)
                .OnDelete(DeleteBehavior.Restrict);
        });
        //Configure DoctorSchedule
        builder.Entity<DoctorSchedule>(entity =>
        {
            // Không cần cấu hình relationship với Doctor ở đây
            // vì đã cấu hình ở Doctor entity

            // Unique constraint cho lịch làm việc
            entity.HasIndex(ds => new { ds.DoctorId, ds.WeekDayId, ds.StartTime, ds.EndTime })
                        .IsUnique();

            entity.ToTable(tb => tb.HasCheckConstraint(
                       "CK_DoctorSchedule_TimeRange",
                       "StartTime < EndTime"
                   ));

            // Relationship với WeekDay
            entity.HasOne(ds => ds.WeekDay)
                        .WithMany(w => w.DoctorSchedules)
                        .HasForeignKey(ds => ds.WeekDayId)
                        .OnDelete(DeleteBehavior.Restrict);
        });
        // Configure decimal properties
        builder.Entity<MedicalRecord>()
            .Property(mr => mr.ConsultationFee)
            .HasColumnType("decimal(18,2)");
        // Configure PrescriptionDetail relationships
        builder.Entity<PrescriptionDetail>(entity =>
        {
            entity.HasOne(pd => pd.Prescription)
          .WithMany(p => p.Details)
          .HasForeignKey(pd => pd.PrescriptionId)
            .OnDelete(DeleteBehavior.Restrict);

            entity.Property(pd => pd.UnitPrice)
                .HasColumnType("decimal(18,2)");

            entity.Property(pd => pd.TotalAmount)
                .HasColumnType("decimal(18,2)");
        });
        DataSeeder.Seed(builder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        // Suppress the warning about pending model changes
        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
    }
}