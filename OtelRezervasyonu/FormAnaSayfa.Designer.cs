namespace OtelRezervasyonu
{
    partial class FormAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaSayfa));
            this.btnOdaSec = new System.Windows.Forms.Button();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.btnFormOdaEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdaSec
            // 
            this.btnOdaSec.AutoEllipsis = true;
            this.btnOdaSec.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnOdaSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOdaSec.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOdaSec.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnOdaSec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOdaSec.Image = ((System.Drawing.Image)(resources.GetObject("btnOdaSec.Image")));
            this.btnOdaSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdaSec.Location = new System.Drawing.Point(386, 298);
            this.btnOdaSec.Name = "btnOdaSec";
            this.btnOdaSec.Size = new System.Drawing.Size(174, 67);
            this.btnOdaSec.TabIndex = 6;
            this.btnOdaSec.Text = "Rezervasyon Görüntüle";
            this.btnOdaSec.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOdaSec.UseVisualStyleBackColor = false;
            this.btnOdaSec.Click += new System.EventHandler(this.btnOdaSec_Click);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnRezervasyon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRezervasyon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRezervasyon.Image = ((System.Drawing.Image)(resources.GetObject("btnRezervasyon.Image")));
            this.btnRezervasyon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRezervasyon.Location = new System.Drawing.Point(386, 192);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(174, 65);
            this.btnRezervasyon.TabIndex = 5;
            this.btnRezervasyon.Text = "Rezervasyon Ekle";
            this.btnRezervasyon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRezervasyon.UseVisualStyleBackColor = false;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // btnFormOdaEkle
            // 
            this.btnFormOdaEkle.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnFormOdaEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFormOdaEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFormOdaEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFormOdaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnFormOdaEkle.Image")));
            this.btnFormOdaEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormOdaEkle.Location = new System.Drawing.Point(386, 82);
            this.btnFormOdaEkle.Name = "btnFormOdaEkle";
            this.btnFormOdaEkle.Size = new System.Drawing.Size(174, 68);
            this.btnFormOdaEkle.TabIndex = 3;
            this.btnFormOdaEkle.Text = "Oda Ekle";
            this.btnFormOdaEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFormOdaEkle.UseVisualStyleBackColor = false;
            this.btnFormOdaEkle.Click += new System.EventHandler(this.btnFormOdaEkle_Click);
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 421);
            this.Controls.Add(this.btnOdaSec);
            this.Controls.Add(this.btnRezervasyon);
            this.Controls.Add(this.btnFormOdaEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAnaSayfa";
            this.Text = "Ana Sayfa - Otel Rezervasyon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.FormAnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFormOdaEkle;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Button btnOdaSec;
    }
}

