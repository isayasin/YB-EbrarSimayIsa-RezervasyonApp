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

namespace YB_EbrarSimayIsa_RezervasyonApp.UI.Forms
{
    public partial class Frm_GuestDetails : Form
    {
        public string GuestName { get; set; }
        public string GuestSurname { get; set; }
        public string GuestEmail { get; set; }
        public string GuestPhone { get; set; }
        public string GuestAddress { get; set; }
        public DateTime GuestBirthDate { get; set; }



        public Frm_GuestDetails()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            GuestName = txtFirstName.Text;
            GuestSurname = txtLastName.Text;
            GuestEmail = txtEmail.Text;
            GuestAddress = txtAddress.Text;
            GuestPhone = txtPhone.Text;
            GuestBirthDate = dtpBirthdate.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Frm_GuestDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
