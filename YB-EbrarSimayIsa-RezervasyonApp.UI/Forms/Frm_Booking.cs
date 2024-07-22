using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.UI.Forms
{
    public partial class Frm_Booking : Form
    {
        private FlowLayoutPanel flpBookingGuests;
        public Frm_Booking()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Guest> guests = new List<Guest>();

            for (int i = 0; i < flpBookingGuests.Controls.Count; i += 2)
            {
                string guestName = flpBookingGuests.Controls[i].Text.Split(':')[1].Trim();
                string guestSurname = flpBookingGuests.Controls[i + 1].Text.Split(':')[1].Trim();

                guests.Add(new Guest
                {
                    FirstName = guestName,
                    LastName = guestName,
                    
                });
            }
        }

        private void Frm_Booking_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            flpBookingGuests.Controls.Clear();

            int guestCount = (int)numericUpDown1.Value;

            for (int i = 0; i < guestCount; i++)
            {
                using (Frm_Booking_Guest_Infos guestForm = new Frm_Booking_Guest_Infos())
                {
                    if (guestForm.ShowDialog() == DialogResult.OK)
                    {
                        // Misafir adı ve soyadı için label
                        Label lblName = new Label();
                        lblName.Text = $"Misafir {i + 1} Adı: {guestForm.GuestName}";
                        lblName.AutoSize = true;
                        flpBookingGuests.Controls.Add(lblName);

                        Label lblSurname = new Label();
                        lblSurname.Text = $"Misafir {i + 1} Soyadı: {guestForm.GuestSurname}";
                        lblSurname.AutoSize = true;
                        flpBookingGuests.Controls.Add(lblSurname);
                    }
                }
            }
        }
    }
}
