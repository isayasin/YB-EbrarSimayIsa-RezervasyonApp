using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Abstractions;

namespace YB_EbrarSimayIsa_RezervasyonApp.Entities.Models
{
    public class BookingGuest : Entity
    {
        public Guid BookingID { get; set; }
        public Booking? Booking { get; set; }
        public Guid GuestID { get; set; }
        public Guest? Guest { get; set; }
    }
}
