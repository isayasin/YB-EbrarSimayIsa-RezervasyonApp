using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Abstractions;

namespace YB_EbrarSimayIsa_RezervasyonApp.Entities.Models
{
    public class RoomType: Entity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal PricePerNight {  get; set; }
        public int Capacity {  get; set; }
        public ICollection<Room>? Rooms { get; set; }
    }
}
