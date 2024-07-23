namespace YB_EbrarSimayIsa_RezervasyonApp.UI.Forms
{
    partial class Frm_Booking
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
            groupBox1 = new GroupBox();
            lstGuests = new ListBox();
            btnGuestInfo = new Button();
            btnKaydet = new Button();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            nmrGuest = new NumericUpDown();
            label6 = new Label();
            cmbRoomNumber = new ComboBox();
            label2 = new Label();
            cmbRoomType = new ComboBox();
            cmbHotel = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrGuest).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(lstGuests);
            groupBox1.Controls.Add(btnGuestInfo);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nmrGuest);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbRoomNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbRoomType);
            groupBox1.Controls.Add(cmbHotel);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 293);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervasyon işlemleri";
            // 
            // lstGuests
            // 
            lstGuests.FormattingEnabled = true;
            lstGuests.ItemHeight = 15;
            lstGuests.Location = new Point(451, 25);
            lstGuests.Name = "lstGuests";
            lstGuests.Size = new Size(264, 214);
            lstGuests.TabIndex = 12;
            // 
            // btnGuestInfo
            // 
            btnGuestInfo.Location = new Point(266, 125);
            btnGuestInfo.Name = "btnGuestInfo";
            btnGuestInfo.Size = new Size(121, 23);
            btnGuestInfo.TabIndex = 11;
            btnGuestInfo.Text = "Misafir Bilgileri";
            btnGuestInfo.UseVisualStyleBackColor = true;
            btnGuestInfo.Click += btnGuestInfo_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(171, 256);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(125, 211);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(121, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 217);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 8;
            label5.Text = "Çıkış Tarihi:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(125, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 186);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Girişi Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 127);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 5;
            label3.Text = "Misafir Sayısını Giriniz:";
            // 
            // nmrGuest
            // 
            nmrGuest.Location = new Point(183, 125);
            nmrGuest.Name = "nmrGuest";
            nmrGuest.Size = new Size(63, 23);
            nmrGuest.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 91);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 3;
            label6.Text = "Oda Numarası Seçiniz:";
            // 
            // cmbRoomNumber
            // 
            cmbRoomNumber.FormattingEnabled = true;
            cmbRoomNumber.Location = new Point(171, 88);
            cmbRoomNumber.Name = "cmbRoomNumber";
            cmbRoomNumber.Size = new Size(121, 23);
            cmbRoomNumber.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 57);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 3;
            label2.Text = "Oda Tipi Seçiniz:";
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(171, 54);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(121, 23);
            cmbRoomType.TabIndex = 2;
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            // 
            // cmbHotel
            // 
            cmbHotel.FormattingEnabled = true;
            cmbHotel.Location = new Point(171, 22);
            cmbHotel.Name = "cmbHotel";
            cmbHotel.Size = new Size(121, 23);
            cmbHotel.TabIndex = 1;
            cmbHotel.SelectedIndexChanged += cmbHotel_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Otel Seçiniz:";
            // 
            // Frm_Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 534);
            Controls.Add(groupBox1);
            Name = "Frm_Booking";
            Text = "Form2";
            Load += Frm_Booking_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrGuest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGuestInfo;
        private Button btnKaydet;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private NumericUpDown nmrGuest;
        private Label label2;
        private ComboBox cmbRoomType;
        private ComboBox cmbHotel;
        private Label label1;
        private ListBox lstGuests;
        private Label label6;
        private ComboBox cmbRoomNumber;
    }
}