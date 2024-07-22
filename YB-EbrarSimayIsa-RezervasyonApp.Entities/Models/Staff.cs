using YB_EbrarSimayIsa_RezervasyonApp.Entities.Abstractions;

namespace YB_EbrarSimayIsa_RezervasyonApp.Entities.Models
{
    public class Staff : Entity
    {
        public Guid HotelID { get; set; }
        public Hotel? Hotel { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public DateTime HireDate { get; set; }

    }

}
