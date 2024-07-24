using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FirstApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    CheckinTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    CheckoutTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerNight = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staffs_Hotels_HotelID",
                        column: x => x.HotelID,
                        principalTable: "Hotels",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    RoomTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_HotelID",
                        column: x => x.HotelID,
                        principalTable: "Hotels",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeID",
                        column: x => x.RoomTypeID,
                        principalTable: "RoomTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckoutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    RoomID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bookings_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Payments_Bookings_BookingID",
                        column: x => x.BookingID,
                        principalTable: "Bookings",
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

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomID",
                table: "Bookings",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_BookingID",
                table: "Payments",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelID",
                table: "Rooms",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeID",
                table: "Rooms",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_HotelID",
                table: "Staffs",
                column: "HotelID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingGuest");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
