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
    public class RoomService : IService<Room>
    {

        private readonly RoomRepository _roomRepository;

        public RoomService(RoomRepository rRepo)
        {
            _roomRepository = rRepo;
        }

        public void Add(Room entity)
        {
            RoomValidator rVal = new();
            ValidationResult result = rVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(",", result.Errors));
            }

            _roomRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            //isActive = true olan kategori silinmez.

            var r = _roomRepository.GetByID(id);

            if (r.IsActive)
            {
                throw new Exception("Aktif olan bir oda silinemez");
            }
            _roomRepository.Delete(id);
        }

        public IEnumerable<Room>? GetAll()
        {
            return _roomRepository.GetAll();
        }

        public Room? GetById(Guid id)
        {
            return _roomRepository.GetByID(id);
        }

        public void Update(Room entity)
        {
            if (entity != null)
            {
                _roomRepository.Update(entity);
            }
        }
    }
}
