using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.Validators
{
    public class GuestValidator:AbstractValidator<Guest>
    {
        public GuestValidator() {
            RuleFor(g => g.FirstName).NotEmpty()
                .WithMessage("Misafir adı boş bırakılamaz");
            RuleFor(g => g.LastName).NotEmpty()
                .WithMessage("Misafir soyadı boş bırakılamaz");
            RuleFor(g => g.Email).NotEmpty()
                .WithMessage("Misafir Email boş bırakılamaz");
            RuleFor(g => g.Address).NotEmpty()
                .WithMessage("Misafir Adresi boş bırakılamaz");
            RuleFor(g => g.Phone).NotEmpty()
                .WithMessage("Misafir Telefon boş bırakılamaz");
            RuleFor(g => g.DateOfBirth).NotEmpty()
                .WithMessage("Doğum Tarihi boş bırakılamaz");
        
        }
    }
}
