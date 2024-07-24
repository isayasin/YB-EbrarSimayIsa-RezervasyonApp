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
            migrationBuilder.DropTable(
                name: "BookingGuest");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("1243bb32-916c-4330-8b42-b7bc66195826"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("35a01f5c-341b-4c0b-a283-b9c5188cf7a4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("5ab84d5d-d8fa-4d36-abac-39f704f4e1a6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("6a4ad1df-804f-483b-bf2c-dc42885b3434"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("6a6dd757-fc4f-4dd4-96d7-b65ffc49274f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("a5b109ef-26e3-4123-afbe-8490bda69abd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("c57ea100-2f4b-4588-8111-f8f13013aebc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("da70802b-8c44-4c58-a852-dcb727a46f9b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("e5b10ea1-307b-44eb-83c1-1643b42b5652"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("fd8c8595-9a87-4e28-9acd-1223c570651b"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: new Guid("48428640-b04b-4a3e-ac78-3cb26635d5ac"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: new Guid("d940ae51-961a-4f84-abcc-d5285103f943"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "ID",
                keyValue: new Guid("0f049053-e4b6-4b6e-b96f-f4bbacd0c136"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "ID",
                keyValue: new Guid("2c2c20c3-85bc-4d39-a0bc-abd1404b0d4c"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "ID",
                keyValue: new Guid("6288fec2-40b9-4f74-b237-c56d087801c2"));

            migrationBuilder.CreateTable(
                name: "BookingGuests",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuestID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingGuests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BookingGuests_Bookings_BookingID",
                        column: x => x.BookingID,
                        principalTable: "Bookings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingGuests_Guests_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Guests",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "CheckinTime", "CheckoutTime", "CreateAtDate", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("6994d048-8daf-4c9c-9bfa-e9250bccbcc3"), "İstanbul-Kadıköy", new TimeOnly(13, 0, 0), new TimeOnly(10, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Movenpick", "555 555 55 55", 5, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8530793f-1882-4fa6-b754-e1732e788e23"), "İstanbul-Basaksehir", new TimeOnly(14, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Hilton", "555 555 55 55", 4, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "ID", "Capacity", "CreateAtDate", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("5038ce2b-0366-4f8b-9736-5fc825319f6b"), 4, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deniz Manzaralı", true, false, "Suit", 5000.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa05fc35-9fc5-44ce-ac86-13036326beb4"), 1, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sokak Manzaralı", true, false, "Single", 1000.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d174e9dc-ea16-4a99-9bfa-b1cc1193e598"), 2, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orman Manzaralı", true, false, "Double", 2500.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreateAtDate", "HotelID", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeID", "Status", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("23757ab4-d702-4420-ba37-05865ea6f2de"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8530793f-1882-4fa6-b754-e1732e788e23"), true, false, 101, new Guid("aa05fc35-9fc5-44ce-ac86-13036326beb4"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2cc7d73a-0a7d-4165-b1f1-8cdf85c9a3cb"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6994d048-8daf-4c9c-9bfa-e9250bccbcc3"), true, false, 203, new Guid("d174e9dc-ea16-4a99-9bfa-b1cc1193e598"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("313a9845-0507-431b-97e0-57ac241754d4"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8530793f-1882-4fa6-b754-e1732e788e23"), true, false, 302, new Guid("5038ce2b-0366-4f8b-9736-5fc825319f6b"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("461feb56-eb52-456e-aae7-bf8996e69783"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8530793f-1882-4fa6-b754-e1732e788e23"), true, false, 103, new Guid("aa05fc35-9fc5-44ce-ac86-13036326beb4"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63f21dda-af79-4553-a694-86e88f192ad7"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6994d048-8daf-4c9c-9bfa-e9250bccbcc3"), true, false, 202, new Guid("d174e9dc-ea16-4a99-9bfa-b1cc1193e598"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7211effe-20df-4af6-b87c-8ded57fbac32"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8530793f-1882-4fa6-b754-e1732e788e23"), true, false, 301, new Guid("5038ce2b-0366-4f8b-9736-5fc825319f6b"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cfabf860-9b5a-4f7a-855f-15862b1bcec2"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6994d048-8daf-4c9c-9bfa-e9250bccbcc3"), true, false, 101, new Guid("aa05fc35-9fc5-44ce-ac86-13036326beb4"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e31821cd-4b82-4df2-9408-e929011c94fa"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8530793f-1882-4fa6-b754-e1732e788e23"), true, false, 201, new Guid("d174e9dc-ea16-4a99-9bfa-b1cc1193e598"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e521f5e3-6b6a-4c64-ba30-59c53462366d"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8530793f-1882-4fa6-b754-e1732e788e23"), true, false, 102, new Guid("aa05fc35-9fc5-44ce-ac86-13036326beb4"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e7fe41a6-53f6-496f-94c3-7be768fa07f0"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6994d048-8daf-4c9c-9bfa-e9250bccbcc3"), true, false, 201, new Guid("d174e9dc-ea16-4a99-9bfa-b1cc1193e598"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingGuests_BookingID",
                table: "BookingGuests",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingGuests_GuestID",
                table: "BookingGuests",
                column: "GuestID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingGuests");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("23757ab4-d702-4420-ba37-05865ea6f2de"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("2cc7d73a-0a7d-4165-b1f1-8cdf85c9a3cb"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("313a9845-0507-431b-97e0-57ac241754d4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("461feb56-eb52-456e-aae7-bf8996e69783"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("63f21dda-af79-4553-a694-86e88f192ad7"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("7211effe-20df-4af6-b87c-8ded57fbac32"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("cfabf860-9b5a-4f7a-855f-15862b1bcec2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("e31821cd-4b82-4df2-9408-e929011c94fa"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("e521f5e3-6b6a-4c64-ba30-59c53462366d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("e7fe41a6-53f6-496f-94c3-7be768fa07f0"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: new Guid("6994d048-8daf-4c9c-9bfa-e9250bccbcc3"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: new Guid("8530793f-1882-4fa6-b754-e1732e788e23"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "ID",
                keyValue: new Guid("5038ce2b-0366-4f8b-9736-5fc825319f6b"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "ID",
                keyValue: new Guid("aa05fc35-9fc5-44ce-ac86-13036326beb4"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "ID",
                keyValue: new Guid("d174e9dc-ea16-4a99-9bfa-b1cc1193e598"));

            migrationBuilder.CreateTable(
                name: "BookingGuest",
                columns: table => new
                {
                    BookingsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuestsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingGuest", x => new { x.BookingsID, x.GuestsID });
                    table.ForeignKey(
                        name: "FK_BookingGuest_Bookings_BookingsID",
                        column: x => x.BookingsID,
                        principalTable: "Bookings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingGuest_Guests_GuestsID",
                        column: x => x.GuestsID,
                        principalTable: "Guests",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "CheckinTime", "CheckoutTime", "CreateAtDate", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("48428640-b04b-4a3e-ac78-3cb26635d5ac"), "İstanbul-Basaksehir", new TimeOnly(14, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Hilton", "555 555 55 55", 4, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d940ae51-961a-4f84-abcc-d5285103f943"), "İstanbul-Kadıköy", new TimeOnly(13, 0, 0), new TimeOnly(10, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Movenpick", "555 555 55 55", 5, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "ID", "Capacity", "CreateAtDate", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("0f049053-e4b6-4b6e-b96f-f4bbacd0c136"), 1, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sokak Manzaralı", true, false, "Single", 1000.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c2c20c3-85bc-4d39-a0bc-abd1404b0d4c"), 2, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orman Manzaralı", true, false, "Double", 2500.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6288fec2-40b9-4f74-b237-c56d087801c2"), 4, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deniz Manzaralı", true, false, "Suit", 5000.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreateAtDate", "HotelID", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeID", "Status", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("1243bb32-916c-4330-8b42-b7bc66195826"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d940ae51-961a-4f84-abcc-d5285103f943"), true, false, 201, new Guid("2c2c20c3-85bc-4d39-a0bc-abd1404b0d4c"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35a01f5c-341b-4c0b-a283-b9c5188cf7a4"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48428640-b04b-4a3e-ac78-3cb26635d5ac"), true, false, 102, new Guid("0f049053-e4b6-4b6e-b96f-f4bbacd0c136"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ab84d5d-d8fa-4d36-abac-39f704f4e1a6"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d940ae51-961a-4f84-abcc-d5285103f943"), true, false, 101, new Guid("0f049053-e4b6-4b6e-b96f-f4bbacd0c136"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a4ad1df-804f-483b-bf2c-dc42885b3434"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48428640-b04b-4a3e-ac78-3cb26635d5ac"), true, false, 201, new Guid("2c2c20c3-85bc-4d39-a0bc-abd1404b0d4c"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a6dd757-fc4f-4dd4-96d7-b65ffc49274f"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48428640-b04b-4a3e-ac78-3cb26635d5ac"), true, false, 103, new Guid("0f049053-e4b6-4b6e-b96f-f4bbacd0c136"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5b109ef-26e3-4123-afbe-8490bda69abd"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48428640-b04b-4a3e-ac78-3cb26635d5ac"), true, false, 101, new Guid("0f049053-e4b6-4b6e-b96f-f4bbacd0c136"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c57ea100-2f4b-4588-8111-f8f13013aebc"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d940ae51-961a-4f84-abcc-d5285103f943"), true, false, 203, new Guid("2c2c20c3-85bc-4d39-a0bc-abd1404b0d4c"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da70802b-8c44-4c58-a852-dcb727a46f9b"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48428640-b04b-4a3e-ac78-3cb26635d5ac"), true, false, 301, new Guid("6288fec2-40b9-4f74-b237-c56d087801c2"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e5b10ea1-307b-44eb-83c1-1643b42b5652"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48428640-b04b-4a3e-ac78-3cb26635d5ac"), true, false, 302, new Guid("6288fec2-40b9-4f74-b237-c56d087801c2"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fd8c8595-9a87-4e28-9acd-1223c570651b"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d940ae51-961a-4f84-abcc-d5285103f943"), true, false, 202, new Guid("2c2c20c3-85bc-4d39-a0bc-abd1404b0d4c"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingGuest_GuestsID",
                table: "BookingGuest",
                column: "GuestsID");
        }
    }
}
