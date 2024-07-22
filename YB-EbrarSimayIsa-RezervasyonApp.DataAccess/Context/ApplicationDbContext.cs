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
            optionsBuilder.UseSqlServer("Data Source = BPC12\\SQLEXPRESS; Initial Catalog = RezervasyonDb ; Integrated Security = True; Trust Server Certificate = True");

            //ebrar
            optionsBuilder.UseSqlServer("Data Source = EBRAR; Initial Catalog = RezervasyonDb ; Integrated Security = True; Trust Server Certificate = True");
            //İsa Conn
            //optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = RezervasyonDb ; Integrated Security = True; Trust Server Certificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
