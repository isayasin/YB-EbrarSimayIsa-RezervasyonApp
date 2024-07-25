using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Context;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Repositories
{
    public class GuestRepository : GenericRepository<Guest>
    {
        ApplicationDbContext _context;
        public GuestRepository(ApplicationDbContext context) : base(context)
        {
             _context = context;
        }
        public bool Exists(Guid id)
        {
            return _context.Guests.Any(g => g.ID == id);
        }
    }
}
