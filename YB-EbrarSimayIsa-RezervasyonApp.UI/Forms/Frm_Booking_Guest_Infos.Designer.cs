namespace YB_EbrarSimayIsa_RezervasyonApp.UI.Forms
{
    partial class Frm_Booking_Guest_Infos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnGuestAdd = new Button();
            txtAddress = new TextBox();
            label14 = new Label();
            txtSurname = new TextBox();
            label13 = new Label();
            dtpBirth = new DateTimePicker();
            txtName = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label5 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(btnGuestAdd);
            groupBox2.Controls.Add(txtAddress);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtSurname);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(dtpBirth);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(91, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(339, 287);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Misafir Bilgileri";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(200, 151);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnGuestAdd
            // 
            btnGuestAdd.Location = new Point(225, 221);
            btnGuestAdd.Name = "btnGuestAdd";
            btnGuestAdd.Size = new Size(75, 23);
            btnGuestAdd.TabIndex = 6;
            btnGuestAdd.Text = "Misafir Ekle";
            btnGuestAdd.UseVisualStyleBackColor = true;
            btnGuestAdd.Click += button2_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(200, 93);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 151);
            label14.Name = "label14";
            label14.Size = new Size(67, 15);
            label14.TabIndex = 0;
            label14.Text = "Telefon No:";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(200, 58);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 122);
            label13.Name = "label13";
            label13.Size = new Size(36, 15);
            label13.TabIndex = 0;
            label13.Text = "Email";
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(111, 185);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(189, 23);
            dtpBirth.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(200, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 93);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 0;
            label12.Text = "Adress";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 58);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 0;
            label11.Text = "Soyad:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 26);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 0;
            label10.Text = "Ad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 191);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 1;
            label5.Text = "Doğum Tarihi:";
            // 
            // Frm_Booking_Guest_Infos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(498, 368);
            Controls.Add(groupBox2);
            Name = "Frm_Booking_Guest_Infos";
            Text = "Frm_Booking_Guest_Infos";
            Load += Frm_Booking_Guest_Infos_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnGuestAdd;
        private TextBox txtAddress;
        private Label label14;
        private TextBox txtSurname;
        private Label label13;
        private DateTimePicker dtpBirth;
        private TextBox txtName;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label5;
    }
}