using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Business.Abstractions;
using YB_EbrarSimayIsa_RezervasyonApp.Business.Validators;
using YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Repositories;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.Services
{
    public class BookingGuestService : IService<BookingGuest>
    {
        private readonly BookingGuestRepository _bookingGuestRepository;

        public BookingGuestService(BookingGuestRepository bRepo)
        {
            _bookingGuestRepository = bRepo;
        }

        public IEnumerable<BookingGuest> GetByBookingId(Guid bookingId)
        {
            return _bookingGuestRepository.GetByBookingId(bookingId);
        }

        public void Add(BookingGuest entity)
        {
            //BookingValidator bVal = new();
            //ValidationResult result = bVal.Validate(entity);

            //if (!result.IsValid)
            //{
            //    throw new Exception(string.Join(",", result.Errors));
            //}

            _bookingGuestRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            //isActive = true olan kategori silinmez.

            var b = _bookingGuestRepository.GetByID(id);

            if (b.IsActive)
            {
                throw new Exception("Aktif olan bir rezervasyon silinemez");
            }
            _bookingGuestRepository.Delete(id);
        }

        public IEnumerable<BookingGuest>? GetAll()
        {
            return _bookingGuestRepository.GetAll();
        }

        public BookingGuest? GetById(Guid id)
        {
            return _bookingGuestRepository.GetByID(id);
        }

        public void Update(BookingGuest entity)
        {
            if (entity != null)
            {
                _bookingGuestRepository.Update(entity);
            }
        }
    }
}
