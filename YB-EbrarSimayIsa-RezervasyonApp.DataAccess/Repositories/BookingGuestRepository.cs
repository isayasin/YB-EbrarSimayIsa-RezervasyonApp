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
    public class BookingGuestRepository : GenericRepository<BookingGuest>
    {
        ApplicationDbContext _context;
        public BookingGuestRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<BookingGuest> GetByBookingId(Guid bookingId)
        {
            return _context.BookingGuests.Where(bg => bg.BookingID == bookingId).ToList();
        }
    }
}
