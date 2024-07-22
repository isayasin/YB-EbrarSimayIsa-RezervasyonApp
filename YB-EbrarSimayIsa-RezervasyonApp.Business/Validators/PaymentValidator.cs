using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.Validators
{
    public class PaymentValidator:AbstractValidator<Payment>
    {

        public PaymentValidator()
        {
            RuleFor(p => p.Amount)
                .GreaterThan(0)
                .WithMessage("Odeme miktari sifirdan buyuk olmalidir");

            RuleFor(p => p.PaymentDate).NotEmpty()
                .WithMessage("Odeme tarihi boş bırakılamaz");

            RuleFor(p => p.PaymentMethod).NotEmpty()
                .WithMessage("Odeme metodu boş bırakılamaz");
            

        }


    }
}
