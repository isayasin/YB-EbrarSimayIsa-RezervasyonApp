using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.Validators
{
    public class StaffValidator:AbstractValidator<Staff>
    {
        public StaffValidator()
        {
            RuleFor(s => s.FirstName)
                .NotEmpty()
                .WithMessage("Ad bos birakilamaz.");


            RuleFor(s => s.LastName)
               .NotEmpty()
               .WithMessage("Soyad bos birakilamaz.");



            RuleFor(s => s.Position)
               .NotEmpty()
               .WithMessage("Pozisyon bos birakilamaz.");



            RuleFor(s => s.Salary)
               .NotEmpty()
               .WithMessage("Maas bos birakilamaz.")
               .GreaterThan(0)
               .WithMessage("Maas sifirdan buyuk olmalidir");


            RuleFor(s => s.DateOfBirth)
               .NotEmpty()
               .WithMessage("Dogum tarihi bos birakilamaz.");


            RuleFor(s => s.Phone)
               .NotEmpty()
               .WithMessage("Telefon bos birakilamaz.");


            RuleFor(s => s.Email)
               .NotEmpty()
               .WithMessage("Email bos birakilamaz.");


            RuleFor(s => s.HireDate)
               .NotEmpty()
               .WithMessage("Ise Alim Tarihi bos birakilamaz.");


        }


    }
}
