using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalAppointmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79f2f034-2c79-4856-a566-eb1f9faa5dfd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97f653ee-024b-41fb-b39f-a0871450f5e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba3341cc-6d13-49f2-9161-586d68d88d14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1f61ac0-04bf-464e-bf5f-11ceb5940913");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d92077e9-d815-4d9f-8840-69ec301b1e3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0be4ada-9590-4c14-84f0-5d9083fe6b21");

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(4117), new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(4122), new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(4123), new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(4126), new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(4127), new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(4128) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16e22e88-bc85-4e8a-9c42-a09ada88570b", "6ba1fe7a-091e-4fce-8e64-0d932c5c631e", "Admin", "ADMIN" },
                    { "1fa6ca62-93d8-4558-9fa8-e9a26d066245", "55f3a470-77fd-4d6b-a684-65bd17eb0ccb", "Receptionist", "RECEPTIONIST" },
                    { "32d9817d-74e3-46e6-ab1a-d6eb4e65ac7a", "8983c31d-2ed6-4abd-83c7-1b6cf06e9358", "Doctor", "DOCTOR" },
                    { "4cf2bc64-1246-4ec9-ae03-34f4d4d64ca0", "cfa326f9-6298-4ffe-8927-9d08fcacefb0", "Patient", "PATIENT" },
                    { "ab554b02-70f7-46ef-8d59-fb3a722da8ac", "53e4a574-b1d5-4b38-91a2-c90eeab7f600", "Pharmacist", "PHARMACIST" },
                    { "fad4dc9e-70a4-4b02-b315-42cef1e9fc3f", "dcf98472-9ef5-4426-88ee-2ab1a334bbb9", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(128), new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(137), new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(140), new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(143), new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(145), new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(148), new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(150), new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(153), new DateTime(2025, 2, 15, 6, 28, 43, 817, DateTimeKind.Utc).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2148), new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2568), new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2571), new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2573), new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2575), new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2578), new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2580), new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2582), new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2584), new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2586), new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2588), new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2590), new DateTime(2025, 2, 15, 6, 28, 43, 816, DateTimeKind.Utc).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 15, 6, 28, 43, 815, DateTimeKind.Utc).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 15, 6, 28, 43, 815, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 15, 6, 28, 43, 815, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 15, 6, 28, 43, 815, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 15, 6, 28, 43, 815, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 15, 6, 28, 43, 815, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 15, 6, 28, 43, 815, DateTimeKind.Utc).AddTicks(2133));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16e22e88-bc85-4e8a-9c42-a09ada88570b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fa6ca62-93d8-4558-9fa8-e9a26d066245");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32d9817d-74e3-46e6-ab1a-d6eb4e65ac7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cf2bc64-1246-4ec9-ae03-34f4d4d64ca0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab554b02-70f7-46ef-8d59-fb3a722da8ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fad4dc9e-70a4-4b02-b315-42cef1e9fc3f");

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(7978), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(7991), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(7993), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(7995), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(7996), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(7997) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "79f2f034-2c79-4856-a566-eb1f9faa5dfd", "507610d3-3791-4576-a7d7-57984749f2c9", "Receptionist", "RECEPTIONIST" },
                    { "97f653ee-024b-41fb-b39f-a0871450f5e8", "b0a8548d-d84d-4381-bb66-566f051a5b73", "Admin", "ADMIN" },
                    { "ba3341cc-6d13-49f2-9161-586d68d88d14", "45dd810e-4289-4f4b-9872-ef84f1732d37", "Doctor", "DOCTOR" },
                    { "c1f61ac0-04bf-464e-bf5f-11ceb5940913", "e3c3f61d-f4fb-40a6-aa37-2ca77764b7c7", "SuperAdmin", "SUPERADMIN" },
                    { "d92077e9-d815-4d9f-8840-69ec301b1e3d", "3f26f033-a840-482f-a92a-0c1ab133fa74", "Pharmacist", "PHARMACIST" },
                    { "e0be4ada-9590-4c14-84f0-5d9083fe6b21", "95362b76-e217-4e29-8506-9a89d68b1675", "Patient", "PATIENT" }
                });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5317), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5322), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5326), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5329), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5331), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5334), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5337), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5340), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(416), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(627), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(629), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(631), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(632), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(634), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(636), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(638), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(639), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(641), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(642), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(644), new DateTime(2025, 2, 9, 16, 53, 19, 611, DateTimeKind.Utc).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 53, 19, 610, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 53, 19, 610, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 53, 19, 610, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 53, 19, 610, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 53, 19, 610, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 53, 19, 610, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 9, 16, 53, 19, 610, DateTimeKind.Utc).AddTicks(2959));
        }
    }
}
