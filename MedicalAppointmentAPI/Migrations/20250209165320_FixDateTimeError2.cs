using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalAppointmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixDateTimeError2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetUsers",
                type: "datetime2(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "datetime2(0)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(0)");

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
    }
}
