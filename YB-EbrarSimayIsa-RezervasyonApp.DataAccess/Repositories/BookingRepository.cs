﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Context;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Repositories
{
    public class BookingRepository : GenericRepository<Booking>
    {
        public BookingRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
