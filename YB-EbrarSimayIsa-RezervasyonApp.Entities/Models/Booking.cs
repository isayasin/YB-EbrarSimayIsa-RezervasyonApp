using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Abstractions;

namespace YB_EbrarSimayIsa_RezervasyonApp.Entities.Models
{
    public class Booking : Entity
    {
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<Payment>? Payments { get; set; }
        public virtual ICollection<Guest>? Guests { get; set; }
        public Room? Room { get; set; }
        public Guid? RoomID { get; set; }
    }
}
