using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.Abstractions
{
    public interface IRoomTypeService : IService<RoomType>
    {
        IEnumerable<RoomType> GetRoomTypesByHotelId(Guid hotelId);
    }
}
