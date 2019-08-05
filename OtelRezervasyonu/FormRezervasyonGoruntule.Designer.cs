namespace OtelRezervasyonu
{
    partial class FormRezervasyonGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRezervasyonGoruntule));
            this.dgvRezervasyon = new System.Windows.Forms.DataGridView();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnOdendi = new System.Windows.Forms.Button();
            this.pcbTCFiltre = new System.Windows.Forms.PictureBox();
            this.lblTcKimlikNoFiltre = new System.Windows.Forms.Label();
            this.txtTcKimlikNoFiltre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTCFiltre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRezervasyon
            // 
            this.dgvRezervasyon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervasyon.Location = new System.Drawing.Point(12, 55);
            this.dgvRezervasyon.Name = "dgvRezervasyon";
            this.dgvRezervasyon.Size = new System.Drawing.Size(776, 262);
            this.dgvRezervasyon.TabIndex = 0;
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnIptal.Location = new System.Drawing.Point(12, 323);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(82, 36);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(100, 323);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 36);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnOdendi
            // 
            this.btnOdendi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnOdendi.Location = new System.Drawing.Point(188, 323);
            this.btnOdendi.Name = "btnOdendi";
            this.btnOdendi.Size = new System.Drawing.Size(82, 36);
            this.btnOdendi.TabIndex = 1;
            this.btnOdendi.Text = "Ödendi";
            this.btnOdendi.UseVisualStyleBackColor = true;
            this.btnOdendi.Click += new System.EventHandler(this.btnOdendi_Click);
            // 
            // pcbTCFiltre
            // 
            this.pcbTCFiltre.Image = ((System.Drawing.Image)(resources.GetObject("pcbTCFiltre.Image")));
            this.pcbTCFiltre.Location = new System.Drawing.Point(227, 19);
            this.pcbTCFiltre.Name = "pcbTCFiltre";
            this.pcbTCFiltre.Size = new System.Drawing.Size(31, 30);
            this.pcbTCFiltre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbTCFiltre.TabIndex = 25;
            this.pcbTCFiltre.TabStop = false;
            // 
            // lblTcKimlikNoFiltre
            // 
            this.lblTcKimlikNoFiltre.AutoSize = true;
            this.lblTcKimlikNoFiltre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTcKimlikNoFiltre.Location = new System.Drawing.Point(10, 31);
            this.lblTcKimlikNoFiltre.Name = "lblTcKimlikNoFiltre";
            this.lblTcKimlikNoFiltre.Size = new System.Drawing.Size(84, 15);
            this.lblTcKimlikNoFiltre.TabIndex = 24;
            this.lblTcKimlikNoFiltre.Text = "T.C. Kimlik No:";
            // 
            // txtTcKimlikNoFiltre
            // 
            this.txtTcKimlikNoFiltre.Location = new System.Drawing.Point(100, 29);
            this.txtTcKimlikNoFiltre.Name = "txtTcKimlikNoFiltre";
            this.txtTcKimlikNoFiltre.Size = new System.Drawing.Size(121, 20);
            this.txtTcKimlikNoFiltre.TabIndex = 23;
            this.txtTcKimlikNoFiltre.TextChanged += new System.EventHandler(this.txtTcKimlikNoFiltre_TextChanged);
            // 
            // FormRezervasyonGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbTCFiltre);
            this.Controls.Add(this.lblTcKimlikNoFiltre);
            this.Controls.Add(this.txtTcKimlikNoFiltre);
            this.Controls.Add(this.btnOdendi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.dgvRezervasyon);
            this.Name = "FormRezervasyonGoruntule";
            this.Text = "FormRezervasyonGoruntule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRezervasyonGoruntule_FormClosing);
            this.Load += new System.EventHandler(this.FormRezervasyonGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTCFiltre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRezervasyon;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnOdendi;
        private System.Windows.Forms.PictureBox pcbTCFiltre;
        private System.Windows.Forms.Label lblTcKimlikNoFiltre;
        private System.Windows.Forms.TextBox txtTcKimlikNoFiltre;
    }
}