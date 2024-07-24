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
            groupBox1.Location = new Point(26, 30);
            groupBox1.Margin = new Padding(6, 7, 6, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 7, 6, 7);
            groupBox1.Size = new Size(1785, 895);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervasyon işlemleri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(795, 35);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(176, 37);
            label9.TabIndex = 17;
            label9.Text = "Misafir Listesi";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(366, 701);
            cmbPaymentMethod.Margin = new Padding(6, 7, 6, 7);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(458, 45);
            cmbPaymentMethod.TabIndex = 16;
            cmbPaymentMethod.SelectedIndexChanged += cmbPaymentMethod_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 708);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(214, 37);
            label8.TabIndex = 15;
            label8.Text = "Ödeme Yöntemi:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(482, 607);
            lblAmount.Margin = new Padding(6, 0, 6, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(47, 37);
            lblAmount.TabIndex = 14;
            lblAmount.Text = "$$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(300, 607);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(178, 37);
            label7.TabIndex = 13;
            label7.Text = "Toplam Tutar:";
            // 
            // lstGuests
            // 
            lstGuests.FormattingEnabled = true;
            lstGuests.ItemHeight = 37;
            lstGuests.Location = new Point(1084, 116);
            lstGuests.Margin = new Padding(6, 7, 6, 7);
            lstGuests.Name = "lstGuests";
            lstGuests.Size = new Size(636, 522);
            lstGuests.TabIndex = 12;
            // 
            // btnGuestInfo
            // 
            btnGuestInfo.Location = new Point(570, 308);
            btnGuestInfo.Margin = new Padding(6, 7, 6, 7);
            btnGuestInfo.Name = "btnGuestInfo";
            btnGuestInfo.Size = new Size(259, 57);
            btnGuestInfo.TabIndex = 11;
            btnGuestInfo.Text = "Misafir Bilgileri";
            btnGuestInfo.UseVisualStyleBackColor = true;
            btnGuestInfo.Click += btnGuestInfo_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(669, 799);
            btnKaydet.Margin = new Padding(6, 7, 6, 7);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(161, 57);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(570, 476);
            dateTimePicker2.Margin = new Padding(6, 7, 6, 7);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(255, 43);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 491);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(148, 37);
            label5.TabIndex = 8;
            label5.Text = "Çıkış Tarihi:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(570, 400);
            dateTimePicker1.Margin = new Padding(6, 7, 6, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(255, 43);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 414);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 37);
            label4.TabIndex = 6;
            label4.Text = "Girişi Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 313);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(281, 37);
            label3.TabIndex = 5;
            label3.Text = "Misafir Sayısını Giriniz:";
            // 
            // nmrGuest
            // 
            nmrGuest.Location = new Point(392, 308);
            nmrGuest.Margin = new Padding(6, 7, 6, 7);
            nmrGuest.Name = "nmrGuest";
            nmrGuest.Size = new Size(135, 43);
            nmrGuest.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 224);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(281, 37);
            label6.TabIndex = 3;
            label6.Text = "Oda Numarası Seçiniz:";
            // 
            // cmbRoomNumber
            // 
            cmbRoomNumber.FormattingEnabled = true;
            cmbRoomNumber.Location = new Point(366, 217);
            cmbRoomNumber.Margin = new Padding(6, 7, 6, 7);
            cmbRoomNumber.Name = "cmbRoomNumber";
            cmbRoomNumber.Size = new Size(458, 45);
            cmbRoomNumber.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 141);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(212, 37);
            label2.TabIndex = 3;
            label2.Text = "Oda Tipi Seçiniz:";
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(366, 133);
            cmbRoomType.Margin = new Padding(6, 7, 6, 7);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(458, 45);
            cmbRoomType.TabIndex = 2;
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            // 
            // cmbHotel
            // 
            cmbHotel.FormattingEnabled = true;
            cmbHotel.Location = new Point(366, 54);
            cmbHotel.Margin = new Padding(6, 7, 6, 7);
            cmbHotel.Name = "cmbHotel";
            cmbHotel.Size = new Size(458, 45);
            cmbHotel.TabIndex = 1;
            cmbHotel.SelectedIndexChanged += cmbHotel_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 62);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 0;
            label1.Text = "Otel Seçiniz:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgwRezervations);
            groupBox2.Location = new Point(26, 1006);
            groupBox2.Margin = new Padding(6, 7, 6, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 7, 6, 7);
            groupBox2.Size = new Size(1785, 486);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rezervasyonlar";
            // 
            // dgwRezervations
            // 
            dgwRezervations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwRezervations.Dock = DockStyle.Fill;
            dgwRezervations.Location = new Point(6, 43);
            dgwRezervations.Margin = new Padding(6, 7, 6, 7);
            dgwRezervations.Name = "dgwRezervations";
            dgwRezervations.RowHeadersWidth = 62;
            dgwRezervations.Size = new Size(1773, 436);
            dgwRezervations.TabIndex = 0;
            dgwRezervations.CellDoubleClick += dgwRezervations_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(26, 940);
            btnDelete.Margin = new Padding(6, 7, 6, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(161, 57);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(225, 940);
            btnUpdate.Margin = new Padding(6, 7, 6, 7);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(161, 57);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtRezervationsSearch
            // 
            txtRezervationsSearch.Location = new Point(789, 942);
            txtRezervationsSearch.Margin = new Padding(6, 7, 6, 7);
            txtRezervationsSearch.Name = "txtRezervationsSearch";
            txtRezervationsSearch.Size = new Size(377, 43);
            txtRezervationsSearch.TabIndex = 4;
            txtRezervationsSearch.TextChanged += txtRezervationsSearch_TextChanged;
            // 
            // Frm_Booking
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1830, 1522);
            Controls.Add(txtRezervationsSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(6, 7, 6, 7);
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
        private GroupBox groupBox2;
        private DataGridView dgwRezervations;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtRezervationsSearch;
        private Label label9;
        private ComboBox cmbPaymentMethod;
    }
}