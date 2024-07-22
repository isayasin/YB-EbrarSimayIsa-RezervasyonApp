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
            dtDogumTarihi = new DateTimePicker();
            label5 = new Label();
            groupBox2 = new GroupBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            btnMisafirEkle = new Button();
            txtAdres = new TextBox();
            label14 = new Label();
            txtMisafirSoyad = new TextBox();
            label13 = new Label();
            txtMisafirAd = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            cmbOtel = new ComboBox();
            cmbOdaTipi = new ComboBox();
            label15 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label2 = new Label();
            dtGiriş = new DateTimePicker();
            nmrMisafirSayısı = new NumericUpDown();
            dtÇıkış = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            btnKaydet = new Button();
            label9 = new Label();
            cmbÖdeme = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            label16 = new Label();
            dgwRezervasyon = new DataGridView();
            txtRezervasyonSahibi = new TextBox();
            btnSil = new Button();
            btnListele = new Button();
            btnGüncelle = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMisafirSayısı).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwRezervasyon).BeginInit();
            SuspendLayout();
            // 
            // dtDogumTarihi
            // 
            dtDogumTarihi.Location = new Point(111, 185);
            dtDogumTarihi.Name = "dtDogumTarihi";
            dtDogumTarihi.Size = new Size(189, 23);
            dtDogumTarihi.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 318);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 1;
            label5.Text = "Doğum Tarihi:";
            label5.Click += label5_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTelefon);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(btnMisafirEkle);
            groupBox2.Controls.Add(txtAdres);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtMisafirSoyad);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(dtDogumTarihi);
            groupBox2.Controls.Add(txtMisafirAd);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(613, 25);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(484, 478);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Misafir Bilgileri";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(200, 151);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnMisafirEkle
            // 
            btnMisafirEkle.Location = new Point(225, 221);
            btnMisafirEkle.Name = "btnMisafirEkle";
            btnMisafirEkle.Size = new Size(75, 23);
            btnMisafirEkle.TabIndex = 6;
            btnMisafirEkle.Text = "Misafir Ekle";
            btnMisafirEkle.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(200, 93);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(100, 23);
            txtAdres.TabIndex = 1;
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
            // txtMisafirSoyad
            // 
            txtMisafirSoyad.Location = new Point(200, 58);
            txtMisafirSoyad.Name = "txtMisafirSoyad";
            txtMisafirSoyad.Size = new Size(100, 23);
            txtMisafirSoyad.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 203);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(54, 25);
            label13.TabIndex = 0;
            label13.Text = "Email";
            // 
            // txtMisafirAd
            // 
            txtMisafirAd.Location = new Point(200, 26);
            txtMisafirAd.Name = "txtMisafirAd";
            txtMisafirAd.Size = new Size(100, 23);
            txtMisafirAd.TabIndex = 1;
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
            // cmbOtel
            // 
            cmbOtel.FormattingEnabled = true;
            cmbOtel.Location = new Point(120, 26);
            cmbOtel.Name = "cmbOtel";
            cmbOtel.Size = new Size(121, 23);
            cmbOtel.TabIndex = 0;
            // 
            // cmbOdaTipi
            // 
            cmbOdaTipi.FormattingEnabled = true;
            cmbOdaTipi.Location = new Point(120, 55);
            cmbOdaTipi.Name = "cmbOdaTipi";
            cmbOdaTipi.Size = new Size(121, 23);
            cmbOdaTipi.TabIndex = 0;
            cmbOdaTipi.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(30, 265);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(113, 25);
            label15.TabIndex = 1;
            label15.Text = "Giriş Tarihiniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "Otel Seçiniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 1;
            label3.Text = "Oda Tipi Seçiniz:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 160);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 25);
            label4.TabIndex = 1;
            label4.Text = "Misafir Sayı Seçiniz:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 318);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 1;
            label6.Text = "Çıkış Tarihiniz";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 38);
            label2.TabIndex = 0;
            label2.Text = "Rezervasyon";
            // 
            // dtGiriş
            // 
            dtGiriş.Location = new Point(117, 153);
            dtGiriş.Name = "dtGiriş";
            dtGiriş.Size = new Size(189, 23);
            dtGiriş.TabIndex = 3;
            // 
            // nmrMisafirSayısı
            // 
            nmrMisafirSayısı.Location = new Point(169, 88);
            nmrMisafirSayısı.Name = "nmrMisafirSayısı";
            nmrMisafirSayısı.Size = new Size(72, 23);
            nmrMisafirSayısı.TabIndex = 2;
            // 
            // dtÇıkış
            // 
            dtÇıkış.Location = new Point(117, 185);
            dtÇıkış.Name = "dtÇıkış";
            dtÇıkış.Size = new Size(190, 23);
            dtÇıkış.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(369, 105);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 4;
            label7.Text = "Fiyat Bilgisi:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(471, 105);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(32, 25);
            label8.TabIndex = 5;
            label8.Text = "$$";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(307, 217);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 375);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(166, 25);
            label9.TabIndex = 7;
            label9.Text = "Ödeme Yönteminiz:";
            // 
            // cmbÖdeme
            // 
            cmbÖdeme.FormattingEnabled = true;
            cmbÖdeme.Location = new Point(138, 217);
            cmbÖdeme.Name = "cmbÖdeme";
            cmbÖdeme.Size = new Size(121, 23);
            cmbÖdeme.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbÖdeme);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtÇıkış);
            groupBox1.Controls.Add(nmrMisafirSayısı);
            groupBox1.Controls.Add(dtGiriş);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(cmbOdaTipi);
            groupBox1.Controls.Add(cmbOtel);
            groupBox1.Location = new Point(21, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(554, 478);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervasyon";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(dgwRezervasyon);
            groupBox3.Controls.Add(txtRezervasyonSahibi);
            groupBox3.Location = new Point(21, 353);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(1067, 470);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rezervasyonlar";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 40);
            label16.Name = "label16";
            label16.Size = new Size(110, 15);
            label16.TabIndex = 6;
            label16.Text = "Rezervasyon Sahibi:";
            label16.Click += label16_Click;
            // 
            // dgwRezervasyon
            // 
            dgwRezervasyon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwRezervasyon.Location = new Point(21, 72);
            dgwRezervasyon.Name = "dgwRezervasyon";
            dgwRezervasyon.Size = new Size(710, 192);
            dgwRezervasyon.TabIndex = 0;
            // 
            // txtRezervasyonSahibi
            // 
            txtRezervasyonSahibi.Location = new Point(122, 32);
            txtRezervasyonSahibi.Name = "txtRezervasyonSahibi";
            txtRezervasyonSahibi.Size = new Size(100, 23);
            txtRezervasyonSahibi.TabIndex = 4;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(21, 316);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(102, 316);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(75, 23);
            btnListele.TabIndex = 3;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(183, 316);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(75, 23);
            btnGüncelle.TabIndex = 3;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // Frm_Booking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 647);
            Controls.Add(btnGüncelle);
            Controls.Add(btnListele);
            Controls.Add(btnSil);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Frm_Booking";
            Text = "Frm_Booking";
            Load += Frm_Booking_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMisafirSayısı).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwRezervasyon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dtDogumTarihi;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private Label label14;
        private TextBox txtMisafirSoyad;
        private Label label13;
        private TextBox txtMisafirAd;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btnMisafirEkle;
        private ComboBox cmbOtel;
        private ComboBox cmbOdaTipi;
        private Label label15;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label2;
        private DateTimePicker dtGiriş;
        private NumericUpDown nmrMisafirSayısı;
        private DateTimePicker dtÇıkış;
        private Label label7;
        private Label label8;
        private Button btnKaydet;
        private Label label9;
        private ComboBox cmbÖdeme;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DataGridView dgwRezervasyon;
        private Button btnSil;
        private Button btnListele;
        private Button btnGüncelle;
        private TextBox txtRezervasyonSahibi;
        private Label label16;
    }
}