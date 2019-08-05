namespace OtelRezervasyonu
{
    partial class FormOdaSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOdaSec));
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbOdaTuru = new System.Windows.Forms.ComboBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblOdaKapasitesi = new System.Windows.Forms.Label();
            this.lblGunSayisi = new System.Windows.Forms.Label();
            this.btnRezervasyonaDevamEt = new System.Windows.Forms.Button();
            this.lboxSecilenOdalar = new System.Windows.Forms.ListBox();
            this.lblOdaTuru = new System.Windows.Forms.Label();
            this.lblGirisTarihi = new System.Windows.Forms.Label();
            this.lblCikisTarihi = new System.Windows.Forms.Label();
            this.dgvBosOdalar = new System.Windows.Forms.DataGridView();
            this.dgvDoluOdalar = new System.Windows.Forms.DataGridView();
            this.cmbOdaKapasitesi = new System.Windows.Forms.ComboBox();
            this.btnTumBosOdalar = new System.Windows.Forms.Button();
            this.btnListeyiTemizle = new System.Windows.Forms.Button();
            this.pcbGirisTarihi = new System.Windows.Forms.PictureBox();
            this.pcbCikisTarihi = new System.Windows.Forms.PictureBox();
            this.lblToplamKisiSayisi = new System.Windows.Forms.Label();
            this.lblToplamKapasite = new System.Windows.Forms.Label();
            this.txtGunSayisi = new System.Windows.Forms.TextBox();
            this.txtToplamOdaKapasitesi = new System.Windows.Forms.TextBox();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.txtToplamKisiSayisi = new System.Windows.Forms.TextBox();
            this.lblBosOdalar = new System.Windows.Forms.Label();
            this.lblDoluOdalar = new System.Windows.Forms.Label();
            this.btnSecilenOdayiAktar = new System.Windows.Forms.Button();
            this.lbldolular = new System.Windows.Forms.Label();
            this.ldlBosodalar = new System.Windows.Forms.Label();
            this.btnSecilenOdayiEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBosOdalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoluOdalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGirisTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCikisTarihi)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Location = new System.Drawing.Point(144, 67);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(170, 20);
            this.DtpCikisTarihi.TabIndex = 1;
            this.DtpCikisTarihi.ValueChanged += new System.EventHandler(this.DtpCikisTarihi_ValueChanged);
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Location = new System.Drawing.Point(144, 23);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(170, 20);
            this.DtpGirisTarihi.TabIndex = 1;
            this.DtpGirisTarihi.ValueChanged += new System.EventHandler(this.DtpGirisTarihi_ValueChanged);
            // 
            // cmbOdaTuru
            // 
            this.cmbOdaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdaTuru.FormattingEnabled = true;
            this.cmbOdaTuru.Location = new System.Drawing.Point(144, 103);
            this.cmbOdaTuru.Name = "cmbOdaTuru";
            this.cmbOdaTuru.Size = new System.Drawing.Size(135, 21);
            this.cmbOdaTuru.TabIndex = 2;
            this.cmbOdaTuru.SelectedIndexChanged += new System.EventHandler(this.CmbOdaTuru_SelectedIndexChanged);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiyat.ForeColor = System.Drawing.Color.Black;
            this.lblFiyat.Location = new System.Drawing.Point(398, 57);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(78, 15);
            this.lblFiyat.TabIndex = 3;
            this.lblFiyat.Text = "Toplam Fiyat:";
            // 
            // lblOdaKapasitesi
            // 
            this.lblOdaKapasitesi.AutoSize = true;
            this.lblOdaKapasitesi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblOdaKapasitesi.ForeColor = System.Drawing.Color.Black;
            this.lblOdaKapasitesi.Location = new System.Drawing.Point(51, 149);
            this.lblOdaKapasitesi.Name = "lblOdaKapasitesi";
            this.lblOdaKapasitesi.Size = new System.Drawing.Size(87, 15);
            this.lblOdaKapasitesi.TabIndex = 3;
            this.lblOdaKapasitesi.Text = "Oda Kapasitesi:";
            // 
            // lblGunSayisi
            // 
            this.lblGunSayisi.AutoSize = true;
            this.lblGunSayisi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblGunSayisi.ForeColor = System.Drawing.Color.Black;
            this.lblGunSayisi.Location = new System.Drawing.Point(411, 13);
            this.lblGunSayisi.Name = "lblGunSayisi";
            this.lblGunSayisi.Size = new System.Drawing.Size(65, 15);
            this.lblGunSayisi.TabIndex = 3;
            this.lblGunSayisi.Text = "Gün Sayısı:";
            // 
            // btnRezervasyonaDevamEt
            // 
            this.btnRezervasyonaDevamEt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyonaDevamEt.ForeColor = System.Drawing.Color.Black;
            this.btnRezervasyonaDevamEt.Location = new System.Drawing.Point(611, 576);
            this.btnRezervasyonaDevamEt.Name = "btnRezervasyonaDevamEt";
            this.btnRezervasyonaDevamEt.Size = new System.Drawing.Size(130, 41);
            this.btnRezervasyonaDevamEt.TabIndex = 4;
            this.btnRezervasyonaDevamEt.Text = "Rezervasyon İşlemine Devam Et";
            this.btnRezervasyonaDevamEt.UseVisualStyleBackColor = true;
            this.btnRezervasyonaDevamEt.Click += new System.EventHandler(this.btnRezervasyonaDevamEt_Click);
            // 
            // lboxSecilenOdalar
            // 
            this.lboxSecilenOdalar.FormattingEnabled = true;
            this.lboxSecilenOdalar.Location = new System.Drawing.Point(646, 204);
            this.lboxSecilenOdalar.Name = "lboxSecilenOdalar";
            this.lboxSecilenOdalar.Size = new System.Drawing.Size(95, 264);
            this.lboxSecilenOdalar.TabIndex = 6;
            // 
            // lblOdaTuru
            // 
            this.lblOdaTuru.AutoSize = true;
            this.lblOdaTuru.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdaTuru.ForeColor = System.Drawing.Color.Black;
            this.lblOdaTuru.Location = new System.Drawing.Point(79, 106);
            this.lblOdaTuru.Name = "lblOdaTuru";
            this.lblOdaTuru.Size = new System.Drawing.Size(59, 15);
            this.lblOdaTuru.TabIndex = 7;
            this.lblOdaTuru.Text = "Oda Türü:";
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.AutoSize = true;
            this.lblGirisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblGirisTarihi.ForeColor = System.Drawing.Color.Black;
            this.lblGirisTarihi.Location = new System.Drawing.Point(70, 23);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(68, 15);
            this.lblGirisTarihi.TabIndex = 8;
            this.lblGirisTarihi.Text = "Giriş Tarihi :";
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.AutoSize = true;
            this.lblCikisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCikisTarihi.ForeColor = System.Drawing.Color.Black;
            this.lblCikisTarihi.Location = new System.Drawing.Point(69, 67);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(69, 15);
            this.lblCikisTarihi.TabIndex = 8;
            this.lblCikisTarihi.Text = "Çıkış Tarihi :";
            // 
            // dgvBosOdalar
            // 
            this.dgvBosOdalar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBosOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBosOdalar.Location = new System.Drawing.Point(12, 204);
            this.dgvBosOdalar.MultiSelect = false;
            this.dgvBosOdalar.Name = "dgvBosOdalar";
            this.dgvBosOdalar.ReadOnly = true;
            this.dgvBosOdalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBosOdalar.Size = new System.Drawing.Size(615, 155);
            this.dgvBosOdalar.TabIndex = 9;
            this.dgvBosOdalar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBosOdalar_CellDoubleClick);
            // 
            // dgvDoluOdalar
            // 
            this.dgvDoluOdalar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDoluOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoluOdalar.Location = new System.Drawing.Point(12, 392);
            this.dgvDoluOdalar.Name = "dgvDoluOdalar";
            this.dgvDoluOdalar.Size = new System.Drawing.Size(615, 141);
            this.dgvDoluOdalar.TabIndex = 9;
            // 
            // cmbOdaKapasitesi
            // 
            this.cmbOdaKapasitesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdaKapasitesi.FormattingEnabled = true;
            this.cmbOdaKapasitesi.Location = new System.Drawing.Point(145, 145);
            this.cmbOdaKapasitesi.Name = "cmbOdaKapasitesi";
            this.cmbOdaKapasitesi.Size = new System.Drawing.Size(134, 21);
            this.cmbOdaKapasitesi.TabIndex = 2;
            this.cmbOdaKapasitesi.SelectedIndexChanged += new System.EventHandler(this.cmbOdaKapasitesi_SelectedIndexChanged);
            // 
            // btnTumBosOdalar
            // 
            this.btnTumBosOdalar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnTumBosOdalar.ForeColor = System.Drawing.Color.Black;
            this.btnTumBosOdalar.Location = new System.Drawing.Point(611, 57);
            this.btnTumBosOdalar.Name = "btnTumBosOdalar";
            this.btnTumBosOdalar.Size = new System.Drawing.Size(142, 39);
            this.btnTumBosOdalar.TabIndex = 10;
            this.btnTumBosOdalar.Text = "Tüm Boş Odaları Göster";
            this.btnTumBosOdalar.UseVisualStyleBackColor = true;
            this.btnTumBosOdalar.Click += new System.EventHandler(this.btnTumBosOdalar_Click);
            // 
            // btnListeyiTemizle
            // 
            this.btnListeyiTemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnListeyiTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnListeyiTemizle.Location = new System.Drawing.Point(646, 501);
            this.btnListeyiTemizle.Name = "btnListeyiTemizle";
            this.btnListeyiTemizle.Size = new System.Drawing.Size(95, 32);
            this.btnListeyiTemizle.TabIndex = 11;
            this.btnListeyiTemizle.Text = "Listeyi Temizle";
            this.btnListeyiTemizle.UseVisualStyleBackColor = true;
            this.btnListeyiTemizle.Click += new System.EventHandler(this.btnListeyiTemizle_Click);
            // 
            // pcbGirisTarihi
            // 
            this.pcbGirisTarihi.Image = ((System.Drawing.Image)(resources.GetObject("pcbGirisTarihi.Image")));
            this.pcbGirisTarihi.Location = new System.Drawing.Point(12, 12);
            this.pcbGirisTarihi.Name = "pcbGirisTarihi";
            this.pcbGirisTarihi.Size = new System.Drawing.Size(52, 36);
            this.pcbGirisTarihi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGirisTarihi.TabIndex = 12;
            this.pcbGirisTarihi.TabStop = false;
            // 
            // pcbCikisTarihi
            // 
            this.pcbCikisTarihi.Image = ((System.Drawing.Image)(resources.GetObject("pcbCikisTarihi.Image")));
            this.pcbCikisTarihi.Location = new System.Drawing.Point(12, 57);
            this.pcbCikisTarihi.Name = "pcbCikisTarihi";
            this.pcbCikisTarihi.Size = new System.Drawing.Size(52, 36);
            this.pcbCikisTarihi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCikisTarihi.TabIndex = 12;
            this.pcbCikisTarihi.TabStop = false;
            // 
            // lblToplamKisiSayisi
            // 
            this.lblToplamKisiSayisi.AutoSize = true;
            this.lblToplamKisiSayisi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblToplamKisiSayisi.ForeColor = System.Drawing.Color.Black;
            this.lblToplamKisiSayisi.Location = new System.Drawing.Point(369, 146);
            this.lblToplamKisiSayisi.Name = "lblToplamKisiSayisi";
            this.lblToplamKisiSayisi.Size = new System.Drawing.Size(107, 15);
            this.lblToplamKisiSayisi.TabIndex = 13;
            this.lblToplamKisiSayisi.Text = "Toplam Kişi Sayısı :";
            // 
            // lblToplamKapasite
            // 
            this.lblToplamKapasite.AutoSize = true;
            this.lblToplamKapasite.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblToplamKapasite.ForeColor = System.Drawing.Color.Black;
            this.lblToplamKapasite.Location = new System.Drawing.Point(343, 103);
            this.lblToplamKapasite.Name = "lblToplamKapasite";
            this.lblToplamKapasite.Size = new System.Drawing.Size(133, 15);
            this.lblToplamKapasite.TabIndex = 13;
            this.lblToplamKapasite.Text = "Toplam Oda Kapasitesi :";
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.Location = new System.Drawing.Point(482, 9);
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.ReadOnly = true;
            this.txtGunSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtGunSayisi.TabIndex = 14;
            // 
            // txtToplamOdaKapasitesi
            // 
            this.txtToplamOdaKapasitesi.Location = new System.Drawing.Point(482, 101);
            this.txtToplamOdaKapasitesi.Name = "txtToplamOdaKapasitesi";
            this.txtToplamOdaKapasitesi.ReadOnly = true;
            this.txtToplamOdaKapasitesi.Size = new System.Drawing.Size(100, 20);
            this.txtToplamOdaKapasitesi.TabIndex = 14;
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(482, 55);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.ReadOnly = true;
            this.txtToplamFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtToplamFiyat.TabIndex = 14;
            // 
            // txtToplamKisiSayisi
            // 
            this.txtToplamKisiSayisi.Location = new System.Drawing.Point(482, 144);
            this.txtToplamKisiSayisi.Name = "txtToplamKisiSayisi";
            this.txtToplamKisiSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtToplamKisiSayisi.TabIndex = 14;
            this.txtToplamKisiSayisi.Leave += new System.EventHandler(this.txtToplamKisiSayisi_Leave);
            // 
            // lblBosOdalar
            // 
            this.lblBosOdalar.AutoSize = true;
            this.lblBosOdalar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBosOdalar.Location = new System.Drawing.Point(159, 566);
            this.lblBosOdalar.Name = "lblBosOdalar";
            this.lblBosOdalar.Size = new System.Drawing.Size(65, 15);
            this.lblBosOdalar.TabIndex = 15;
            this.lblBosOdalar.Text = "Boş Odalar";
            // 
            // lblDoluOdalar
            // 
            this.lblDoluOdalar.AutoSize = true;
            this.lblDoluOdalar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDoluOdalar.Location = new System.Drawing.Point(159, 566);
            this.lblDoluOdalar.Name = "lblDoluOdalar";
            this.lblDoluOdalar.Size = new System.Drawing.Size(71, 15);
            this.lblDoluOdalar.TabIndex = 15;
            this.lblDoluOdalar.Text = "Dolu Odalar";
            // 
            // btnSecilenOdayiAktar
            // 
            this.btnSecilenOdayiAktar.Location = new System.Drawing.Point(159, 566);
            this.btnSecilenOdayiAktar.Name = "btnSecilenOdayiAktar";
            this.btnSecilenOdayiAktar.Size = new System.Drawing.Size(139, 48);
            this.btnSecilenOdayiAktar.TabIndex = 16;
            this.btnSecilenOdayiAktar.Text = "Seçilen Odayı Aktar";
            this.btnSecilenOdayiAktar.UseVisualStyleBackColor = true;
            this.btnSecilenOdayiAktar.Click += new System.EventHandler(this.btnSecilenOdayiAktar_Click);
            // 
            // lbldolular
            // 
            this.lbldolular.AutoSize = true;
            this.lbldolular.Location = new System.Drawing.Point(297, 376);
            this.lbldolular.Name = "lbldolular";
            this.lbldolular.Size = new System.Drawing.Size(63, 13);
            this.lbldolular.TabIndex = 15;
            this.lbldolular.Text = "Dolu Odalar";
            // 
            // ldlBosodalar
            // 
            this.ldlBosodalar.AutoSize = true;
            this.ldlBosodalar.Location = new System.Drawing.Point(297, 188);
            this.ldlBosodalar.Name = "ldlBosodalar";
            this.ldlBosodalar.Size = new System.Drawing.Size(59, 13);
            this.ldlBosodalar.TabIndex = 15;
            this.ldlBosodalar.Text = "Boş Odalar";
            // 
            // btnSecilenOdayiEkle
            // 
            this.btnSecilenOdayiEkle.Location = new System.Drawing.Point(262, 576);
            this.btnSecilenOdayiEkle.Name = "btnSecilenOdayiEkle";
            this.btnSecilenOdayiEkle.Size = new System.Drawing.Size(125, 41);
            this.btnSecilenOdayiEkle.TabIndex = 16;
            this.btnSecilenOdayiEkle.Text = "Seçilen Odayı Ekle";
            this.btnSecilenOdayiEkle.UseVisualStyleBackColor = true;
            this.btnSecilenOdayiEkle.Click += new System.EventHandler(this.btnSecilenOdayiEkle_Click);
            // 
            // FormOdaSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(765, 629);
            this.Controls.Add(this.btnSecilenOdayiEkle);
            this.Controls.Add(this.ldlBosodalar);
            this.Controls.Add(this.lbldolular);
            this.Controls.Add(this.txtToplamKisiSayisi);
            this.Controls.Add(this.txtToplamOdaKapasitesi);
            this.Controls.Add(this.txtToplamFiyat);
            this.Controls.Add(this.txtGunSayisi);
            this.Controls.Add(this.lblToplamKapasite);
            this.Controls.Add(this.lblToplamKisiSayisi);
            this.Controls.Add(this.pcbCikisTarihi);
            this.Controls.Add(this.pcbGirisTarihi);
            this.Controls.Add(this.btnListeyiTemizle);
            this.Controls.Add(this.btnTumBosOdalar);
            this.Controls.Add(this.dgvDoluOdalar);
            this.Controls.Add(this.dgvBosOdalar);
            this.Controls.Add(this.lblCikisTarihi);
            this.Controls.Add(this.lblGirisTarihi);
            this.Controls.Add(this.lblOdaTuru);
            this.Controls.Add(this.lboxSecilenOdalar);
            this.Controls.Add(this.btnRezervasyonaDevamEt);
            this.Controls.Add(this.lblOdaKapasitesi);
            this.Controls.Add(this.lblGunSayisi);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.cmbOdaKapasitesi);
            this.Controls.Add(this.cmbOdaTuru);
            this.Controls.Add(this.DtpGirisTarihi);
            this.Controls.Add(this.DtpCikisTarihi);
            this.Name = "FormOdaSec";
            this.Text = "FormOdaSec";
            this.Load += new System.EventHandler(this.FormOdaSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBosOdalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoluOdalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGirisTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCikisTarihi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.ComboBox cmbOdaTuru;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblOdaKapasitesi;
        private System.Windows.Forms.Label lblGunSayisi;
        private System.Windows.Forms.Button btnRezervasyonaDevamEt;
        private System.Windows.Forms.ListBox lboxSecilenOdalar;
        private System.Windows.Forms.Label lblOdaTuru;
        private System.Windows.Forms.Label lblGirisTarihi;
        private System.Windows.Forms.Label lblCikisTarihi;
        private System.Windows.Forms.DataGridView dgvBosOdalar;
        private System.Windows.Forms.DataGridView dgvDoluOdalar;
        private System.Windows.Forms.ComboBox cmbOdaKapasitesi;
        private System.Windows.Forms.Button btnTumBosOdalar;
        private System.Windows.Forms.Button btnListeyiTemizle;
        private System.Windows.Forms.PictureBox pcbGirisTarihi;
        private System.Windows.Forms.PictureBox pcbCikisTarihi;
        private System.Windows.Forms.Label lblToplamKisiSayisi;
        private System.Windows.Forms.Label lblToplamKapasite;
        private System.Windows.Forms.TextBox txtGunSayisi;
        private System.Windows.Forms.TextBox txtToplamOdaKapasitesi;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.TextBox txtToplamKisiSayisi;
        private System.Windows.Forms.Label lblBosOdalar;
        private System.Windows.Forms.Label lblDoluOdalar;
        private System.Windows.Forms.Button btnSecilenOdayiAktar;
        private System.Windows.Forms.Label lbldolular;
        private System.Windows.Forms.Label ldlBosodalar;
        private System.Windows.Forms.Button btnSecilenOdayiEkle;
    }
}