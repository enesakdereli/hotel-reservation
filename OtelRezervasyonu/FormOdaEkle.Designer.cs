namespace OtelRezervasyonu
{
    partial class FormOdaEkle
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
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.cmbOdaKapasitesi = new System.Windows.Forms.ComboBox();
            this.cmbOdaTuru = new System.Windows.Forms.ComboBox();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.lblOdaTuru = new System.Windows.Forms.Label();
            this.lblOdaKapasitesi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnFiltreyiSifirla = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvOdaListesi = new System.Windows.Forms.DataGridView();
            this.txtOdaFiyati = new System.Windows.Forms.TextBox();
            this.lblOdaFiyati = new System.Windows.Forms.Label();
            this.btnFiltrele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdaListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(73, 24);
            this.txtOdaNo.MaxLength = 3;
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(112, 20);
            this.txtOdaNo.TabIndex = 1;
            this.txtOdaNo.TextChanged += new System.EventHandler(this.txtOdaNo_TextChanged);
            // 
            // cmbOdaKapasitesi
            // 
            this.cmbOdaKapasitesi.FormattingEnabled = true;
            this.cmbOdaKapasitesi.Location = new System.Drawing.Point(485, 25);
            this.cmbOdaKapasitesi.Name = "cmbOdaKapasitesi";
            this.cmbOdaKapasitesi.Size = new System.Drawing.Size(112, 21);
            this.cmbOdaKapasitesi.TabIndex = 3;
            this.cmbOdaKapasitesi.SelectedIndexChanged += new System.EventHandler(this.cmbOdaKapasitesi_SelectedIndexChanged);
            // 
            // cmbOdaTuru
            // 
            this.cmbOdaTuru.FormattingEnabled = true;
            this.cmbOdaTuru.Location = new System.Drawing.Point(258, 24);
            this.cmbOdaTuru.Name = "cmbOdaTuru";
            this.cmbOdaTuru.Size = new System.Drawing.Size(112, 21);
            this.cmbOdaTuru.TabIndex = 3;
            this.cmbOdaTuru.SelectedIndexChanged += new System.EventHandler(this.cmbOdaTuru_SelectedIndexChanged);
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.BackColor = System.Drawing.Color.SeaShell;
            this.lblOdaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblOdaNo.Location = new System.Drawing.Point(12, 24);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(54, 15);
            this.lblOdaNo.TabIndex = 5;
            this.lblOdaNo.Text = " Oda No:";
            // 
            // lblOdaTuru
            // 
            this.lblOdaTuru.AutoSize = true;
            this.lblOdaTuru.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblOdaTuru.Location = new System.Drawing.Point(192, 24);
            this.lblOdaTuru.Name = "lblOdaTuru";
            this.lblOdaTuru.Size = new System.Drawing.Size(59, 15);
            this.lblOdaTuru.TabIndex = 6;
            this.lblOdaTuru.Text = "Oda Türü:";
            // 
            // lblOdaKapasitesi
            // 
            this.lblOdaKapasitesi.AutoSize = true;
            this.lblOdaKapasitesi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblOdaKapasitesi.Location = new System.Drawing.Point(389, 25);
            this.lblOdaKapasitesi.Name = "lblOdaKapasitesi";
            this.lblOdaKapasitesi.Size = new System.Drawing.Size(87, 15);
            this.lblOdaKapasitesi.TabIndex = 7;
            this.lblOdaKapasitesi.Text = "Oda Kapasitesi:";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Location = new System.Drawing.Point(376, 74);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(107, 43);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnFiltreyiSifirla
            // 
            this.btnFiltreyiSifirla.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnFiltreyiSifirla.Location = new System.Drawing.Point(661, 74);
            this.btnFiltreyiSifirla.Name = "btnFiltreyiSifirla";
            this.btnFiltreyiSifirla.Size = new System.Drawing.Size(107, 43);
            this.btnFiltreyiSifirla.TabIndex = 2;
            this.btnFiltreyiSifirla.Text = "Filtreyi Sıfırla";
            this.btnFiltreyiSifirla.UseVisualStyleBackColor = true;
            this.btnFiltreyiSifirla.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Location = new System.Drawing.Point(242, 74);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(111, 43);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(510, 74);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 43);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvOdaListesi
            // 
            this.dgvOdaListesi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOdaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdaListesi.Location = new System.Drawing.Point(28, 140);
            this.dgvOdaListesi.Name = "dgvOdaListesi";
            this.dgvOdaListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdaListesi.Size = new System.Drawing.Size(740, 214);
            this.dgvOdaListesi.TabIndex = 10;
            // 
            // txtOdaFiyati
            // 
            this.txtOdaFiyati.Location = new System.Drawing.Point(661, 24);
            this.txtOdaFiyati.Name = "txtOdaFiyati";
            this.txtOdaFiyati.Size = new System.Drawing.Size(112, 20);
            this.txtOdaFiyati.TabIndex = 11;
            this.txtOdaFiyati.TextChanged += new System.EventHandler(this.txtOdaFiyati_TextChanged);
            // 
            // lblOdaFiyati
            // 
            this.lblOdaFiyati.AutoSize = true;
            this.lblOdaFiyati.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblOdaFiyati.Location = new System.Drawing.Point(615, 25);
            this.lblOdaFiyati.Name = "lblOdaFiyati";
            this.lblOdaFiyati.Size = new System.Drawing.Size(41, 15);
            this.lblOdaFiyati.TabIndex = 5;
            this.lblOdaFiyati.Text = "Fiyat : ";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnFiltrele.Location = new System.Drawing.Point(73, 74);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(105, 43);
            this.btnFiltrele.TabIndex = 12;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // FormOdaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(843, 378);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.txtOdaFiyati);
            this.Controls.Add(this.dgvOdaListesi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblOdaKapasitesi);
            this.Controls.Add(this.lblOdaTuru);
            this.Controls.Add(this.lblOdaFiyati);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.cmbOdaTuru);
            this.Controls.Add(this.cmbOdaKapasitesi);
            this.Controls.Add(this.btnFiltreyiSifirla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtOdaNo);
            this.Name = "FormOdaEkle";
            this.Text = "Oda Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOdaEkle_FormClosing);
            this.Load += new System.EventHandler(this.FormOdaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdaListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.ComboBox cmbOdaKapasitesi;
        private System.Windows.Forms.ComboBox cmbOdaTuru;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.Label lblOdaTuru;
        private System.Windows.Forms.Label lblOdaKapasitesi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnFiltreyiSifirla;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvOdaListesi;
        private System.Windows.Forms.TextBox txtOdaFiyati;
        private System.Windows.Forms.Label lblOdaFiyati;
        private System.Windows.Forms.Button btnFiltrele;
    }
}