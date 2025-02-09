﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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

        private readonly BookingGuestService _bookingGuestService;
        private readonly BookingGuestRepository _bookingGuestRepository;


        private readonly PaymentService _paymentService;
        private readonly PaymentRepository _paymentRepository;

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
            _roomTypeService = new RoomTypeService(_roomTypeRepository, _roomRepository);

            _bookingGuestRepository = new BookingGuestRepository(_context);
            _bookingGuestService = new BookingGuestService(_bookingGuestRepository);

            _paymentRepository = new PaymentRepository(_context);
            _paymentService = new PaymentService(_paymentRepository);

        }

        private List<string> payments = new List<string>();
        private List<Guest> guests = new List<Guest>();
        decimal totalPrice;
        int secilen;
        bool isUpdating = false;
        private Booking _booking;
        private Room _room;
        private Hotel _hotel;
        private Payment _payment;
        private void Frm_Booking_Load(object sender, EventArgs e)
        {
            DataGridListFill();
            PaymentsComboFill();
            HotelComboFill();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
        }

        private void btnGuestInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int guestCount = (int)nmrGuest.Value;

                /*int newGuestCount = (int)nmrGuest.Value;
                if (!isUpdating)
                {
                    //Math.Abs(guestCount);
                    newGuestCount = (int)nmrGuest.Value;
                    
                } else if (isUpdating)
                {
                    var bookingGuests = _context.BookingGuests.Where(bg => bg.BookingID == _booking.ID).ToList();

                    newGuestCount = Math.Abs(bookingGuests.Count - (int)nmrGuest.Value);
                }*/

                for (int i = 0; i < guestCount; i++)
                {
                    using (Frm_GuestDetails guestForm = new Frm_GuestDetails())
                    {
                        if (guestForm.ShowDialog() == DialogResult.OK)
                        {
                            foreach (var control in guestForm.Controls)
                            {
                                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                                {
                                    throw new Exception("Misafir bilgileri boş geçilemez.");
                                }
                                else if (control is ComboBox comboBox && comboBox.SelectedIndex == -1)
                                {
                                    throw new Exception("Misafir bilgileri boş geçilemez.");
                                }
                                else if (control is DateTimePicker dateTimePicker && dateTimePicker.Value == default(DateTime))
                                {
                                    throw new Exception("Misafir bilgileri boş geçilemez.");
                                }
                            }
                            Guest guest = new Guest
                            {
                                //ID = new Guid(),
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Booking booking = new Booking()
                    {
                        CheckinDate = dateTimePicker1.Value,
                        CheckoutDate = dateTimePicker2.Value,
                        RoomID = Guid.Parse(cmbRoomNumber.SelectedValue.ToString()),
                        TotalPrice = totalPrice,
                    };

                    Payment payment = new Payment()
                    {
                        BookingID = booking.ID,
                        Amount = booking.TotalPrice,
                        PaymentDate = DateTime.Now,
                        PaymentMethod = payments[secilen],
                    };

                    foreach (var item in guests)
                    {
                        _guestService.Add(item);
                    }

                    _bookingService.Add(booking);


                    foreach (var item in guests)
                    {
                        BookingGuest bookingGuest = new BookingGuest()
                        {
                            BookingID = booking.ID,
                            GuestID = item.ID,
                        };
                        _bookingGuestService.Add(bookingGuest);
                    }
                    _paymentService.Add(payment);

                    transaction.Commit();
                    DataGridListFill();
                    MessageBox.Show("Rezervasyon başarı ile kayıt edildi.");


                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Rezervasyon ID: {booking.ID}");
                    sb.AppendLine(new string('-', 20));
                    sb.AppendLine($"Otel Adı: {(_hotelService.GetById(_roomService.GetById(booking.RoomID).HotelID)).Name}");
                    sb.AppendLine($"Oda Numarası: {_roomService.GetById(booking.RoomID).RoomNumber}");
                    sb.AppendLine($"Oda Tipi: {(_roomTypeService.GetById(_roomService.GetById(booking.RoomID).RoomTypeID)).Name}");
                    sb.AppendLine($"Oda'nın Gecelik Ücreti: {(_roomTypeService.GetById(_roomService.GetById(booking.RoomID).RoomTypeID)).PricePerNight}");


                    sb.AppendLine($"CheckIn Tarihi: {booking.CheckinDate.ToShortDateString()}");
                    sb.AppendLine($"CheckOut Tarihi: {booking.CheckoutDate.ToShortDateString()}");
                    sb.AppendLine($"Rezervasyonun Total Ücreti: {payment.Amount}");


                    sb.AppendLine(new string('-', 20));
                    sb.AppendLine($"Toplam Misafir Sayısı: {guests.Count}");
                    sb.AppendLine(new string('-', 20));
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


                    MessageBox.Show(sb.ToString(), "Rezervasyon Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    ClearFormInputs();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearFormInputs()
        {
            // Temizleme işlemleri
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now.AddDays(1);
            dateTimePicker3.Value = DateTime.Now.AddDays(-1);
            cmbHotel.SelectedIndex = -1;
            cmbRoomType.DataSource = null;
            cmbRoomType.SelectedIndex = -1;
            cmbRoomNumber.DataSource = null;
            cmbRoomNumber.SelectedIndex = -1;
            cmbPaymentMethod.SelectedIndex = -1;
            nmrGuest.Value = 0;
            lstGuests.Items.Clear();
            lblAmount.Text = "0 TL";
            totalPrice = 0;
            txtRezervationsSearch.Clear();
            guests.Clear();
        }

        private void DataGridListFill()
        {
            dgwRezervations.ClearSelection();
            dgwRezervations.DataSource = null;
            dgwRezervations.DataSource = _bookingService.GetAll();
        }

        private void PaymentsComboFill()
        {
            payments.Add("Nakit");
            payments.Add("Kredi Karti");
            payments.Add("Banka Karti");

            foreach (var item in payments)
            {
                cmbPaymentMethod.Items.Add(item);
            }
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
            if (cmbHotel.SelectedValue is Guid hotelId)
            {
                cmbRoomType.DataSource = null;
                var roomTypes = _roomTypeService.GetRoomTypesByHotelId(hotelId);
                cmbRoomType.DataSource = roomTypes;
                cmbRoomType.DisplayMember = "DisplayInfo";
                cmbRoomType.ValueMember = "ID";
                cmbRoomType.SelectedIndex = -1;
            }
        }

        void RoomNumberFill()
        {
            if (cmbHotel.SelectedValue is Guid hotelId && cmbRoomType.SelectedValue is Guid roomTypeId)
            {
                cmbRoomNumber.DataSource = null;
                var rooms = _roomService.GetRoomsByHotelAndRoomType(hotelId, roomTypeId);
                cmbRoomNumber.DataSource = rooms.ToList();
                cmbRoomNumber.DisplayMember = "RoomNumber";
                cmbRoomNumber.ValueMember = "ID";
                cmbRoomNumber.SelectedIndex = -1;
            }
        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isUpdating)
            {
                RoomTypeComboFill();
                TotalPriceCalculate();
            }
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isUpdating)
            {
                RoomNumberFill();
                TotalPriceCalculate();
            }
            if (cmbRoomType.SelectedValue is Guid roomTypeId)
            {
                nmrGuest.Maximum = _roomTypeService.GetById(roomTypeId).Capacity;
            }
        }

        private void cmbRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            TotalPriceCalculate();
        }

        private void nmrGuest_ValueChanged(object sender, EventArgs e)
        {
            TotalPriceCalculate();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
            TotalPriceCalculate();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TotalPriceCalculate();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            DateTime searchDate = dateTimePicker3.Value.Date;

            if (searchDate >= DateTime.Now.Date)
            {
                var data = from bookingGuest in _context.BookingGuests
                           join booking in _context.Bookings on bookingGuest.BookingID equals booking.ID
                           join guest in _context.Guests on bookingGuest.GuestID equals guest.ID
                           join roomType in _context.RoomTypes on booking.Room.RoomType.ID equals roomType.ID
                           where booking.CheckinDate.Date <= searchDate && booking.CheckoutDate >= searchDate
                           select new
                           {
                               ID = booking.ID,
                               GuestID = guest.ID,
                               CheckInDate = booking.CheckinDate,
                               CheckOutDate = booking.CheckoutDate,
                               Total_Price = booking.TotalPrice,
                               GuestFirstName = guest.FirstName,
                               GuestLastName = guest.LastName,
                               GuestAddress = guest.Address,
                               GuestPhone = guest.Phone,
                               GuestEmail = guest.Email,
                               GuestCreateDate = guest.CreateAtDate,
                               RooomTypeName = roomType.Name,
                               RoomTypeDescription = roomType.Description,
                               RoomTypePricePerNight = roomType.PricePerNight,
                               RoomTypeCapacity = roomType.Capacity
                           };

                dgwRezervations.DataSource = data.ToList();
                if (data == null)
                {
                    dgwRezervations.DataSource = _bookingService.GetAll();
                }
            }
            else
            {
                dgwRezervations.DataSource = _bookingService.GetAll();
            }
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = cmbPaymentMethod.SelectedIndex;
        }

        private void TotalPriceCalculate()
        {
            if (cmbHotel.SelectedIndex != -1 && cmbRoomType.SelectedIndex != -1 && cmbRoomNumber.SelectedIndex != -1 && nmrGuest.Value > 0 && dateTimePicker1.Value != null)
            {
                var roomType = _roomTypeService.GetById((Guid)cmbRoomType.SelectedValue);
                decimal pricePerNight = roomType.PricePerNight;

                int daysOfReservation;
                TimeSpan ReservationDays = dateTimePicker2.Value.Date - dateTimePicker1.Value.Date;
                daysOfReservation = ReservationDays.Days;
                totalPrice = pricePerNight * nmrGuest.Value * daysOfReservation;

                lblAmount.Text = $"{totalPrice.ToString()} TL";
            }


        }

        private void txtRezervationsSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGridAndSearch();
        }

        private void UpdateDataGridAndSearch()
        {
            string searchText = txtRezervationsSearch.Text.ToLower();

            if (!string.IsNullOrEmpty(searchText) && searchText.Length >= 1)
            {
                var data = from bookingGuest in _context.BookingGuests
                           join booking in _context.Bookings on bookingGuest.BookingID equals booking.ID
                           join guest in _context.Guests on bookingGuest.GuestID equals guest.ID
                           join roomType in _context.RoomTypes on booking.Room.RoomType.ID equals roomType.ID
                           where guest.FirstName.ToLower().Contains(searchText)
                           select new
                           {
                               ID = booking.ID,
                               GuestID = guest.ID,
                               CheckInDate = booking.CheckinDate,
                               CheckOutDate = booking.CheckoutDate,
                               Total_Price = booking.TotalPrice,
                               GuestFirstName = guest.FirstName,
                               GuestLastName = guest.LastName,
                               GuestAddress = guest.Address,
                               GuestPhone = guest.Phone,
                               GuestEmail = guest.Email,
                               GuestCreateDate = guest.CreateAtDate,
                               RooomTypeName = roomType.Name,
                               RoomTypeDescription = roomType.Description,
                               RoomTypePricePerNight = roomType.PricePerNight,
                               RoomTypeCapacity = roomType.Capacity
                           };

                dgwRezervations.DataSource = data.ToList();
            }
            else
            {
                dgwRezervations.DataSource = _bookingService.GetAll();
            }
        }

        private void dgwRezervations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            isUpdating = true;
            try
            {
                _booking = _bookingService.GetById((Guid)dgwRezervations.CurrentRow.Cells["Id"].Value);
                _room = _roomService.GetById(_booking.RoomID);
                _hotel = _hotelService.GetById(_room.HotelID);
                _payment = _paymentService.GetAll().FirstOrDefault(p => p.BookingID == _booking.ID);

                // Oteli doldur ve seçili değeri ayarla
                cmbHotel.DataSource = null;
                cmbHotel.DataSource = _hotelService.GetAll();
                cmbHotel.DisplayMember = "Name";
                cmbHotel.ValueMember = "ID";
                cmbHotel.SelectedValue = _room.HotelID;

                // Oda tipini doldur ve seçili değeri ayarla
                RoomTypeComboFill();  // Bu metod cmbHotel_SelectedIndexChanged olayını tetikler
                cmbRoomType.SelectedValue = _room.RoomTypeID;

                // Oda numarasını doldur ve seçili değeri ayarla
                RoomNumberFill();  // Bu metod cmbRoomType_SelectedIndexChanged olayını tetikler
                cmbRoomNumber.SelectedValue = _booking.RoomID;

                // Diğer alanları doldur
                dateTimePicker1.Value = _booking.CheckinDate;
                dateTimePicker2.Value = _booking.CheckoutDate;

                var bookingGuests = _context.BookingGuests.Where(bg => bg.BookingID == _booking.ID).ToList();
                nmrGuest.Value = bookingGuests.Count;

                // Misafir bilgilerini ListBox'a ekle
                lstGuests.Items.Clear();
                guests.Clear();
                foreach (var bookingGuest in bookingGuests)
                {
                    var guest = _guestService.GetById(bookingGuest.GuestID);
                    guests.Add(guest);
                    lstGuests.Items.Add($"{guest.FirstName} - {guest.LastName} - {guest.Email}");
                }

                totalPrice = _booking.TotalPrice;
                lblAmount.Text = $"{totalPrice.ToString()} TL";

                var payment = _context.Payments.FirstOrDefault(p => p.BookingID == _booking.ID);
                if (payment != null)
                {
                    cmbPaymentMethod.SelectedItem = payment.PaymentMethod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                isUpdating = false;
            }
        }

        private void lstGuests_DoubleClick(object sender, EventArgs e)
        {
            if (lstGuests.SelectedIndex != -1)
            {
                var selectedGuest = guests[lstGuests.SelectedIndex];
                using (Frm_GuestDetails guestForm = new Frm_GuestDetails())
                {
                    // Misafir bilgilerini formda doldur
                    guestForm.GuestName = selectedGuest.FirstName;
                    guestForm.GuestSurname = selectedGuest.LastName;
                    guestForm.GuestEmail = selectedGuest.Email;
                    guestForm.GuestPhone = selectedGuest.Phone;
                    guestForm.GuestAddress = selectedGuest.Address;
                    guestForm.GuestBirthDate = selectedGuest.DateOfBirth;

                    if (guestForm.ShowDialog() == DialogResult.OK)
                    {
                        // Güncellenmiş bilgileri misafir nesnesine aktar
                        selectedGuest.FirstName = guestForm.GuestName;
                        selectedGuest.LastName = guestForm.GuestSurname;
                        selectedGuest.Email = guestForm.GuestEmail;
                        selectedGuest.Phone = guestForm.GuestPhone;
                        selectedGuest.Address = guestForm.GuestAddress;
                        selectedGuest.DateOfBirth = guestForm.GuestBirthDate;

                        // ListBox'ı güncelle
                        lstGuests.Items[lstGuests.SelectedIndex] = $"{selectedGuest.FirstName} {selectedGuest.LastName} - {selectedGuest.Email}";
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _booking.CheckinDate = dateTimePicker1.Value;
                    _booking.CheckoutDate = dateTimePicker2.Value;
                    _booking.RoomID = (Guid)cmbRoomNumber.SelectedValue;
                    _booking.TotalPrice = totalPrice;

                    _payment.Amount = _booking.TotalPrice;
                    _payment.PaymentMethod = payments[secilen];

                    _bookingService.Update(_booking);
                    _paymentService.Update(_payment);

                    // Mevcut misafirleri güncelle
                    var existingBookingGuests = _bookingGuestService.GetByBookingId(_booking.ID).ToList();
                    var newGuestIds = guests.Select(g => g.ID).ToList();

                    // Var olan misafirleri kontrol et ve güncelle
                    foreach (var bookingGuest in existingBookingGuests)
                    {
                        if (!newGuestIds.Contains(bookingGuest.GuestID))
                        {
                            _bookingGuestService.GetById(bookingGuest.ID).IsActive = false;
                            _bookingGuestService.GetById(bookingGuest.ID).IsDeleted = true;
                            _bookingGuestService.Delete(bookingGuest.ID);  // Misafiri rezervasyondan çıkar
                        }
                    }

                    // Yeni misafirleri ekle veya güncelle
                    foreach (var guest in guests)
                    {
                        if (_guestService.Exists(guest.ID))
                        {
                            _guestService.Update(guest);  // Misafir bilgilerini güncelle
                        }
                        else
                        {
                            _guestService.Add(guest);  // Yeni misafiri ekle
                        }

                        var bookingGuest = new BookingGuest
                        {
                            BookingID = _booking.ID,
                            GuestID = guest.ID
                        };

                        if (!_bookingGuestService.GetByBookingId(_booking.ID).Any(bg => bg.GuestID == guest.ID))
                        {
                            _bookingGuestService.Add(bookingGuest);  // Misafiri rezervasyona ekle
                        }
                    }

                    // Rezervasyonu güncelle
                    _bookingService.Update(_booking);

                    transaction.Commit();
                    DataGridListFill();
                    MessageBox.Show("Rezervasyon başarı ile güncellendi.");
                    ClearFormInputs();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwRezervations.SelectedRows.Count > 0)
            {
                // Seçili satırdan ID'yi al
                var selectedRow = dgwRezervations.SelectedRows[0];
                var bookingId = (Guid)selectedRow.Cells["ID"].Value;
                try
                {
                    // Seçilen booking nesnesini al
                    var booking = _bookingService.GetById(bookingId);
                    if (booking != null)
                    {
                        // Silme işlemini yap
                        booking.IsDeleted = true;
                        booking.IsActive = false;
                        _bookingService.Delete(bookingId);
                        MessageBox.Show("Rezervasyon başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // DataGridView'i güncelle
                        UpdateDataGridAndSearch();
                    }
                    else
                    {
                        MessageBox.Show("Seçili rezervasyon bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir rezervasyon seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuestDelete_Click(object sender, EventArgs e)
        {
            if (lstGuests.SelectedIndex != -1)
            {
                // Seçili misafiri al
                var selectedGuest = guests[lstGuests.SelectedIndex];

                selectedGuest.IsDeleted = true;
                selectedGuest.IsActive = false;

                // Misafiri listeden kaldır
                guests.Remove(selectedGuest);
                lstGuests.Items.RemoveAt(lstGuests.SelectedIndex);

                // Misafir sayısını güncelle
                nmrGuest.Value = guests.Count;

                // Toplam tutarı yeniden hesapla
                TotalPriceCalculate();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir misafir seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearFormInputs();
        }
    }
}

