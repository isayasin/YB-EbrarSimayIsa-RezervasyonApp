using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FirstApp4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "CheckinTime", "CheckoutTime", "CreateAtDate", "Email", "IsActive", "IsDeleted", "Name", "Phone", "Stars", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("4bf3cf5e-150e-4ad1-b589-b1273e7b240f"), "İstanbul-Kadıköy", new TimeOnly(13, 0, 0), new TimeOnly(10, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Movenpick", "555 555 55 55", 5, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e7da1881-fdfd-4156-8dd9-d77d23974be4"), "İstanbul-Basaksehir", new TimeOnly(14, 0, 0), new TimeOnly(11, 0, 0), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "email@gmail.com", true, false, "Hilton", "555 555 55 55", 4, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "ID", "Capacity", "CreateAtDate", "Description", "IsActive", "IsDeleted", "Name", "PricePerNight", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("77a2ad8a-3db2-4b8c-b5e2-05befa1974fc"), 1, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sokak Manzaralı", true, false, "Single", 1000.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9125fca3-e6b9-4073-9130-1340984b01a3"), 2, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orman Manzaralı", true, false, "Double", 2500.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb2a20f5-f11e-4c5c-99a8-271a63a8256d"), 4, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deniz Manzaralı", true, false, "Suit", 5000.0m, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreateAtDate", "HotelID", "IsActive", "IsDeleted", "RoomNumber", "RoomTypeID", "Status", "UpdateAtDate" },
                values: new object[,]
                {
                    { new Guid("13847332-2908-434e-a9bb-e01d859996dc"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7da1881-fdfd-4156-8dd9-d77d23974be4"), true, false, 102, new Guid("77a2ad8a-3db2-4b8c-b5e2-05befa1974fc"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ac48c31-b076-4f51-a13b-6dea669f74e0"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7da1881-fdfd-4156-8dd9-d77d23974be4"), true, false, 201, new Guid("9125fca3-e6b9-4073-9130-1340984b01a3"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83b3f4d0-6db0-4581-832f-b6c4bc7f6acf"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7da1881-fdfd-4156-8dd9-d77d23974be4"), true, false, 302, new Guid("cb2a20f5-f11e-4c5c-99a8-271a63a8256d"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8794468e-5feb-446d-a692-a767c3559b51"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4bf3cf5e-150e-4ad1-b589-b1273e7b240f"), true, false, 201, new Guid("9125fca3-e6b9-4073-9130-1340984b01a3"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ec90b5b-8cb2-4276-8414-15bd6d847307"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7da1881-fdfd-4156-8dd9-d77d23974be4"), true, false, 103, new Guid("77a2ad8a-3db2-4b8c-b5e2-05befa1974fc"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8f81138-9136-47c4-8d52-e590e109451f"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7da1881-fdfd-4156-8dd9-d77d23974be4"), true, false, 301, new Guid("cb2a20f5-f11e-4c5c-99a8-271a63a8256d"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c25f6a86-a642-4d6b-aadb-e3dbb70b0953"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e7da1881-fdfd-4156-8dd9-d77d23974be4"), true, false, 101, new Guid("77a2ad8a-3db2-4b8c-b5e2-05befa1974fc"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c9e86204-1c21-462a-a07d-5aceabee1fd5"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4bf3cf5e-150e-4ad1-b589-b1273e7b240f"), true, false, 202, new Guid("9125fca3-e6b9-4073-9130-1340984b01a3"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ceee4b82-724b-43f5-8f6b-fa794dd8e861"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4bf3cf5e-150e-4ad1-b589-b1273e7b240f"), true, false, 203, new Guid("9125fca3-e6b9-4073-9130-1340984b01a3"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fbacd175-3544-40f4-b517-cad9e5efde96"), new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4bf3cf5e-150e-4ad1-b589-b1273e7b240f"), true, false, 101, new Guid("77a2ad8a-3db2-4b8c-b5e2-05befa1974fc"), "Müsait", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("13847332-2908-434e-a9bb-e01d859996dc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("7ac48c31-b076-4f51-a13b-6dea669f74e0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("83b3f4d0-6db0-4581-832f-b6c4bc7f6acf"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("8794468e-5feb-446d-a692-a767c3559b51"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("9ec90b5b-8cb2-4276-8414-15bd6d847307"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("a8f81138-9136-47c4-8d52-e590e109451f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("c25f6a86-a642-4d6b-aadb-e3dbb70b0953"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("c9e86204-1c21-462a-a07d-5aceabee1fd5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("ceee4b82-724b-43f5-8f6b-fa794dd8e861"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: new Guid("fbacd175-3544-40f4-b517-cad9e5efde96"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: new Guid("4bf3cf5e-150e-4ad1-b589-b1273e7b240f"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: new Guid("e7da1881-fdfd-4156-8dd9-d77d23974be4"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "ID",
                keyValue: new Guid("77a2ad8a-3db2-4b8c-b5e2-05befa1974fc"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "ID",
                keyValue: new Guid("9125fca3-e6b9-4073-9130-1340984b01a3"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "ID",
                keyValue: new Guid("cb2a20f5-f11e-4c5c-99a8-271a63a8256d"));

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
        }
    }
}
