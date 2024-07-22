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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Simay Conn
            //optionsBuilder.UseSqlServer("Data Source = BPC12\\SQLEXPRESS; Initial Catalog = RezervasyonDb ; Integrated Security = True; Trust Server Certificate = True");

            //ebrar
            //optionsBuilder.UseSqlServer("Data Source = EBRAR; Initial Catalog = RezervasyonDb ; Integrated Security = True; Trust Server Certificate = True");
            //İsa Conn
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = RezervasyonDb ; Integrated Security = True; Trust Server Certificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Hotel>().HasData(
                new
                {
                  //ID = (Guid)"FB211AD4-5C1D-44AB-85E0-0B36F166F134",
                  ID = Guid.NewGuid(),
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




            modelBuilder.Entity<Booking>()
           .HasMany(b => b.Guests)
           .WithMany(g => g.Bookings)
           .UsingEntity<Dictionary<string, object>>(
               "BookingGuest",
               bg => bg.HasOne<Guest>().WithMany().HasForeignKey("GuestId"),
               bg => bg.HasOne<Booking>().WithMany().HasForeignKey("BookingId"));


            modelBuilder.Entity<Guest>().HasData(
           new
           {
               //ID = (Guid)"FB211AD4-5C1D-44AB-85E0-0B36F166F134",
               ID = Guid.NewGuid(),
               FirstName = "Simay",
               LastName = "Seyman",
               DateOfBirth = new DateTime(2020, 6, 22),
               Address = "Basaksehir",
               Phone = "5454545454",
               Email = "simay@gmail.com",
               IsActive = true,
               CreateAtDate = new DateTime(2024, 6, 22),
               UpdateAtDate = new DateTime(2024, 7, 22),
               IsDeleted = false,
           }
           );

        }
    }
}
