﻿using System;
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

        private readonly GuestService _guestService;
        private readonly GuestRepository _guestRepository;

        private readonly HotelService _hotelService;
        private readonly HotelRepository _hotelRepository;

        private readonly RoomService _roomService;
        private readonly RoomRepository _roomRepository;

        private readonly RoomTypeService _roomTypeService;
        private readonly RoomTypeRepository _roomTypeRepository;

        public Frm_Booking()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _bookingRepository = new BookingRepository(_context);
            _bookingService = new BookingService(_bookingRepository);

            _guestRepository = new GuestRepository(_context);
            _guestService = new GuestService(_guestRepository);

            _hotelRepository = new HotelRepository(_context);
            _hotelService = new HotelService(_hotelRepository);

            _roomRepository = new RoomRepository(_context);
            _roomService = new RoomService(_roomRepository);

            _roomTypeRepository = new RoomTypeRepository(_context);
            _roomTypeService = new RoomTypeService(_roomTypeRepository);
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
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Booking b = new Booking()
                    {
                        CheckinDate = dateTimePicker1.Value,
                        CheckoutDate = dateTimePicker2.Value,
                    };
                    _bookingService.Add(b);

                    Room r = new Room()
                    {
                        RoomTypeID = (Guid)cmbRoomType.SelectedValue,
                    };

                    _roomService.Add(r);

                    Hotel hotel = new Hotel()
                    {
                        ID = (Guid)cmbHotel.SelectedValue,
                    };

                    _hotelService.Add(hotel);

                    guests.ForEach(x => _guestService.Add(
                        new Guest()
                        {
                            FirstName = x.FirstName,
                            LastName = x.LastName,
                            Email = x.Email,
                            Phone = x.Phone,
                            Address = x.Address,
                            DateOfBirth = x.DateOfBirth,
                        }
                        ));

                    transaction.Commit();
                    //GetAllRezervations();
                    MessageBox.Show("Rezervasyon başarı ile kayıt edildi.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }


            /*StringBuilder sb = new StringBuilder();
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

            MessageBox.Show(sb.ToString(), "Misafir Listesi", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

        }

        private void GetAllRezervations()
        {
            throw new NotImplementedException();
        }

        private void Frm_Booking_Load(object sender, EventArgs e)
        {
            HotelComboFill();

            var roomTypes = _roomTypeService.GetAll();
            
            // RoomTypes içeriğini bir string'e ekle
            StringBuilder sb = new StringBuilder();
            foreach (var roomType in roomTypes)
            {
                sb.AppendLine($"ID: {roomType.ID}, Name: {roomType.Name}, Price: {roomType.PricePerNight:C}");
            }

            // RoomTypes içeriğini MessageBox ile göster
            MessageBox.Show(sb.ToString(), "Room Types");
        }

        void HotelComboFill()
        {
            cmbHotel.DataSource = null;
            cmbHotel.DataSource = _hotelService.GetAll();
            cmbHotel.DisplayMember = "Name";
            cmbHotel.ValueMember = "ID";
            cmbHotel.SelectedIndex = -1;
        }

        void RoomTypeComboFill()
        {
            cmbRoomType.DataSource = null;
            cmbRoomType.DataSource = _roomTypeService.GetAll();
            cmbRoomType.DisplayMember = "DisplayInfo";
            cmbRoomType.ValueMember = "ID";
            cmbRoomType.SelectedIndex = -1;
        }

        void RoomNumberFill()
        {
            cmbRoomType.DataSource = null;
            //cmbRoomType.DataSource = _roomService.GetById((Guid)cmbRoomType.SelectedValue);
            cmbRoomType.DataSource = _roomService.GetAll();
            cmbRoomType.DisplayMember = "RoomNumber";
            cmbRoomType.ValueMember = "ID";
            cmbRoomType.SelectedIndex = -1;
        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomTypeComboFill();
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomNumberFill();
        }
    }
}
