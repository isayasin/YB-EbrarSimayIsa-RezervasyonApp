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
    public class RoomTypeService : IService<RoomType>
    {


        private readonly RoomTypeRepository _roomTypeRepository;

        public RoomTypeService(RoomTypeRepository rtRepo)
        {
            _roomTypeRepository = rtRepo;
        }

        public void Add(RoomType entity)
        {
            RoomTypeValidator rtVal = new();
            ValidationResult result = rtVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(",", result.Errors));
            }

            _roomTypeRepository.Add(entity);
        }

        public void Delete(Guid id)
        {

            //isActive = true olan kategori silinmez.

            var rt = _roomTypeRepository.GetByID(id);

            if (rt.IsActive)
            {
                throw new Exception("Aktif olan bir oda tipi silinemez");
            }
            _roomTypeRepository.Delete(id);
        }

        public IEnumerable<RoomType>? GetAll()
        {
            return _roomTypeRepository.GetAll();
        }

        public RoomType? GetById(Guid id)
        {
            return _roomTypeRepository.GetByID(id);
        }

        public void Update(RoomType entity)
        {

            if (entity != null)
            {
                _roomTypeRepository.Update(entity);
            }
        }


 

    }
}
