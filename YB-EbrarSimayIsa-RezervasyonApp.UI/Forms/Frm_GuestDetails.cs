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
        public string GuestName
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }

        public string GuestSurname
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        public string GuestEmail
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }

        public string GuestPhone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }

        public string GuestAddress
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }

        public DateTime GuestBirthDate
        {
            get { return dtpBirthdate.Value; }
            set { dtpBirthdate.Value = value; }
        }



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
