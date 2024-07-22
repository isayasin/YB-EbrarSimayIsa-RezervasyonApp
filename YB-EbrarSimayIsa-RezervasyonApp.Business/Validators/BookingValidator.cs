using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.Validators
{
    public class BookingValidator : AbstractValidator<Booking>
    {
        public BookingValidator()
        {
            RuleFor(b => b.CheckinDate)
                .NotEmpty()
                .WithMessage("Check in boş bırakılamaz");
            RuleFor(b => b.CheckoutDate)
            .NotEmpty()
            .WithMessage("Check out boş bırakılamaz");

        }
    }
}
