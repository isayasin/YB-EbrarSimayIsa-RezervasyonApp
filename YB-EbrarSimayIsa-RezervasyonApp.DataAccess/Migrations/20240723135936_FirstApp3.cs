using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FirstApp3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingGuest_Bookings_BookingId",
                table: "BookingGuest");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingGuest_Guests_GuestId",
                table: "BookingGuest");

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

            migrationBuilder.AddColumn<int>(
                name: "RoomNumber",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "CheckinTime", "CheckoutTime", "CreateAtDate", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("428cb6a9-8c9b-45ac-87e1-4eb29ccd4aef"), "İstanbul-Kadıköy", new TimeOnly(13, 0, 0), new TimeOnly(10, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Movenpick", "555 555 55 55", 5, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ecb6103-bf7a-4628-8f8d-d718231f86ea"), "İstanbul-Basaksehir", new TimeOnly(14, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Hilton", "555 555 55 55", 4, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "ID", "Capacity", "CreateAtDate", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("079f6abc-d134-4bee-a71f-bddf40632fdd"), 1, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sokak Manzaralı", true, false, "Single", 1000.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8937db83-ea5f-425f-b0cd-8dc22d49b8a9"), 4, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deniz Manzaralı", true, false, "Suit", 5000.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8cdb96d7-f189-494e-a001-659adaaaea07"), 2, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orman Manzaralı", true, false, "Double", 2500.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreateAtDate", "HotelID", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeID", "Status", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("01b3fd8a-2f34-4e8a-967f-2f9d1439ee64"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("428cb6a9-8c9b-45ac-87e1-4eb29ccd4aef"), true, false, 201, new Guid("8cdb96d7-f189-494e-a001-659adaaaea07"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1709a9d2-b39a-41d1-86ac-476b0eb61931"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9ecb6103-bf7a-4628-8f8d-d718231f86ea"), true, false, 301, new Guid("8937db83-ea5f-425f-b0cd-8dc22d49b8a9"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("470cf542-3e5b-4c9d-bda6-ead8853d39ad"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("428cb6a9-8c9b-45ac-87e1-4eb29ccd4aef"), true, false, 101, new Guid("079f6abc-d134-4bee-a71f-bddf40632fdd"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("480c0d14-1513-428a-804d-0e4b4b8b3efd"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9ecb6103-bf7a-4628-8f8d-d718231f86ea"), true, false, 302, new Guid("8937db83-ea5f-425f-b0cd-8dc22d49b8a9"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f0abf3d-6763-4a1c-84de-7977dbf4234f"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9ecb6103-bf7a-4628-8f8d-d718231f86ea"), true, false, 103, new Guid("079f6abc-d134-4bee-a71f-bddf40632fdd"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c66a1d7-2ff8-4699-bdbf-66dcc67ae6db"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9ecb6103-bf7a-4628-8f8d-d718231f86ea"), true, false, 102, new Guid("079f6abc-d134-4bee-a71f-bddf40632fdd"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1f07f52-18bb-4803-addb-f97274381fdc"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9ecb6103-bf7a-4628-8f8d-d718231f86ea"), true, false, 201, new Guid("8cdb96d7-f189-494e-a001-659adaaaea07"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c6c457ab-5f28-405b-9c67-0c620a2fb2d6"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9ecb6103-bf7a-4628-8f8d-d718231f86ea"), true, false, 101, new Guid("079f6abc-d134-4bee-a71f-bddf40632fdd"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d2038cf3-6704-4f16-9aaa-fefbfb4ff3db"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("428cb6a9-8c9b-45ac-87e1-4eb29ccd4aef"), true, false, 203, new Guid("8cdb96d7-f189-494e-a001-659adaaaea07"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e2174a84-f057-4238-8a1c-f5611e4ee3a1"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("428cb6a9-8c9b-45ac-87e1-4eb29ccd4aef"), true, false, 202, new Guid("8cdb96d7-f189-494e-a001-659adaaaea07"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingGuest_Bookings_BookingsID",
                table: "BookingGuest");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingGuest_Guests_GuestsID",
                table: "BookingGuest");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("01b3fd8a-2f34-4e8a-967f-2f9d1439ee64"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("1709a9d2-b39a-41d1-86ac-476b0eb61931"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("470cf542-3e5b-4c9d-bda6-ead8853d39ad"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("480c0d14-1513-428a-804d-0e4b4b8b3efd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("4f0abf3d-6763-4a1c-84de-7977dbf4234f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("7c66a1d7-2ff8-4699-bdbf-66dcc67ae6db"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("b1f07f52-18bb-4803-addb-f97274381fdc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("c6c457ab-5f28-405b-9c67-0c620a2fb2d6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("d2038cf3-6704-4f16-9aaa-fefbfb4ff3db"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("e2174a84-f057-4238-8a1c-f5611e4ee3a1"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: new Guid("428cb6a9-8c9b-45ac-87e1-4eb29ccd4aef"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: new Guid("9ecb6103-bf7a-4628-8f8d-d718231f86ea"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "ID",
                keyValue: new Guid("079f6abc-d134-4bee-a71f-bddf40632fdd"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "ID",
                keyValue: new Guid("8937db83-ea5f-425f-b0cd-8dc22d49b8a9"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "ID",
                keyValue: new Guid("8cdb96d7-f189-494e-a001-659adaaaea07"));

            migrationBuilder.DropColumn(
                name: "RoomNumber",
                table: "Rooms");

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
    }
}
