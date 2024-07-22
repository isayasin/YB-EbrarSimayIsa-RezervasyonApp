using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.Validators
{
    public class HotelValidator : AbstractValidator<Hotel>
    {
        public HotelValidator()
        {
            RuleFor(h => h.Name).NotEmpty()
                .WithMessage("Hotel adı boş bırakılamaz");
            RuleFor(h => h.Address).NotEmpty()
                .WithMessage("Hotel adresi boş bırakılamaz");
            RuleFor(h => h.Phone).NotEmpty()
                .WithMessage("Telefon boş bırakılamaz");
            RuleFor(h => h.Email).NotEmpty()
                .WithMessage("Email Adresi boş bırakılamaz");
            RuleFor(h => h.Stars).NotEmpty()
                .WithMessage("Yildiz boş bırakılamaz");
            RuleFor(h => h.CheckinTime).NotEmpty()
                .WithMessage("Giris Saati boş bırakılamaz");
            RuleFor(h => h.CheckoutTime).NotEmpty()
           .WithMessage("Cikis Saati boş bırakılamaz");

        }
    }
}
