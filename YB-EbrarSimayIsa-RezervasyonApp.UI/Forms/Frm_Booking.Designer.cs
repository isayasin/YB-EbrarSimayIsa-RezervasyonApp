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
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbRoomType);
            groupBox1.Controls.Add(cmbHotel);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1091, 512);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervasyon işlemleri";
            // 
            // lstGuests
            // 
            lstGuests.FormattingEnabled = true;
            lstGuests.ItemHeight = 25;
            lstGuests.Location = new Point(616, 25);
            lstGuests.Margin = new Padding(4, 5, 4, 5);
            lstGuests.Name = "lstGuests";
            lstGuests.Size = new Size(467, 379);
            lstGuests.TabIndex = 12;
            // 
            // btnGuestInfo
            // 
            btnGuestInfo.Location = new Point(380, 152);
            btnGuestInfo.Margin = new Padding(4, 5, 4, 5);
            btnGuestInfo.Name = "btnGuestInfo";
            btnGuestInfo.Size = new Size(173, 38);
            btnGuestInfo.TabIndex = 11;
            btnGuestInfo.Text = "Misafir Bilgileri";
            btnGuestInfo.UseVisualStyleBackColor = true;
            btnGuestInfo.Click += btnGuestInfo_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(244, 352);
            btnKaydet.Margin = new Padding(4, 5, 4, 5);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(107, 38);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(179, 277);
            dateTimePicker2.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(171, 31);
            dateTimePicker2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 287);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 8;
            label5.Text = "Çıkış Tarihi:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(179, 225);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(171, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 235);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 6;
            label4.Text = "Girişi Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 155);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 5;
            label3.Text = "Misafir Sayısını Giriniz:";
            // 
            // nmrGuest
            // 
            nmrGuest.Location = new Point(261, 152);
            nmrGuest.Margin = new Padding(4, 5, 4, 5);
            nmrGuest.Name = "nmrGuest";
            nmrGuest.Size = new Size(90, 31);
            nmrGuest.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 3;
            label2.Text = "Oda Tipi Seçiniz:";
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(179, 90);
            cmbRoomType.Margin = new Padding(4, 5, 4, 5);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(171, 33);
            cmbRoomType.TabIndex = 2;
            // 
            // cmbHotel
            // 
            cmbHotel.FormattingEnabled = true;
            cmbHotel.Location = new Point(179, 37);
            cmbHotel.Margin = new Padding(4, 5, 4, 5);
            cmbHotel.Name = "cmbHotel";
            cmbHotel.Size = new Size(171, 33);
            cmbHotel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "Otel Seçiniz:";
            // 
            // Frm_Booking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1143, 890);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
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
    }
}