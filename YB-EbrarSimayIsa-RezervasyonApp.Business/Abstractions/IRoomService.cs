using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.Abstractions
{
    public interface IRoomService : IService<Room>
    {
        IEnumerable<Room> GetRoomsByHotelId(Guid hotelId);
        IEnumerable<Room> GetRoomsByHotelAndRoomType(Guid hotelId, Guid roomTypeId);
    }
}
