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
            label9 = new Label();
            cmbPaymentMethod = new ComboBox();
            label8 = new Label();
            lblAmount = new Label();
            label7 = new Label();
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
            groupBox2 = new GroupBox();
            dgwRezervations = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtRezervationsSearch = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrGuest).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwRezervations).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cmbPaymentMethod);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lblAmount);
            groupBox1.Controls.Add(label7);
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
            groupBox1.Location = new Point(17, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1190, 605);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervasyon işlemleri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(757, 38);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(117, 25);
            label9.TabIndex = 17;
            label9.Text = "Misafir Listesi";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(244, 473);
            cmbPaymentMethod.Margin = new Padding(4, 5, 4, 5);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(307, 33);
            cmbPaymentMethod.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 478);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(144, 25);
            label8.TabIndex = 15;
            label8.Text = "Ödeme Yöntemi:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(321, 410);
            lblAmount.Margin = new Padding(4, 0, 4, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(32, 25);
            lblAmount.TabIndex = 14;
            lblAmount.Text = "$$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(200, 410);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 13;
            label7.Text = "Toplam Tutar:";
            // 
            // lstGuests
            // 
            lstGuests.FormattingEnabled = true;
            lstGuests.ItemHeight = 25;
            lstGuests.Location = new Point(723, 78);
            lstGuests.Margin = new Padding(4, 5, 4, 5);
            lstGuests.Name = "lstGuests";
            lstGuests.Size = new Size(425, 354);
            lstGuests.TabIndex = 12;
            // 
            // btnGuestInfo
            // 
            btnGuestInfo.Location = new Point(380, 208);
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
            btnKaydet.Location = new Point(446, 540);
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
            dateTimePicker2.Location = new Point(380, 322);
            dateTimePicker2.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(171, 31);
            dateTimePicker2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 332);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 8;
            label5.Text = "Çıkış Tarihi:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(380, 270);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(171, 31);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 280);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 6;
            label4.Text = "Girişi Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 212);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 5;
            label3.Text = "Misafir Sayısını Giriniz:";
            // 
            // nmrGuest
            // 
            nmrGuest.Location = new Point(261, 208);
            nmrGuest.Margin = new Padding(4, 5, 4, 5);
            nmrGuest.Name = "nmrGuest";
            nmrGuest.Size = new Size(90, 31);
            nmrGuest.TabIndex = 4;
            nmrGuest.ValueChanged += nmrGuest_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 152);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(188, 25);
            label6.TabIndex = 3;
            label6.Text = "Oda Numarası Seçiniz:";
            // 
            // cmbRoomNumber
            // 
            cmbRoomNumber.FormattingEnabled = true;
            cmbRoomNumber.Location = new Point(244, 147);
            cmbRoomNumber.Margin = new Padding(4, 5, 4, 5);
            cmbRoomNumber.Name = "cmbRoomNumber";
            cmbRoomNumber.Size = new Size(307, 33);
            cmbRoomNumber.TabIndex = 2;
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
            cmbRoomType.Location = new Point(244, 90);
            cmbRoomType.Margin = new Padding(4, 5, 4, 5);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(307, 33);
            cmbRoomType.TabIndex = 2;
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            // 
            // cmbHotel
            // 
            cmbHotel.FormattingEnabled = true;
            cmbHotel.Location = new Point(244, 37);
            cmbHotel.Margin = new Padding(4, 5, 4, 5);
            cmbHotel.Name = "cmbHotel";
            cmbHotel.Size = new Size(307, 33);
            cmbHotel.TabIndex = 1;
            cmbHotel.SelectedIndexChanged += cmbHotel_SelectedIndexChanged;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(dgwRezervations);
            groupBox2.Location = new Point(17, 680);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1190, 328);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rezervasyonlar";
            // 
            // dgwRezervations
            // 
            dgwRezervations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwRezervations.Dock = DockStyle.Fill;
            dgwRezervations.Location = new Point(4, 29);
            dgwRezervations.Margin = new Padding(4, 5, 4, 5);
            dgwRezervations.Name = "dgwRezervations";
            dgwRezervations.RowHeadersWidth = 62;
            dgwRezervations.Size = new Size(1182, 294);
            dgwRezervations.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(17, 635);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 38);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(150, 635);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 38);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtRezervationsSearch
            // 
            txtRezervationsSearch.Location = new Point(526, 637);
            txtRezervationsSearch.Margin = new Padding(4, 5, 4, 5);
            txtRezervationsSearch.Name = "txtRezervationsSearch";
            txtRezervationsSearch.Size = new Size(253, 31);
            txtRezervationsSearch.TabIndex = 4;
            // 
            // Frm_Booking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1220, 1028);
            Controls.Add(txtRezervationsSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Frm_Booking";
            Text = "Form2";
            Load += Frm_Booking_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrGuest).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwRezervations).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label7;
        private Label lblAmount;
        private Label label8;
        private ComboBox cmbPaymentMethod;
        private GroupBox groupBox2;
        private DataGridView dgwRezervations;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtRezervationsSearch;
        private Label label9;
    }
}