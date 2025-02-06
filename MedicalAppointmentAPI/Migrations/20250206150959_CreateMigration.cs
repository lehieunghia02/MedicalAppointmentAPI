using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalAppointmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeekDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ViName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsWeekend = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allergies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChronicDiseases = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InsuranceProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ClinicId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specialties_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Qualifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialtyId = table.Column<int>(type: "int", nullable: false),
                    ClinicId = table.Column<int>(type: "int", nullable: false),
                    YearsOfExperience = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctors_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctors_Specialties_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalTable: "Specialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoctorSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    WeekDayId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    MaxAppointments = table.Column<int>(type: "int", nullable: false),
                    AverageConsultingTime = table.Column<int>(type: "int", nullable: false),
                    BreakTime = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSchedules", x => x.Id);
                    table.CheckConstraint("CK_DoctorSchedule_TimeRange", "StartTime < EndTime");
                    table.ForeignKey(
                        name: "FK_DoctorSchedules_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorSchedules_WeekDays_WeekDayId",
                        column: x => x.WeekDayId,
                        principalTable: "WeekDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppointmentStatusId = table.Column<int>(type: "int", nullable: false),
                    Symptoms = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DoctorScheduleId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AppointmentStatuses_AppointmentStatusId",
                        column: x => x.AppointmentStatusId,
                        principalTable: "AppointmentStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_DoctorSchedules_DoctorScheduleId",
                        column: x => x.DoctorScheduleId,
                        principalTable: "DoctorSchedules",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symptoms = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Treatment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Prescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestResults = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ConsultationFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsFollowUpRequired = table.Column<bool>(type: "bit", nullable: false),
                    FollowUpDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalRecordId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    PrescriptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    GeneralInstructions = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsProcessed = table.Column<bool>(type: "bit", nullable: false),
                    ProcessedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescriptions_MedicalRecords_MedicalRecordId",
                        column: x => x.MedicalRecordId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrescriptionId = table.Column<int>(type: "int", nullable: false),
                    MedicineName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Dosage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Frequency = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Usage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    SpecialInstructions = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrescriptionDetails_Prescriptions_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AppointmentStatuses",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8905), "Trạng thái đã đặt lịch", true, "Đã đặt lịch", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8905) },
                    { 2, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8910), "Trạng thái đã được xác nhận", true, "Đã xác nhận", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8910) },
                    { 3, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8912), "Trạng thái đã hoàn thành", true, "Đã hoàn thành", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8912) },
                    { 4, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8913), "Trạng thái đã hủy bỏ", true, "Hủy bỏ", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8914) },
                    { 5, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8915), "Trạng thái không đúng hẹn", true, "Không đúng hẹn", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8915) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06d4b4a3-6030-486f-a225-450eb12909d0", "9b0c99ec-d695-44d0-b9d8-a3f0780bbe67", "Doctor", "DOCTOR" },
                    { "165c7464-5432-4c90-b71f-445886acaa5d", "bdb5d28e-b9e1-46c0-916f-f0ce9bf03e92", "Receptionist", "RECEPTIONIST" },
                    { "685b1a83-630a-4e6e-ae7f-7894ce5b659f", "fde74035-5647-4aae-9a80-3005c13a2f34", "Patient", "PATIENT" },
                    { "7889f413-0d50-49c9-97b9-8f9cc9149fb2", "95cdea81-c549-4af3-b089-7c0088042576", "Admin", "ADMIN" },
                    { "78b1eaa5-fe69-4aed-9fd2-bc6703ba4a06", "2a7477ea-c89b-4c29-943f-3673f769a4d3", "Pharmacist", "PHARMACIST" }
                });

            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "Email", "ImageUrl", "IsActive", "Name", "OpeningHours", "Phone", "UpdatedAt", "Website" },
                values: new object[,]
                {
                    { 1, "123 Nguyễn Văn Linh, Quận 7, TP.HCM", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5386), "Phòng khám đa khoa với đội ngũ bác sĩ chuyên môn cao và trang thiết bị hiện đại", "contact@qte-clinic.com", "https://example.com/images/clinic1.jpg", true, "Phòng Khám Đa Khoa Quốc Tế", "7:00 - 20:00", "028.7123.4567", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5387), "https://qte-clinic.com" },
                    { 2, "456 Lê Văn Việt, Quận 9, TP.HCM", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5393), "Chuyên khoa sản phụ khoa với các dịch vụ chăm sóc toàn diện cho phụ nữ", "info@hanhphuc-clinic.com", "https://example.com/images/clinic2.jpg", true, "Phòng Khám Sản Phụ Khoa Hạnh Phúc", "7:30 - 19:30", "028.7234.5678", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5394), "https://hanhphuc-clinic.com" },
                    { 3, "789 Phan Văn Trị, Quận Gò Vấp, TP.HCM", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5396), "Phòng khám chuyên khoa nhi với môi trường thân thiện cho trẻ em", "care@kids-clinic.com", "https://example.com/images/clinic3.jpg", true, "Phòng Khám Nhi Thiên Thần Nhỏ", "7:00 - 19:00", "028.7345.6789", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5397), "https://kids-clinic.com" },
                    { 4, "321 Võ Văn Ngân, TP.Thủ Đức, TP.HCM", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5399), "Chuyên khoa tim mạch với các trang thiết bị chẩn đoán hiện đại", "info@tamduc-cardio.com", "https://example.com/images/clinic4.jpg", true, "Phòng Khám Tim Mạch Tâm Đức", "8:00 - 17:00", "028.7456.7890", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5400), "https://tamduc-cardio.com" },
                    { 5, "147 Điện Biên Phủ, Quận Bình Thạnh, TP.HCM", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5402), "Chuyên khoa mắt với các dịch vụ khám và điều trị về mắt", "care@anhsang-eye.com", "https://example.com/images/clinic5.jpg", true, "Phòng Khám Mắt Ánh Sáng", "7:30 - 17:00", "028.7567.8901", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5403), "https://anhsang-eye.com" },
                    { 6, "258 Cao Thắng, Quận 3, TP.HCM", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5405), "Chăm sóc răng miệng toàn diện với công nghệ nha khoa tiên tiến", "info@nucuoi-dental.com", "https://example.com/images/clinic6.jpg", true, "Phòng Khám Răng Hàm Mặt Nụ Cười", "8:00 - 20:00", "028.7678.9012", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5405), "https://nucuoi-dental.com" },
                    { 7, "369 Nguyễn Thị Minh Khai, Quận 1, TP.HCM", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5408), "Phòng khám đa khoa với đầy đủ các chuyên khoa", "contact@suckhoe-clinic.com", "https://example.com/images/clinic7.jpg", true, "Phòng Khám Đa Khoa Sức Khỏe", "7:00 - 21:00", "028.7789.0123", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5408), "https://suckhoe-clinic.com" },
                    { 8, "486 Lê Quang Định, Quận Bình Thạnh, TP.HCM", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5410), "Chuyên điều trị các bệnh lý về cơ xương khớp", "info@vandong-clinic.com", "https://example.com/images/clinic8.jpg", true, "Phòng Khám Cơ Xương Khớp Vận Động", "8:00 - 17:30", "028.7890.1234", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5411), "https://vandong-clinic.com" }
                });

            migrationBuilder.InsertData(
                table: "Specialties",
                columns: new[] { "Id", "ClinicId", "CreatedAt", "Description", "ImageUrl", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(54), "Khám và điều trị các bệnh lý nội khoa tổng quát", null, true, "Nội Tổng Quát", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(55) },
                    { 2, null, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(257), "Chẩn đoán và điều trị các bệnh về tim mạch", null, true, "Tim Mạch", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(258) },
                    { 3, null, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(260), "Khám và điều trị các bệnh về hệ thần kinh", null, true, "Thần Kinh", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(260) },
                    { 4, null, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(261), "Chăm sóc sức khỏe trẻ em từ sơ sinh đến 15 tuổi", null, true, "Nhi Khoa", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(262) },
                    { 5, null, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(263), "Chăm sóc sức khỏe phụ nữ và thai sản", null, true, "Sản Phụ Khoa", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(263) },
                    { 6, null, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(265), "Khám và điều trị các bệnh về tai, mũi, họng", null, true, "Tai Mũi Họng", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(265) },
                    { 7, null, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(266), "Khám và điều trị các bệnh về mắt", null, true, "Mắt", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(267) },
                    { 8, null, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(268), "Khám và điều trị các bệnh về da", null, true, "Da Liễu", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(268) },
                    { 9, null, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(270), "Khám và điều trị các bệnh về xương khớp", null, true, "Cơ Xương Khớp", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(270) },
                    { 10, null, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(271), "Khám và điều trị các bệnh về đường tiêu hóa", null, true, "Tiêu Hóa", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(272) },
                    { 11, null, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(273), "Khám và điều trị các bệnh về đường hô hấp", null, true, "Hô Hấp", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(273) },
                    { 12, null, new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(274), "Khám và điều trị các bệnh về nội tiết, đái tháo đường", null, true, "Nội Tiết", new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(275) }
                });

            migrationBuilder.InsertData(
                table: "WeekDays",
                columns: new[] { "Id", "CreatedAt", "IsActive", "IsWeekend", "Name", "ShortName", "UpdatedAt", "ViName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2192), true, false, "Monday", "Mon", null, "Thứ Hai" },
                    { 2, new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2286), true, false, "Tuesday", "Tue", null, "Thứ Ba" },
                    { 3, new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2288), true, false, "Wednesday", "Wed", null, "Thứ Tư" },
                    { 4, new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2289), true, false, "Thursday", "Thu", null, "Thứ Năm" },
                    { 5, new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2291), true, false, "Friday", "Fri", null, "Thứ Sáu" },
                    { 6, new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2292), true, true, "Saturday", "Sat", null, "Thứ Bảy" },
                    { 7, new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2293), true, true, "Sunday", "Sun", null, "Chủ Nhật" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_AppointmentDate",
                table: "Appointments",
                column: "AppointmentDate");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_AppointmentStatusId",
                table: "Appointments",
                column: "AppointmentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorScheduleId",
                table: "Appointments",
                column: "DoctorScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RefreshToken",
                table: "AspNetUsers",
                column: "RefreshToken",
                unique: true,
                filter: "[RefreshToken] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_ClinicId",
                table: "Doctors",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_LicenseNumber",
                table: "Doctors",
                column: "LicenseNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_SpecialtyId",
                table: "Doctors",
                column: "SpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSchedules_DoctorId_WeekDayId_StartTime_EndTime",
                table: "DoctorSchedules",
                columns: new[] { "DoctorId", "WeekDayId", "StartTime", "EndTime" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSchedules_WeekDayId",
                table: "DoctorSchedules",
                column: "WeekDayId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_AppointmentId",
                table: "MedicalRecords",
                column: "AppointmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_DoctorId",
                table: "MedicalRecords",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_PatientId",
                table: "MedicalRecords",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_InsuranceNumber",
                table: "Patients",
                column: "InsuranceNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserId",
                table: "Patients",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionDetails_PrescriptionId",
                table: "PrescriptionDetails",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_DoctorId",
                table: "Prescriptions",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_MedicalRecordId",
                table: "Prescriptions",
                column: "MedicalRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescriptions",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_ClinicId",
                table: "Specialties",
                column: "ClinicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PrescriptionDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AppointmentStatuses");

            migrationBuilder.DropTable(
                name: "DoctorSchedules");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "WeekDays");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DropTable(
                name: "Clinics");
        }
    }
}
