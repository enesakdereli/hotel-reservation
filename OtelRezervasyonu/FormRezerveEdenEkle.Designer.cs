namespace OtelRezervasyonu
{
    partial class FormRezerveEdenEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRezerveEdenEkle));
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvRezerveEdenler = new System.Windows.Forms.DataGridView();
            this.lblTcKimlikNo = new System.Windows.Forms.Label();
            this.lblGirisTarihi2 = new System.Windows.Forms.Label();
            this.lblCikisTarihi2 = new System.Windows.Forms.Label();
            this.lblFiyat2 = new System.Windows.Forms.Label();
            this.lblSecilenOdaNo2 = new System.Windows.Forms.Label();
            this.btnRezervasyonuEkle = new System.Windows.Forms.Button();
            this.grpRezerveEdenEkle = new System.Windows.Forms.GroupBox();
            this.btnKilidiAc = new System.Windows.Forms.Button();
            this.pcbGuncelle = new System.Windows.Forms.PictureBox();
            this.pcbEkle = new System.Windows.Forms.PictureBox();
            this.txtTcKimlikNoFiltre = new System.Windows.Forms.TextBox();
            this.lblTcKimlikNoFiltre = new System.Windows.Forms.Label();
            this.grpRezervasyonBilgileri = new System.Windows.Forms.GroupBox();
            this.txtSecilenOda = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtCikisTarihi = new System.Windows.Forms.TextBox();
            this.txtGirisTarihi = new System.Windows.Forms.TextBox();
            this.pcbSil = new System.Windows.Forms.PictureBox();
            this.pcbTCFiltrele = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezerveEdenler)).BeginInit();
            this.grpRezerveEdenEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkle)).BeginInit();
            this.grpRezervasyonBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTCFiltrele)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAd.Location = new System.Drawing.Point(81, 57);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 15);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoyad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSoyad.Location = new System.Drawing.Point(63, 83);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(43, 15);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelefon.Location = new System.Drawing.Point(57, 109);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(49, 15);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(67, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcKimlikNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTcKimlikNo.Location = new System.Drawing.Point(112, 27);
            this.txtTcKimlikNo.MaxLength = 11;
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.ReadOnly = true;
            this.txtTcKimlikNo.Size = new System.Drawing.Size(121, 23);
            this.txtTcKimlikNo.TabIndex = 6;
            this.txtTcKimlikNo.TextChanged += new System.EventHandler(this.txtTcKimlikNo_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAd.Location = new System.Drawing.Point(112, 54);
            this.txtAd.MaxLength = 30;
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(121, 23);
            this.txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSoyad.Location = new System.Drawing.Point(112, 80);
            this.txtSoyad.MaxLength = 30;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.ReadOnly = true;
            this.txtSoyad.Size = new System.Drawing.Size(121, 23);
            this.txtSoyad.TabIndex = 8;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefon.Location = new System.Drawing.Point(112, 106);
            this.txtTelefon.MaxLength = 10;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(121, 23);
            this.txtTelefon.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Location = new System.Drawing.Point(112, 132);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(121, 23);
            this.txtEmail.TabIndex = 10;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEkle.Location = new System.Drawing.Point(87, 173);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(66, 39);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuncelle.Location = new System.Drawing.Point(214, 175);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(77, 39);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(437, 256);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 38);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Kişiyi Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvRezerveEdenler
            // 
            this.dgvRezerveEdenler.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRezerveEdenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezerveEdenler.Location = new System.Drawing.Point(12, 298);
            this.dgvRezerveEdenler.MultiSelect = false;
            this.dgvRezerveEdenler.Name = "dgvRezerveEdenler";
            this.dgvRezerveEdenler.ReadOnly = true;
            this.dgvRezerveEdenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezerveEdenler.Size = new System.Drawing.Size(551, 230);
            this.dgvRezerveEdenler.TabIndex = 5;
            this.dgvRezerveEdenler.Click += new System.EventHandler(this.DgvRezerveEdenler_Click);
            // 
            // lblTcKimlikNo
            // 
            this.lblTcKimlikNo.AutoSize = true;
            this.lblTcKimlikNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTcKimlikNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTcKimlikNo.Location = new System.Drawing.Point(22, 30);
            this.lblTcKimlikNo.Name = "lblTcKimlikNo";
            this.lblTcKimlikNo.Size = new System.Drawing.Size(84, 15);
            this.lblTcKimlikNo.TabIndex = 0;
            this.lblTcKimlikNo.Text = "T.C. Kimlik No:";
            // 
            // lblGirisTarihi2
            // 
            this.lblGirisTarihi2.AutoSize = true;
            this.lblGirisTarihi2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblGirisTarihi2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGirisTarihi2.Location = new System.Drawing.Point(40, 30);
            this.lblGirisTarihi2.Name = "lblGirisTarihi2";
            this.lblGirisTarihi2.Size = new System.Drawing.Size(65, 15);
            this.lblGirisTarihi2.TabIndex = 12;
            this.lblGirisTarihi2.Text = "Giriş Tarihi:";
            // 
            // lblCikisTarihi2
            // 
            this.lblCikisTarihi2.AutoSize = true;
            this.lblCikisTarihi2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCikisTarihi2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCikisTarihi2.Location = new System.Drawing.Point(40, 64);
            this.lblCikisTarihi2.Name = "lblCikisTarihi2";
            this.lblCikisTarihi2.Size = new System.Drawing.Size(66, 15);
            this.lblCikisTarihi2.TabIndex = 14;
            this.lblCikisTarihi2.Text = "Çıkış Tarihi:";
            // 
            // lblFiyat2
            // 
            this.lblFiyat2.AutoSize = true;
            this.lblFiyat2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiyat2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFiyat2.Location = new System.Drawing.Point(70, 96);
            this.lblFiyat2.Name = "lblFiyat2";
            this.lblFiyat2.Size = new System.Drawing.Size(35, 15);
            this.lblFiyat2.TabIndex = 13;
            this.lblFiyat2.Text = "Fiyat:";
            // 
            // lblSecilenOdaNo2
            // 
            this.lblSecilenOdaNo2.AutoSize = true;
            this.lblSecilenOdaNo2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecilenOdaNo2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSecilenOdaNo2.Location = new System.Drawing.Point(14, 128);
            this.lblSecilenOdaNo2.Name = "lblSecilenOdaNo2";
            this.lblSecilenOdaNo2.Size = new System.Drawing.Size(92, 15);
            this.lblSecilenOdaNo2.TabIndex = 13;
            this.lblSecilenOdaNo2.Text = "Seçilen Oda No:";
            // 
            // btnRezervasyonuEkle
            // 
            this.btnRezervasyonuEkle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyonuEkle.Location = new System.Drawing.Point(578, 485);
            this.btnRezervasyonuEkle.Name = "btnRezervasyonuEkle";
            this.btnRezervasyonuEkle.Size = new System.Drawing.Size(136, 43);
            this.btnRezervasyonuEkle.TabIndex = 15;
            this.btnRezervasyonuEkle.Text = "Rezervasyon İşlemine Devam Et";
            this.btnRezervasyonuEkle.UseVisualStyleBackColor = true;
            this.btnRezervasyonuEkle.Click += new System.EventHandler(this.btnRezervasyonuEkle_Click);
            // 
            // grpRezerveEdenEkle
            // 
            this.grpRezerveEdenEkle.Controls.Add(this.btnKilidiAc);
            this.grpRezerveEdenEkle.Controls.Add(this.lblTcKimlikNo);
            this.grpRezerveEdenEkle.Controls.Add(this.pcbGuncelle);
            this.grpRezerveEdenEkle.Controls.Add(this.pcbEkle);
            this.grpRezerveEdenEkle.Controls.Add(this.lblAd);
            this.grpRezerveEdenEkle.Controls.Add(this.lblSoyad);
            this.grpRezerveEdenEkle.Controls.Add(this.lblTelefon);
            this.grpRezerveEdenEkle.Controls.Add(this.lblEmail);
            this.grpRezerveEdenEkle.Controls.Add(this.txtTcKimlikNo);
            this.grpRezerveEdenEkle.Controls.Add(this.txtAd);
            this.grpRezerveEdenEkle.Controls.Add(this.txtSoyad);
            this.grpRezerveEdenEkle.Controls.Add(this.txtTelefon);
            this.grpRezerveEdenEkle.Controls.Add(this.txtEmail);
            this.grpRezerveEdenEkle.Controls.Add(this.btnEkle);
            this.grpRezerveEdenEkle.Controls.Add(this.btnGuncelle);
            this.grpRezerveEdenEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpRezerveEdenEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpRezerveEdenEkle.ForeColor = System.Drawing.Color.Maroon;
            this.grpRezerveEdenEkle.Location = new System.Drawing.Point(15, 12);
            this.grpRezerveEdenEkle.Name = "grpRezerveEdenEkle";
            this.grpRezerveEdenEkle.Size = new System.Drawing.Size(356, 229);
            this.grpRezerveEdenEkle.TabIndex = 16;
            this.grpRezerveEdenEkle.TabStop = false;
            this.grpRezerveEdenEkle.Text = "Rezerve Eden Ekle";
            // 
            // btnKilidiAc
            // 
            this.btnKilidiAc.FlatAppearance.BorderSize = 0;
            this.btnKilidiAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKilidiAc.ForeColor = System.Drawing.Color.Transparent;
            this.btnKilidiAc.Image = global::OtelRezervasyonu.Properties.Resources.Locked;
            this.btnKilidiAc.Location = new System.Drawing.Point(239, 120);
            this.btnKilidiAc.Name = "btnKilidiAc";
            this.btnKilidiAc.Size = new System.Drawing.Size(30, 35);
            this.btnKilidiAc.TabIndex = 20;
            this.btnKilidiAc.UseVisualStyleBackColor = false;
            this.btnKilidiAc.Click += new System.EventHandler(this.BtnKilidiAc_Click);
            // 
            // pcbGuncelle
            // 
            this.pcbGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("pcbGuncelle.Image")));
            this.pcbGuncelle.Location = new System.Drawing.Point(297, 175);
            this.pcbGuncelle.Name = "pcbGuncelle";
            this.pcbGuncelle.Size = new System.Drawing.Size(41, 39);
            this.pcbGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGuncelle.TabIndex = 19;
            this.pcbGuncelle.TabStop = false;
            // 
            // pcbEkle
            // 
            this.pcbEkle.Image = ((System.Drawing.Image)(resources.GetObject("pcbEkle.Image")));
            this.pcbEkle.Location = new System.Drawing.Point(159, 175);
            this.pcbEkle.Name = "pcbEkle";
            this.pcbEkle.Size = new System.Drawing.Size(38, 39);
            this.pcbEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEkle.TabIndex = 19;
            this.pcbEkle.TabStop = false;
            // 
            // txtTcKimlikNoFiltre
            // 
            this.txtTcKimlikNoFiltre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTcKimlikNoFiltre.Location = new System.Drawing.Point(102, 266);
            this.txtTcKimlikNoFiltre.Name = "txtTcKimlikNoFiltre";
            this.txtTcKimlikNoFiltre.Size = new System.Drawing.Size(121, 23);
            this.txtTcKimlikNoFiltre.TabIndex = 17;
            this.txtTcKimlikNoFiltre.TextChanged += new System.EventHandler(this.TxtTcKimlikNoFiltre_TextChanged);
            // 
            // lblTcKimlikNoFiltre
            // 
            this.lblTcKimlikNoFiltre.AutoSize = true;
            this.lblTcKimlikNoFiltre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTcKimlikNoFiltre.Location = new System.Drawing.Point(12, 268);
            this.lblTcKimlikNoFiltre.Name = "lblTcKimlikNoFiltre";
            this.lblTcKimlikNoFiltre.Size = new System.Drawing.Size(84, 15);
            this.lblTcKimlikNoFiltre.TabIndex = 18;
            this.lblTcKimlikNoFiltre.Text = "T.C. Kimlik No:";
            // 
            // grpRezervasyonBilgileri
            // 
            this.grpRezervasyonBilgileri.Controls.Add(this.txtSecilenOda);
            this.grpRezervasyonBilgileri.Controls.Add(this.txtFiyat);
            this.grpRezervasyonBilgileri.Controls.Add(this.txtCikisTarihi);
            this.grpRezervasyonBilgileri.Controls.Add(this.txtGirisTarihi);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblCikisTarihi2);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblGirisTarihi2);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblSecilenOdaNo2);
            this.grpRezervasyonBilgileri.Controls.Add(this.lblFiyat2);
            this.grpRezervasyonBilgileri.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpRezervasyonBilgileri.ForeColor = System.Drawing.Color.Maroon;
            this.grpRezervasyonBilgileri.Location = new System.Drawing.Point(377, 12);
            this.grpRezervasyonBilgileri.Name = "grpRezervasyonBilgileri";
            this.grpRezervasyonBilgileri.Size = new System.Drawing.Size(337, 229);
            this.grpRezervasyonBilgileri.TabIndex = 20;
            this.grpRezervasyonBilgileri.TabStop = false;
            this.grpRezervasyonBilgileri.Text = "Rezervasyon Bilgileri";
            // 
            // txtSecilenOda
            // 
            this.txtSecilenOda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecilenOda.Location = new System.Drawing.Point(111, 123);
            this.txtSecilenOda.Multiline = true;
            this.txtSecilenOda.Name = "txtSecilenOda";
            this.txtSecilenOda.ReadOnly = true;
            this.txtSecilenOda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSecilenOda.Size = new System.Drawing.Size(100, 66);
            this.txtSecilenOda.TabIndex = 0;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(111, 91);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.ReadOnly = true;
            this.txtFiyat.Size = new System.Drawing.Size(100, 25);
            this.txtFiyat.TabIndex = 1;
            // 
            // txtCikisTarihi
            // 
            this.txtCikisTarihi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCikisTarihi.Location = new System.Drawing.Point(111, 56);
            this.txtCikisTarihi.Name = "txtCikisTarihi";
            this.txtCikisTarihi.ReadOnly = true;
            this.txtCikisTarihi.Size = new System.Drawing.Size(100, 25);
            this.txtCikisTarihi.TabIndex = 2;
            // 
            // txtGirisTarihi
            // 
            this.txtGirisTarihi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisTarihi.Location = new System.Drawing.Point(111, 24);
            this.txtGirisTarihi.Name = "txtGirisTarihi";
            this.txtGirisTarihi.ReadOnly = true;
            this.txtGirisTarihi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGirisTarihi.Size = new System.Drawing.Size(100, 25);
            this.txtGirisTarihi.TabIndex = 3;
            // 
            // pcbSil
            // 
            this.pcbSil.Image = ((System.Drawing.Image)(resources.GetObject("pcbSil.Image")));
            this.pcbSil.Location = new System.Drawing.Point(523, 256);
            this.pcbSil.Name = "pcbSil";
            this.pcbSil.Size = new System.Drawing.Size(39, 36);
            this.pcbSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSil.TabIndex = 19;
            this.pcbSil.TabStop = false;
            // 
            // pcbTCFiltrele
            // 
            this.pcbTCFiltrele.Image = ((System.Drawing.Image)(resources.GetObject("pcbTCFiltrele.Image")));
            this.pcbTCFiltrele.Location = new System.Drawing.Point(229, 256);
            this.pcbTCFiltrele.Name = "pcbTCFiltrele";
            this.pcbTCFiltrele.Size = new System.Drawing.Size(31, 30);
            this.pcbTCFiltrele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbTCFiltrele.TabIndex = 19;
            this.pcbTCFiltrele.TabStop = false;
            // 
            // FormRezerveEdenEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(726, 540);
            this.Controls.Add(this.grpRezervasyonBilgileri);
            this.Controls.Add(this.pcbSil);
            this.Controls.Add(this.pcbTCFiltrele);
            this.Controls.Add(this.lblTcKimlikNoFiltre);
            this.Controls.Add(this.txtTcKimlikNoFiltre);
            this.Controls.Add(this.grpRezerveEdenEkle);
            this.Controls.Add(this.btnRezervasyonuEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvRezerveEdenler);
            this.Name = "FormRezerveEdenEkle";
            this.Text = "Rezerve Eden";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRezerveEdenEkle_FormClosing);
            this.Load += new System.EventHandler(this.FormRezerveEdenEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezerveEdenler)).EndInit();
            this.grpRezerveEdenEkle.ResumeLayout(false);
            this.grpRezerveEdenEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkle)).EndInit();
            this.grpRezervasyonBilgileri.ResumeLayout(false);
            this.grpRezervasyonBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTCFiltrele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvRezerveEdenler;
        private System.Windows.Forms.Label lblTcKimlikNo;
        private System.Windows.Forms.Label lblGirisTarihi2;
        private System.Windows.Forms.Label lblCikisTarihi2;
        private System.Windows.Forms.Label lblFiyat2;
        private System.Windows.Forms.Label lblSecilenOdaNo2;
        private System.Windows.Forms.Button btnRezervasyonuEkle;
        private System.Windows.Forms.GroupBox grpRezerveEdenEkle;
        private System.Windows.Forms.TextBox txtTcKimlikNoFiltre;
        private System.Windows.Forms.Label lblTcKimlikNoFiltre;
        private System.Windows.Forms.PictureBox pcbGuncelle;
        private System.Windows.Forms.PictureBox pcbEkle;
        private System.Windows.Forms.GroupBox grpRezervasyonBilgileri;
        private System.Windows.Forms.PictureBox pcbSil;
        private System.Windows.Forms.PictureBox pcbTCFiltrele;
        private System.Windows.Forms.TextBox txtGirisTarihi;
        private System.Windows.Forms.TextBox txtSecilenOda;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtCikisTarihi;
        private System.Windows.Forms.Button btnKilidiAc;
    }
}