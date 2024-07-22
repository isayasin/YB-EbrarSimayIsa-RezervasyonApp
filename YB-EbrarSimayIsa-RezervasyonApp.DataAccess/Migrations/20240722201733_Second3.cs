using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Second3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingGuest_Bookings_BookingsID",
                table: "BookingGuest");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingGuest_Guests_GuestsID",
                table: "BookingGuest");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: new Guid("722a5201-2c86-466a-b15f-d7e0d4408fde"));

            migrationBuilder.RenameColumn(
                name: "ISActive",
                table: "Staffs",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ISActive",
                table: "RoomTypes",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ISActive",
                table: "Rooms",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ISActive",
                table: "Payments",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ISActive",
                table: "Hotels",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ISActive",
                table: "Guests",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ISActive",
                table: "Bookings",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "GuestsID",
                table: "BookingGuest",
                newName: "GuestId");

            migrationBuilder.RenameColumn(
                name: "BookingsID",
                table: "BookingGuest",
                newName: "BookingId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingGuest_GuestsID",
                table: "BookingGuest",
                newName: "IX_BookingGuest_GuestId");

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "CheckinTime", "CheckoutTime", "CreateAtDate", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAtDate" },
                values: new object[] { new Guid("41a915fe-2955-44a2-91b5-88828f03a0af"), "İstanbul-Basaksehir", new TimeOnly(14, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Hilton", "555 555 55 55", 4, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_BookingGuest_Bookings_BookingId",
                table: "BookingGuest",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingGuest_Guests_GuestId",
                table: "BookingGuest",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingGuest_Bookings_BookingId",
                table: "BookingGuest");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingGuest_Guests_GuestId",
                table: "BookingGuest");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: new Guid("41a915fe-2955-44a2-91b5-88828f03a0af"));

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Staffs",
                newName: "ISActive");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "RoomTypes",
                newName: "ISActive");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Rooms",
                newName: "ISActive");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Payments",
                newName: "ISActive");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Hotels",
                newName: "ISActive");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Guests",
                newName: "ISActive");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Bookings",
                newName: "ISActive");

            migrationBuilder.RenameColumn(
                name: "GuestId",
                table: "BookingGuest",
                newName: "GuestsID");

            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "BookingGuest",
                newName: "BookingsID");

            migrationBuilder.RenameIndex(
                name: "IX_BookingGuest_GuestId",
                table: "BookingGuest",
                newName: "IX_BookingGuest_GuestsID");

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "CheckinTime", "CheckoutTime", "CreateAtDate", "Email", "ISActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAtDate" },
                values: new object[] { new Guid("722a5201-2c86-466a-b15f-d7e0d4408fde"), "İstanbul-Basaksehir", new TimeOnly(14, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Hilton", "555 555 55 55", 4, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_BookingGuest_Bookings_BookingsID",
                table: "BookingGuest",
                column: "BookingsID",
                principalTable: "Bookings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingGuest_Guests_GuestsID",
                table: "BookingGuest",
                column: "GuestsID",
                principalTable: "Guests",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
