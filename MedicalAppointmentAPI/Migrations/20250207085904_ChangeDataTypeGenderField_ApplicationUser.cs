using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalAppointmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDataTypeGenderField_ApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "430365f2-3597-4c54-9355-1bc1cc410f15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a7ab4e6-6cfc-411b-b0a3-253afd6a1642");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66403eab-c533-4c94-82cd-4858f6c68b55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75fee9bc-b2ef-4109-a84c-2d007eb51318");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad57d966-8473-491b-9779-dd62c42378b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4dd9744-755c-46ad-a349-07be56bee330");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(4493), new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(4496), new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(4498), new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(4499), new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(4501), new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(4502) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "430365f2-3597-4c54-9355-1bc1cc410f15", "ce21096d-7454-42c9-8997-99166fdbbea0", "Patient", "PATIENT" },
                    { "4a7ab4e6-6cfc-411b-b0a3-253afd6a1642", "338a7365-39cd-40bb-b063-dea87f3273db", "Receptionist", "RECEPTIONIST" },
                    { "66403eab-c533-4c94-82cd-4858f6c68b55", "96787274-682b-4830-9bbc-24248340d5ca", "Admin", "ADMIN" },
                    { "75fee9bc-b2ef-4109-a84c-2d007eb51318", "6e93ab24-d88e-46d5-8902-be080fe8bd41", "SuperAdmin", "SUPERADMIN" },
                    { "ad57d966-8473-491b-9779-dd62c42378b3", "f87ede81-d533-4032-a83f-9e1d5e063482", "Pharmacist", "PHARMACIST" },
                    { "c4dd9744-755c-46ad-a349-07be56bee330", "6d46f210-fd3c-4f8e-93ae-cd055259429e", "Doctor", "DOCTOR" }
                });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1750), new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1755), new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1758), new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1760), new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1762), new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1765), new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1767), new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1769), new DateTime(2025, 2, 6, 15, 34, 19, 461, DateTimeKind.Utc).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6508), new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6731), new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6733), new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6735), new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6737), new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6738), new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6740), new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6741), new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6755), new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6756), new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6758), new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6759), new DateTime(2025, 2, 6, 15, 34, 19, 460, DateTimeKind.Utc).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 34, 19, 459, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 34, 19, 459, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 34, 19, 459, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 34, 19, 459, DateTimeKind.Utc).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 34, 19, 459, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 34, 19, 459, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 34, 19, 459, DateTimeKind.Utc).AddTicks(8429));
        }
    }
}
