using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Abstractions;

namespace YB_EbrarSimayIsa_RezervasyonApp.Entities.Models
{
    public class Hotel : Entity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int Stars { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public ICollection<Staff>? Staffs { get; set; }

    }

}
