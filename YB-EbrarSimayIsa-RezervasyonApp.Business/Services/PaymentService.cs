using FluentValidation.Results;
using YB_EbrarSimayIsa_RezervasyonApp.Business.Abstractions;
using YB_EbrarSimayIsa_RezervasyonApp.Business.Validators;
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
            PaymentValidator pVal = new();
            ValidationResult result = pVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join(",", result.Errors));
            }

            _paymentRepository.Add(entity);

   
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
