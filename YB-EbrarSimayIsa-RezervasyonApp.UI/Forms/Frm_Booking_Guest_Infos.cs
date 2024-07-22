using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Models;

namespace YB_EbrarSimayIsa_RezervasyonApp.UI.Forms
{
    public partial class Frm_Booking_Guest_Infos : Form
    {
        public string GuestName { get; set; }
        public string GuestSurname { get; set; }
        public Frm_Booking_Guest_Infos()
        {
            InitializeComponent();
        }

        private void Frm_Booking_Guest_Infos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuestName = txtName.Text;
            GuestSurname = txtSurname.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
