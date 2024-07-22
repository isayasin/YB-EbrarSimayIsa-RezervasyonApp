using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.Validators
{
    public class RoomTypeValidator:AbstractValidator<RoomType>
    {
        public RoomTypeValidator()
        {
            RuleFor(r => r.Name)
                .NotEmpty()
                .WithMessage("Oda Tipi bos birakilamaz.");

            RuleFor(r => r.Description).NotEmpty()
                .WithMessage("Aciklama boş bırakılamaz");

            RuleFor(r => r.PricePerNight).NotEmpty()
                .WithMessage("Gecelik ucreti boş bırakılamaz")
                .GreaterThan(0)
                .WithMessage("Gecelik ucreti sifirdan buyuk olmalidir");

            RuleFor(r => r.Capacity).NotEmpty()
                .WithMessage("Kapasite boş bırakılamaz")
                .GreaterThan(0)
                .WithMessage("Kapasite sifirdan buyuk olmalidir");
        }


    }
}
