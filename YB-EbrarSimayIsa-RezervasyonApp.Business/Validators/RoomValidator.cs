﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.Validators
{
    public class RoomValidator: AbstractValidator<Room>
    {

        public RoomValidator()
        {
            RuleFor(r => r.Status)
                .NotEmpty()
                .WithMessage("Statu bos birakilamaz.");

        }
    }
}
