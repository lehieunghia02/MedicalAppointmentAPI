using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalAppointmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixDateTimeError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "061996df-dc07-41a4-9fc0-36248b2b016b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1be3f53b-7289-4f57-a724-a9a80c456210");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f14bd1d-95ab-400f-bc34-d5b62ac12a8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5995a8ac-556a-4f11-a732-4bd62b80b3fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9827d9c7-87d3-4eda-ac7c-8f496a2cdc42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a83918b6-6778-4b6c-8e5c-64f78730a48f");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "WeekDays",
                type: "datetime2(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeekDays",
                type: "datetime2(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Specialties",
                type: "datetime2(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Specialties",
                type: "datetime2(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Prescriptions",
                type: "datetime2(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Prescriptions",
                type: "datetime2(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "PrescriptionDetails",
                type: "datetime2(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrescriptionDetails",
                type: "datetime2(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Patients",
                type: "datetime2(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Patients",
                type: "datetime2(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "MedicalRecords",
                type: "datetime2(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MedicalRecords",
                type: "datetime2(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "DoctorSchedules",
                type: "datetime2(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DoctorSchedules",
                type: "datetime2(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Doctors",
                type: "datetime2(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Doctors",
                type: "datetime2(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Clinics",
                type: "datetime2(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clinics",
                type: "datetime2(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AppointmentStatuses",
                type: "datetime2(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppointmentStatuses",
                type: "datetime2(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Appointments",
                type: "datetime2(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Appointments",
                type: "datetime2(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(7015), new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(7019), new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(7021), new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(7023), new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(7025), new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ecf4410-5d89-4b3e-a048-baf507596017", "847e6bfb-6f1e-47af-9304-31bb7a7be57c", "Receptionist", "RECEPTIONIST" },
                    { "5f0756f1-7a03-44cc-93ad-362b0d0fce9e", "7f4653d9-d487-4088-b81c-e88e625778fc", "Doctor", "DOCTOR" },
                    { "6569067f-fd55-4f60-a0b3-224cff57aace", "4ad352c6-e3aa-444a-a322-e9266423ad9a", "Pharmacist", "PHARMACIST" },
                    { "a6871ba8-864f-43b2-96ca-b6ad9d7ce560", "96a976dc-02e7-4be3-b2da-b9ef58915a78", "Patient", "PATIENT" },
                    { "c433ca8b-6078-45b2-ab20-086a42d60b77", "d8d24dac-25ec-4a84-b31a-e2a423b189ce", "Admin", "ADMIN" },
                    { "e78eac4e-4a50-44ac-8bfe-216fd4ae022a", "01f518ed-359c-49b4-97ab-5e44b5de1870", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4458), new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4463), new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4466), new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4468), new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4470), new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4473), new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4475), new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4477), new DateTime(2025, 2, 9, 16, 49, 5, 881, DateTimeKind.Utc).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9544), new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9743), new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9745), new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9747), new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9748), new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9750), new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9752), new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9753), new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9755), new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9756), new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9758), new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9759), new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 49, 5, 880, DateTimeKind.Utc).AddTicks(2169));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ecf4410-5d89-4b3e-a048-baf507596017");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f0756f1-7a03-44cc-93ad-362b0d0fce9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6569067f-fd55-4f60-a0b3-224cff57aace");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6871ba8-864f-43b2-96ca-b6ad9d7ce560");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c433ca8b-6078-45b2-ab20-086a42d60b77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e78eac4e-4a50-44ac-8bfe-216fd4ae022a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "WeekDays",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WeekDays",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Specialties",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Specialties",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Prescriptions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Prescriptions",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "PrescriptionDetails",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PrescriptionDetails",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Patients",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Patients",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "MedicalRecords",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MedicalRecords",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "DoctorSchedules",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DoctorSchedules",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Doctors",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Clinics",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clinics",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AppointmentStatuses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppointmentStatuses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Appointments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)");

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(7253), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(7258), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(7260), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(7261), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(7263), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(7263) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "061996df-dc07-41a4-9fc0-36248b2b016b", "16b483cf-27ac-40a2-a81f-6e089d6462b4", "Pharmacist", "PHARMACIST" },
                    { "1be3f53b-7289-4f57-a724-a9a80c456210", "25ff92ff-7e24-490e-8dd9-4ee8e20a573c", "Doctor", "DOCTOR" },
                    { "1f14bd1d-95ab-400f-bc34-d5b62ac12a8d", "da4b479e-9c89-4bec-aa5e-9317d9c92528", "SuperAdmin", "SUPERADMIN" },
                    { "5995a8ac-556a-4f11-a732-4bd62b80b3fb", "5e620bfc-0811-4021-a32b-150f485ac285", "Receptionist", "RECEPTIONIST" },
                    { "9827d9c7-87d3-4eda-ac7c-8f496a2cdc42", "1fd2d5d3-f85e-4a1c-9a81-21fd83662840", "Patient", "PATIENT" },
                    { "a83918b6-6778-4b6c-8e5c-64f78730a48f", "1cb4f1d7-2239-4e73-98af-d3e11a275a20", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4676), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4681), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4684), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4686), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4688), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4691), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4693), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4695), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9754), new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9986), new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9989), new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9991), new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9992), new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9994), new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9995), new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9997), new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9998), new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(2), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(3), new DateTime(2025, 2, 7, 8, 59, 2, 635, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 7, 8, 59, 2, 634, DateTimeKind.Utc).AddTicks(1738));
        }
    }
}
