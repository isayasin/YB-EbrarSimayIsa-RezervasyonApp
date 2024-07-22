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
    public class PaymentService : IService<Payment>
    {

        private readonly PaymentRepository _paymentRepository;

        public PaymentService(PaymentRepository pRepo)
        {
            _paymentRepository = pRepo;
        }

        public void Add(Payment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            //isActive = true olan kategori silinmez.

            var p = _paymentRepository.GetByID(id);

            if (p.IsActive)
            {
                throw new Exception("Aktif olan bir odeme silinemez");
            }
            _paymentRepository.Delete(id);
        }

        public IEnumerable<Payment>? GetAll()
        {
            return _paymentRepository.GetAll();
        }

        public Payment? GetById(Guid id)
        {
            return _paymentRepository.GetByID(id);
        }

        public void Update(Payment entity)
        {
            if (entity != null)
            {
                _paymentRepository.Update(entity);
            }
        }
    }
}
