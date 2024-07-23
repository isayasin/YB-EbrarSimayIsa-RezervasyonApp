﻿using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Business.Abstractions;
using YB_EbrarSimayIsa_RezervasyonApp.Business.IService;
using YB_EbrarSimayIsa_RezervasyonApp.Business.Validators;
using YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Repositories;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.Services
{
    public class RoomTypeService : IRoomTypeService
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

        public void Delete(RoomType entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoomType>? GetAll()
        {
            return _roomTypeRepository.GetAll();
        }

        public List<RoomType> GetAllByHotel(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<RoomType> GetAllQueryable()
        {
            throw new NotImplementedException();
        }

        public RoomType? GetById(Guid id)
        {
            return _roomTypeRepository.GetByID(id);
        }

        public RoomType GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(RoomType entity)
        {

            if (entity != null)
            {
                _roomTypeRepository.Update(entity);
            }
        }

        List<RoomType> IGenericService<RoomType>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
