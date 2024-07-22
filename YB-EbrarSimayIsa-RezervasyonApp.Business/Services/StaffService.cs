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
    public class StaffService : IService<Staff>
    {
        private readonly StaffRepository _staffRepository;

        public StaffService(StaffRepository staffRep)
        {
            _staffRepository = staffRep;
        }
        public void Add(Staff entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            var stf = _staffRepository.GetByID(id);

            if (stf == null)
            {
                throw new Exception("id null olamaz");
            }
            _staffRepository.Delete(id);
        }

        public IEnumerable<Staff>? GetAll()
        {
            return _staffRepository.GetAll();
        }

        public Staff? GetById(Guid id)
        {
            return _staffRepository.GetByID(id);
        }

        public void Update(Staff entity)
        {
            if (entity != null)
            {
                _staffRepository.Update(entity);
            }
        }
    }
}
