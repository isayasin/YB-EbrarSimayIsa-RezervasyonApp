using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YB_EbrarSimayIsa_RezervasyonApp.Business.Services;
using YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Context;
using YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Repositories;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.UI.Forms
{
    public partial class Frm_Booking : Form
    {

        private readonly ApplicationDbContext _context;
        private readonly BookingService _bookingService;
        private readonly BookingRepository _bookingRepository;
        public Frm_Booking()
        {
            _context = new ApplicationDbContext();
            _bookingRepository = new BookingRepository(_context);
            _bookingService = new BookingService(_bookingRepository);
            InitializeComponent();
        }

        private List<Guest> guests = new List<Guest>();
        private void btnGuestInfo_Click(object sender, EventArgs e)
        {
            int guestCount = (int)nmrGuest.Value;

            for (int i = 0; i < guestCount; i++)
            {
                using (Frm_GuestDetails guestForm = new Frm_GuestDetails())
                {
                    if (guestForm.ShowDialog() == DialogResult.OK)
                    {
                        Guest guest = new Guest
                        {
                            FirstName = guestForm.GuestName,
                            LastName = guestForm.GuestSurname,
                            Email = guestForm.GuestEmail,
                            Phone = guestForm.GuestPhone,
                            Address = guestForm.GuestAddress,
                            DateOfBirth = guestForm.GuestBirthDate
                        };

                        guests.Add(guest);

                        // Liste kutusuna ekle
                        lstGuests.Items.Add($"{guest.FirstName} {guest.LastName} - {guest.Email}");
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Guest guest in guests)
            {
                sb.AppendLine($"Ad: {guest.FirstName}");
                sb.AppendLine($"Soyad: {guest.LastName}");
                sb.AppendLine($"Email: {guest.Email}");
                sb.AppendLine($"Telefon: {guest.Phone}");
                sb.AppendLine($"Adres: {guest.Address}");
                sb.AppendLine($"Doğum Tarihi: {guest.DateOfBirth.ToShortDateString()}");
                sb.AppendLine(new string('-', 20));
            }

            MessageBox.Show(sb.ToString(), "Misafir Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
