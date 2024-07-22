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
    public class BookingService : IService<Booking>
    {

        private readonly BookingRepository _bookingRepository;

        public BookingService(BookingRepository bRepo)
        {
            _bookingRepository = bRepo;
        }

        public void Add(Booking entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            //isActive = true olan kategori silinmez.

            var b = _bookingRepository.GetByID(id);

            if (b.IsActive)
            {
                throw new Exception("Aktif olan bir rezervasyon silinemez");
            }
            _bookingRepository.Delete(id);

        }

        public IEnumerable<Booking>? GetAll()
        {
            return _bookingRepository.GetAll();
        }

        public Booking? GetById(Guid id)
        {
            return _bookingRepository.GetByID(id);
        }

        public void Update(Booking entity)
        {
            if (entity != null)
            {
                _bookingRepository.Update(entity);
            }
        }
    }
}
