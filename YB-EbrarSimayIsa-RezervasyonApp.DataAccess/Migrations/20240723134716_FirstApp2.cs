using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FirstApp2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "ID",
                keyValue: new Guid("ab12e098-6846-4c77-9bfa-ac7c4a8c4190"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: new Guid("557b01a7-6d00-4112-a16b-94bb1b587934"));

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "ID", "Address", "CreateAtDate", "DateOfBirth", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "Phone", "UpdateAtDate" },
                values: new object[] { new Guid("9e2f5dce-507f-4d3b-892f-74c381a2b0e7"), "Basaksehir", new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "simay@gmail.com", "Simay", true, false, "Seyman", "5454545454", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "CheckinTime", "CheckoutTime", "CreateAtDate", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAtDate" },
                values: new object[] { new Guid("456d0d9a-62e9-4c3c-8aee-8cebcbef85bd"), "İstanbul-Basaksehir", new TimeOnly(14, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Hilton", "555 555 55 55", 4, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "ID", "Capacity", "CreateAtDate", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAtDate" },
                values: new object[] { new Guid("ddbe6f88-b0bd-4da8-a2e3-1eef34527c0e"), 4, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, "Buyuk", 2000.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "ID",
                keyValue: new Guid("9e2f5dce-507f-4d3b-892f-74c381a2b0e7"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: new Guid("456d0d9a-62e9-4c3c-8aee-8cebcbef85bd"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "ID",
                keyValue: new Guid("ddbe6f88-b0bd-4da8-a2e3-1eef34527c0e"));

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "ID", "Address", "CreateAtDate", "DateOfBirth", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "Phone", "UpdateAtDate" },
                values: new object[] { new Guid("ab12e098-6846-4c77-9bfa-ac7c4a8c4190"), "Basaksehir", new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "simay@gmail.com", "Simay", true, false, "Seyman", "5454545454", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "CheckinTime", "CheckoutTime", "CreateAtDate", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAtDate" },
                values: new object[] { new Guid("557b01a7-6d00-4112-a16b-94bb1b587934"), "İstanbul-Basaksehir", new TimeOnly(14, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Hilton", "555 555 55 55", 4, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
