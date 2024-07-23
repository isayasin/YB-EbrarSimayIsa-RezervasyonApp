using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.IService
{
    public interface IRoomTypeService : IGenericService<RoomType>
    {
        public List<RoomType> GetAllByHotel(Guid id);
    }
}
