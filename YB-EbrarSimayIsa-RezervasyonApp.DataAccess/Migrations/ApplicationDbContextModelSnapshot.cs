﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Context;

#nullable disable

namespace YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Booking", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckinDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckoutDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateAtDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("RoomID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("UpdateAtDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("RoomID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.BookingGuest", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookingID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAtDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GuestID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateAtDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("BookingID");

                    b.HasIndex("GuestID");

                    b.ToTable("BookingGuests");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Guest", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAtDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateAtDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Hotel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("CheckinTime")
                        .HasColumnType("time");

                    b.Property<TimeOnly>("CheckoutTime")
                        .HasColumnType("time");

                    b.Property<DateTime>("CreateAtDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateAtDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            ID = new Guid("a087b118-8876-425c-b82e-475bd555dabf"),
                            Address = "İstanbul-Basaksehir",
                            CheckinTime = new TimeOnly(14, 0, 0),
                            CheckoutTime = new TimeOnly(11, 0, 0),
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "email@gmail.com",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Hilton",
                            Phone = "555 555 55 55",
                            Stars = 4,
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("56c450b1-4862-42cd-a806-df6c802a4d72"),
                            Address = "İstanbul-Kadıköy",
                            CheckinTime = new TimeOnly(13, 0, 0),
                            CheckoutTime = new TimeOnly(10, 0, 0),
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "email@gmail.com",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Movenpick",
                            Phone = "555 555 55 55",
                            Stars = 5,
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Payment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<Guid>("BookingID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAtDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateAtDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("BookingID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Room", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAtDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HotelID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("RoomTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateAtDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("HotelID");

                    b.HasIndex("RoomTypeID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            ID = new Guid("d2c74e02-bced-4fc3-8975-6ae4d3994f4e"),
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelID = new Guid("a087b118-8876-425c-b82e-475bd555dabf"),
                            IsActive = true,
                            IsDeleted = false,
                            RoomNumber = 101,
                            RoomTypeID = new Guid("2059c1bc-f583-407e-801c-6d1cf0cb15a4"),
                            Status = "Müsait",
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("158d3d8f-ed74-4ac6-87f8-90d6572db49d"),
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelID = new Guid("a087b118-8876-425c-b82e-475bd555dabf"),
                            IsActive = true,
                            IsDeleted = false,
                            RoomNumber = 102,
                            RoomTypeID = new Guid("2059c1bc-f583-407e-801c-6d1cf0cb15a4"),
                            Status = "Müsait",
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("67689404-4b18-4e60-bed8-a98dc3ad0da6"),
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelID = new Guid("a087b118-8876-425c-b82e-475bd555dabf"),
                            IsActive = true,
                            IsDeleted = false,
                            RoomNumber = 103,
                            RoomTypeID = new Guid("2059c1bc-f583-407e-801c-6d1cf0cb15a4"),
                            Status = "Müsait",
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("dd7e9f9b-9a6e-45fb-a293-e3d3b8efc76c"),
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelID = new Guid("a087b118-8876-425c-b82e-475bd555dabf"),
                            IsActive = true,
                            IsDeleted = false,
                            RoomNumber = 201,
                            RoomTypeID = new Guid("cd503069-f72c-47e0-9145-f8b9befd1dda"),
                            Status = "Müsait",
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("ac9de000-1722-464d-9b2f-a68a974c003c"),
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelID = new Guid("a087b118-8876-425c-b82e-475bd555dabf"),
                            IsActive = true,
                            IsDeleted = false,
                            RoomNumber = 301,
                            RoomTypeID = new Guid("89811bb8-a6d9-425e-bac6-774f88c51d1e"),
                            Status = "Müsait",
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("7481b6fc-c2dd-483e-9109-91e6845a5fd0"),
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelID = new Guid("a087b118-8876-425c-b82e-475bd555dabf"),
                            IsActive = true,
                            IsDeleted = false,
                            RoomNumber = 302,
                            RoomTypeID = new Guid("89811bb8-a6d9-425e-bac6-774f88c51d1e"),
                            Status = "Müsait",
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("4242f3dc-a1c9-4ad4-a436-46aa6dd734bb"),
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelID = new Guid("56c450b1-4862-42cd-a806-df6c802a4d72"),
                            IsActive = true,
                            IsDeleted = false,
                            RoomNumber = 101,
                            RoomTypeID = new Guid("2059c1bc-f583-407e-801c-6d1cf0cb15a4"),
                            Status = "Müsait",
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("a0d7d14f-076a-4e82-bcc8-871dff6c1600"),
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelID = new Guid("56c450b1-4862-42cd-a806-df6c802a4d72"),
                            IsActive = true,
                            IsDeleted = false,
                            RoomNumber = 201,
                            RoomTypeID = new Guid("cd503069-f72c-47e0-9145-f8b9befd1dda"),
                            Status = "Müsait",
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("02a1f191-3fa4-4d39-b87e-b6194e3c5462"),
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelID = new Guid("56c450b1-4862-42cd-a806-df6c802a4d72"),
                            IsActive = true,
                            IsDeleted = false,
                            RoomNumber = 202,
                            RoomTypeID = new Guid("cd503069-f72c-47e0-9145-f8b9befd1dda"),
                            Status = "Müsait",
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("2754945b-6110-4f14-a4f0-909fe7767658"),
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HotelID = new Guid("56c450b1-4862-42cd-a806-df6c802a4d72"),
                            IsActive = true,
                            IsDeleted = false,
                            RoomNumber = 203,
                            RoomTypeID = new Guid("cd503069-f72c-47e0-9145-f8b9befd1dda"),
                            Status = "Müsait",
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.RoomType", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAtDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("UpdateAtDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("RoomTypes");

                    b.HasData(
                        new
                        {
                            ID = new Guid("2059c1bc-f583-407e-801c-6d1cf0cb15a4"),
                            Capacity = 1,
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sokak Manzaralı",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Single",
                            PricePerNight = 1000.0m,
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("cd503069-f72c-47e0-9145-f8b9befd1dda"),
                            Capacity = 2,
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Orman Manzaralı",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Double",
                            PricePerNight = 2500.0m,
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = new Guid("89811bb8-a6d9-425e-bac6-774f88c51d1e"),
                            Capacity = 4,
                            CreateAtDate = new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Deniz Manzaralı",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Suit",
                            PricePerNight = 5000.0m,
                            UpdateAtDate = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Staff", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateAtDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HotelID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdateAtDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("HotelID");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Booking", b =>
                {
                    b.HasOne("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.BookingGuest", b =>
                {
                    b.HasOne("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Booking", "Booking")
                        .WithMany("BookingGuests")
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Guest", "Guest")
                        .WithMany("BookingGuests")
                        .HasForeignKey("GuestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Guest");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Payment", b =>
                {
                    b.HasOne("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Booking", "Booking")
                        .WithMany("Payments")
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Room", b =>
                {
                    b.HasOne("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Staff", b =>
                {
                    b.HasOne("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Hotel", "Hotel")
                        .WithMany("Staffs")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Booking", b =>
                {
                    b.Navigation("BookingGuests");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Guest", b =>
                {
                    b.Navigation("BookingGuests");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Hotel", b =>
                {
                    b.Navigation("Rooms");

                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Room", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
