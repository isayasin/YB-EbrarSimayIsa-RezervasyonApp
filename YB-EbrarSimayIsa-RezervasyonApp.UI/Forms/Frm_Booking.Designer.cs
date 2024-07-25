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
            btnGuestDelete = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrGuest).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwRezervations).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnGuestDelete);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(833, 363);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervasyon işlemleri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(516, 19);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 17;
            label9.Text = "Misafir Listesi";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(171, 284);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(216, 23);
            cmbPaymentMethod.TabIndex = 16;
            cmbPaymentMethod.SelectedIndexChanged += cmbPaymentMethod_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 287);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 15;
            label8.Text = "Ödeme Yöntemi:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(225, 246);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(19, 15);
            lblAmount.TabIndex = 14;
            lblAmount.Text = "$$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(140, 246);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 13;
            label7.Text = "Toplam Tutar:";
            // 
            // lstGuests
            // 
            lstGuests.FormattingEnabled = true;
            lstGuests.ItemHeight = 15;
            lstGuests.Location = new Point(506, 47);
            lstGuests.Name = "lstGuests";
            lstGuests.Size = new Size(299, 214);
            lstGuests.TabIndex = 12;
            lstGuests.DoubleClick += lstGuests_DoubleClick;
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
            btnKaydet.Location = new Point(247, 324);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(140, 23);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Rezervasyon Oluştur";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(266, 193);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(121, 23);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 199);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 8;
            label5.Text = "Çıkış Tarihi:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(266, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 168);
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
            nmrGuest.ValueChanged += nmrGuest_ValueChanged;
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
            cmbRoomNumber.Size = new Size(216, 23);
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
            cmbRoomType.Size = new Size(216, 23);
            cmbRoomType.TabIndex = 2;
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            // 
            // cmbHotel
            // 
            cmbHotel.FormattingEnabled = true;
            cmbHotel.Location = new Point(171, 22);
            cmbHotel.Name = "cmbHotel";
            cmbHotel.Size = new Size(216, 23);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(dgwRezervations);
            groupBox2.Location = new Point(12, 408);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(833, 197);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rezervasyonlar";
            // 
            // dgwRezervations
            // 
            dgwRezervations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwRezervations.Dock = DockStyle.Fill;
            dgwRezervations.Location = new Point(3, 19);
            dgwRezervations.Name = "dgwRezervations";
            dgwRezervations.RowHeadersWidth = 62;
            dgwRezervations.Size = new Size(827, 175);
            dgwRezervations.TabIndex = 0;
            dgwRezervations.CellDoubleClick += dgwRezervations_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 381);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Rezervasyon Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(152, 381);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtRezervationsSearch
            // 
            txtRezervationsSearch.Location = new Point(368, 382);
            txtRezervationsSearch.Name = "txtRezervationsSearch";
            txtRezervationsSearch.Size = new Size(178, 23);
            txtRezervationsSearch.TabIndex = 4;
            txtRezervationsSearch.TextChanged += txtRezervationsSearch_TextChanged;
            // 
            // btnGuestDelete
            // 
            btnGuestDelete.Location = new Point(506, 279);
            btnGuestDelete.Name = "btnGuestDelete";
            btnGuestDelete.Size = new Size(75, 23);
            btnGuestDelete.TabIndex = 18;
            btnGuestDelete.Text = "Misafiri Sil";
            btnGuestDelete.UseVisualStyleBackColor = true;
            // 
            // Frm_Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(854, 616);
            Controls.Add(txtRezervationsSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
        private Button btnGuestDelete;
    }
}