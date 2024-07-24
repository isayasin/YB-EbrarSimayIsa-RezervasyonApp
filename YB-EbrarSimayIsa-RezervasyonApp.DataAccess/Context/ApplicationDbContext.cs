using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<BookingGuest> BookingGuests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Simay Conn
            //optionsBuilder.UseSqlServer("Data Source = BPC12\\SQLEXPRESS; Initial Catalog = RezervasyonDb ; Integrated Security = True; Trust Server Certificate = True");

            //ebrar
            //optionsBuilder.UseSqlServer("Data Source = EBRAR; Initial Catalog = RezervasyonDb ; Integrated Security = True; Trust Server Certificate = True");

            //Course Ebrar
            //optionsBuilder.UseSqlServer("Data Source=BPC10\\SQLEXPRESS;Initial Catalog=RezervasyonDb;Integrated Security=True;Trust Server Certificate=True;");

            //İsa Conn
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = RezervasyonDb ; Integrated Security = True; Trust Server Certificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Booking entity configuration
            modelBuilder.Entity<Booking>()
                .Property(b => b.TotalPrice)
                .HasColumnType("decimal(10,2)"); 

            // Payment entity configuration
            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(10,2)");

            // RoomType entity configuration
            modelBuilder.Entity<RoomType>()
                .Property(r => r.PricePerNight)
                .HasColumnType("decimal(10,2)");

            var hotelId = Guid.NewGuid();
            var hotel2Id = Guid.NewGuid();
            var roomTypeId = Guid.NewGuid();
            var roomTypeId2 = Guid.NewGuid();
            var roomTypeId3 = Guid.NewGuid();
            //var hotelId = "722A5201 - 2C86 - 466A - B15F - D7E0D4408FDE";
            

            modelBuilder.Entity<Hotel>().HasData(
                new
                {
                    ID = hotelId,
                    Name = "Hilton",
                    Address = "İstanbul-Basaksehir",
                    Phone = "555 555 55 55",
                    Email = "email@gmail.com",
                    Stars = 4,
                    CheckinTime = new TimeOnly(14, 0),
                    CheckoutTime = new TimeOnly(11, 0),
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new
                {
                    ID = hotel2Id,
                    Name = "Movenpick",
                    Address = "İstanbul-Kadıköy",
                    Phone = "555 555 55 55",
                    Email = "email@gmail.com",
                    Stars = 5,
                    CheckinTime = new TimeOnly(13, 0),
                    CheckoutTime = new TimeOnly(10, 0),
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );

            modelBuilder.Entity<Room>().HasData(
                new
                {
                    ID = Guid.NewGuid(),
                    Status = "Müsait",
                    RoomNumber = 101,
                    HotelID = hotelId,
                    RoomTypeID = roomTypeId,
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );
            modelBuilder.Entity<Room>().HasData(
                new
                {
                    ID = Guid.NewGuid(),
                    Status = "Müsait",
                    RoomNumber = 102,
                    HotelID = hotelId,
                    RoomTypeID = roomTypeId,
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );
            modelBuilder.Entity<Room>().HasData(
                new
                {
                    ID = Guid.NewGuid(),
                    Status = "Müsait",
                    RoomNumber = 103,
                    HotelID = hotelId,
                    RoomTypeID = roomTypeId,
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );
            modelBuilder.Entity<Room>().HasData(
                new
                {
                    ID = Guid.NewGuid(),
                    Status = "Müsait",
                    RoomNumber = 201,
                    HotelID = hotelId,
                    RoomTypeID = roomTypeId2,
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );
            modelBuilder.Entity<Room>().HasData(
                new
                {
                    ID = Guid.NewGuid(),
                    Status = "Müsait",
                    RoomNumber = 301,
                    HotelID = hotelId,
                    RoomTypeID = roomTypeId3,
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );
            modelBuilder.Entity<Room>().HasData(
                new
                {
                    ID = Guid.NewGuid(),
                    Status = "Müsait",
                    RoomNumber = 302,
                    HotelID = hotelId,
                    RoomTypeID = roomTypeId3,
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );
            modelBuilder.Entity<Room>().HasData(
                new
                {
                    ID = Guid.NewGuid(),
                    Status = "Müsait",
                    RoomNumber = 101,
                    HotelID = hotel2Id,
                    RoomTypeID = roomTypeId,
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );
            modelBuilder.Entity<Room>().HasData(
                new
                {
                    ID = Guid.NewGuid(),
                    Status = "Müsait",
                    RoomNumber = 201,
                    HotelID = hotel2Id,
                    RoomTypeID = roomTypeId2,
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );
            modelBuilder.Entity<Room>().HasData(
                new
                {
                    ID = Guid.NewGuid(),
                    Status = "Müsait",
                    RoomNumber = 202,
                    HotelID = hotel2Id,
                    RoomTypeID = roomTypeId2,
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );
            modelBuilder.Entity<Room>().HasData(
                new
                {
                    ID = Guid.NewGuid(),
                    Status = "Müsait",
                    RoomNumber = 203,
                    HotelID = hotel2Id,
                    RoomTypeID = roomTypeId2,
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );
            modelBuilder.Entity<RoomType>().HasData(
                new
                {
                    ID = roomTypeId,
                    Name = "Single",
                    Description = "Sokak Manzaralı",
                    Capacity = 1,
                    PricePerNight = 1000.0m,
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );
            modelBuilder.Entity<RoomType>().HasData(
                new
                {
                    ID = roomTypeId2,
                    Name = "Double",
                    Description = "Orman Manzaralı",
                    Capacity = 2,
                    PricePerNight = 2500.0m,
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );
            modelBuilder.Entity<RoomType>().HasData(
                new
                {
                    ID = roomTypeId3,
                    Name = "Suit",
                    Description = "Deniz Manzaralı",
                    Capacity = 4,
                    PricePerNight = 5000.0m,
                    CreateAtDate = new DateTime(2024, 6, 22),
                    UpdateAtDate = new DateTime(2024, 7, 22),
                    IsActive = true,
                    IsDeleted = false,
                }
                );

            base.OnModelCreating(modelBuilder);

        }
    }
}
