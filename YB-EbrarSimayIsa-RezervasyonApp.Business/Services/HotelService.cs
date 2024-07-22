using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Business.Abstractions;
using YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Repositories;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.Services
{
    public class HotelService : IService<Hotel>
    {

        private readonly HotelRepository _hotelRepository;

        public HotelService(HotelRepository hRepo)
        {
            _hotelRepository = hRepo;
        }

        public void Add(Hotel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            //isActive = true olan kategori silinmez.

            var h = _hotelRepository.GetByID(id);

            if (h.IsActive)
            {
                throw new Exception("Aktif olan bir hotel silinemez");
            }
            _hotelRepository.Delete(id);
        }

        public IEnumerable<Hotel>? GetAll()
        {
            return _hotelRepository.GetAll();
        }

        public Hotel? GetById(Guid id)
        {
            return _hotelRepository.GetByID(id);
        }

        public void Update(Hotel entity)
        {
            if (entity != null)
            {
                _hotelRepository.Update(entity);
            }
        }
    }
}
