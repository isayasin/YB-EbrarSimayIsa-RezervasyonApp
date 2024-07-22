using YB_EbrarSimayIsa_RezervasyonApp.Entities.Abstractions;

namespace YB_EbrarSimayIsa_RezervasyonApp.Entities.Models
{
    public class Guest : Entity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public virtual ICollection<Booking>? Bookings { get; set; }
    }
}