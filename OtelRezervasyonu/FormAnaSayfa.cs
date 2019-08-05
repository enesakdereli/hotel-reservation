using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonu
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnFormOdaEkle_Click(object sender, EventArgs e)
        {
            FormOdaEkle oda = new FormOdaEkle();
            this.Hide();
            oda.Show();
        }

        private void btnFormRezerveEden_Click(object sender, EventArgs e)
        {
            //FormRezerveEdenEkle rezerve = new FormRezerveEdenEkle();
            //this.Hide();
            //rezerve.Show();
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void FormAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        

        private void btnFormKonaklayanEkle_Click_1(object sender, EventArgs e)
        {
            FormKonaklayanEkle formKonaklayanEkle = new FormKonaklayanEkle();
            this.Hide();
            formKonaklayanEkle.Show();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            FormOdaSec formOdaSec = new FormOdaSec();
            this.Hide();
            formOdaSec.Show();
        }

        private void btnOdaSec_Click(object sender, EventArgs e)
        {
            FormRezervasyonGoruntule formRezervasyonGoruntule = new FormRezervasyonGoruntule();
            this.Hide();
            formRezervasyonGoruntule.Show();
        }

        
    }
}
