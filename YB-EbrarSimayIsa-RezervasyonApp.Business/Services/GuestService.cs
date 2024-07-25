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
    public class GuestService : IService<Guest>
    {

        private readonly GuestRepository _guestRepository;

        public GuestService(GuestRepository gRepo)
        {
            _guestRepository = gRepo;
        }

        public bool Exists(Guid id)
        {
            return _guestRepository.Exists(id);
        }

        public void Add(Guest entity)
        {
            GuestValidator gVal = new();
            ValidationResult result = gVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(",", result.Errors));
            }

            _guestRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var g = _guestRepository.GetByID(id);

            if (g.IsActive)
            {
                throw new Exception("Aktif olan bir misafir silinemez");
            }
            _guestRepository.Delete(id);
        }

        public IEnumerable<Guest>? GetAll()
        {
            return _guestRepository.GetAll();
        }

        public Guest? GetById(Guid id)
        {
            return _guestRepository.GetByID(id);
        }

        public void Update(Guest entity)
        {
            if (entity != null)
            {
                _guestRepository.Update(entity);
            }
        }
    }
}
