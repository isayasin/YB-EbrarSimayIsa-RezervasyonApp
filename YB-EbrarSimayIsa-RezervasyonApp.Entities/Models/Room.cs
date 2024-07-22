using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Abstractions;

namespace YB_EbrarSimayIsa_RezervasyonApp.Entities.Models
{
    public class Room : Entity
    {
        public int Hotell {  get; set; }
        public Guid TypeID { get; set; }
        public string? Status { get; set; }
        public Guid RoomTypeId { get; set; }
        public RoomType? RoomType { get; set; }
        public Hotel? Hotel { get; set; }
        public Guid HotelID { get; set; }
    }
}
