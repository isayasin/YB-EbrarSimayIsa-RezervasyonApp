﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Context;

#nullable disable

namespace YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240722201733_Second3")]
    partial class Second3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookingGuest", b =>
                {
                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GuestId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BookingId", "GuestId");

                    b.HasIndex("GuestId");

                    b.ToTable("BookingGuest");
                });

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
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdateAtDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("RoomID");

                    b.ToTable("Bookings");
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
                            ID = new Guid("41a915fe-2955-44a2-91b5-88828f03a0af"),
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
                        });
                });

            modelBuilder.Entity("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Payment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

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
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdateAtDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("RoomTypes");
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

            modelBuilder.Entity("BookingGuest", b =>
                {
                    b.HasOne("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Booking", null)
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YB_EbrarSimayIsa_RezervasyonApp.Entities.Models.Guest", null)
                        .WithMany()
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.Navigation("Payments");
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
