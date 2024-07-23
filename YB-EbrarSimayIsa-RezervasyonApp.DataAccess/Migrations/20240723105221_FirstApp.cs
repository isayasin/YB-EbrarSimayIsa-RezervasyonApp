using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
<<<<<<<< HEAD:YB-EbrarSimayIsa-RezervasyonApp.DataAccess/Migrations/20240723135332_hasData.cs
    public partial class hasData : Migration
========
    public partial class FirstApp : Migration
>>>>>>>> 952f533338fe459020c416e7874c7864055e15ad:YB-EbrarSimayIsa-RezervasyonApp.DataAccess/Migrations/20240723105221_FirstApp.cs
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
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingGuest", x => new { x.BookingId, x.GuestId });
                    table.ForeignKey(
                        name: "FK_BookingGuest_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingGuest_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
<<<<<<<< HEAD:YB-EbrarSimayIsa-RezervasyonApp.DataAccess/Migrations/20240723135332_hasData.cs
                table: "Hotels",
                columns: new[] { "ID", "Address", "CheckinTime", "CheckoutTime", "CreateAtDate", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("32cbd178-16b8-4341-876d-9349cb19a068"), "İstanbul-Kadıköy", new TimeOnly(13, 0, 0), new TimeOnly(10, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Movenpick", "555 555 55 55", 5, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e9b6c5db-6992-4c6b-98db-d194ed13ba4b"), "İstanbul-Basaksehir", new TimeOnly(14, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Hilton", "555 555 55 55", 4, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "ID", "Capacity", "CreateAtDate", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("8164ff91-3118-4b1a-977e-32b9731192f8"), 1, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sokak Manzaralı", true, false, "Single", 1000.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cbcbd656-c4cc-4e31-8786-21c4f05ab844"), 2, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orman Manzaralı", true, false, "Double", 2500.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d7cdb2ab-446d-4645-b560-c98b4d42a5b1"), 4, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deniz Manzaralı", true, false, "Suit", 5000.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreateAtDate", "HotelID", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeID", "Status", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("11e2a11d-b98f-42b7-b134-b81c8f60e6a4"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e9b6c5db-6992-4c6b-98db-d194ed13ba4b"), true, false, 102, new Guid("8164ff91-3118-4b1a-977e-32b9731192f8"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3ac0ad23-7dd4-4940-8692-c670d555f0e1"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("32cbd178-16b8-4341-876d-9349cb19a068"), true, false, 101, new Guid("8164ff91-3118-4b1a-977e-32b9731192f8"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("40cc1f6e-85be-4305-a484-8376e1669f5e"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("32cbd178-16b8-4341-876d-9349cb19a068"), true, false, 203, new Guid("cbcbd656-c4cc-4e31-8786-21c4f05ab844"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("51f83d4c-c5ff-4503-b347-b35c17ba91d4"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("32cbd178-16b8-4341-876d-9349cb19a068"), true, false, 202, new Guid("cbcbd656-c4cc-4e31-8786-21c4f05ab844"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5967bf15-dcdf-41ff-928a-0df853c97938"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e9b6c5db-6992-4c6b-98db-d194ed13ba4b"), true, false, 201, new Guid("cbcbd656-c4cc-4e31-8786-21c4f05ab844"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae1f4b27-540a-4cd0-8205-77cdde763c92"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e9b6c5db-6992-4c6b-98db-d194ed13ba4b"), true, false, 301, new Guid("d7cdb2ab-446d-4645-b560-c98b4d42a5b1"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af92d6c4-0e71-4db6-8a0b-6053d6420aa8"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e9b6c5db-6992-4c6b-98db-d194ed13ba4b"), true, false, 101, new Guid("8164ff91-3118-4b1a-977e-32b9731192f8"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de96b2ff-8ab2-4e58-83fa-645aa636e35b"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e9b6c5db-6992-4c6b-98db-d194ed13ba4b"), true, false, 302, new Guid("d7cdb2ab-446d-4645-b560-c98b4d42a5b1"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e17b7dc1-a2dd-47d4-9e06-3c507c039f9b"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e9b6c5db-6992-4c6b-98db-d194ed13ba4b"), true, false, 103, new Guid("8164ff91-3118-4b1a-977e-32b9731192f8"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f65f4b80-3bd9-4171-b03f-142a6df1deba"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("32cbd178-16b8-4341-876d-9349cb19a068"), true, false, 201, new Guid("cbcbd656-c4cc-4e31-8786-21c4f05ab844"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
========
                table: "Guests",
                columns: new[] { "ID", "Address", "CreateAtDate", "DateOfBirth", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "Phone", "UpdateAtDate" },
                values: new object[] { new Guid("ab12e098-6846-4c77-9bfa-ac7c4a8c4190"), "Basaksehir", new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "simay@gmail.com", "Simay", true, false, "Seyman", "5454545454", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "CheckinTime", "CheckoutTime", "CreateAtDate", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAtDate" },
                values: new object[] { new Guid("557b01a7-6d00-4112-a16b-94bb1b587934"), "İstanbul-Basaksehir", new TimeOnly(14, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Hilton", "555 555 55 55", 4, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });
>>>>>>>> 952f533338fe459020c416e7874c7864055e15ad:YB-EbrarSimayIsa-RezervasyonApp.DataAccess/Migrations/20240723105221_FirstApp.cs

            migrationBuilder.CreateIndex(
                name: "IX_BookingGuest_GuestId",
                table: "BookingGuest",
                column: "GuestId");

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
