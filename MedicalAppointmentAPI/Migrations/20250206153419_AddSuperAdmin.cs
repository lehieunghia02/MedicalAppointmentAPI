using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalAppointmentAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSuperAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06d4b4a3-6030-486f-a225-450eb12909d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "165c7464-5432-4c90-b71f-445886acaa5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "685b1a83-630a-4e6e-ae7f-7894ce5b659f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7889f413-0d50-49c9-97b9-8f9cc9149fb2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78b1eaa5-fe69-4aed-9fd2-bc6703ba4a06");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8905), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8910), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8912), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8913), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8915), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(8915) });

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

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5386), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5393), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5396), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5399), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5402), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5405), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5408), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5410), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(54), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(257), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(260), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(261), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(263), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(265), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(266), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(268), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(270), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(271), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(273), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Specialties",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(274), new DateTime(2025, 2, 6, 15, 9, 58, 770, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "WeekDays",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 6, 15, 9, 58, 769, DateTimeKind.Utc).AddTicks(2293));
        }
    }
}
