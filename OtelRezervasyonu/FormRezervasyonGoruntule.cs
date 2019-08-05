using OtelRezervasyonu.Helpers;
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
    public partial class FormRezervasyonGoruntule : Form
    {
        OtelRezervasyonDBEntities _db;

        public FormRezervasyonGoruntule()
        {
            InitializeComponent();
            txtTcKimlikNoFiltre.KeyPress += Helper.OnlyNumber;
            _db = new OtelRezervasyonDBEntities();
        }

        private void FormRezervasyonGoruntule_Load(object sender, EventArgs e)
        {
            DgvRezervasyonlarYukle();
        }

        public void DgvRezervasyonlarYukle()
        {
            var list = (from re in _db.RezerveEden
                        join rez in _db.Rezervasyon on re.RezerveEdenID equals rez.RezerveEdenID
                        where re.Silindi == false && re.TcKimlikNo.Contains(txtTcKimlikNoFiltre.Text)
                        select new
                        {
                            rez.RezervasyonID,
                            re.TcKimlikNo,
                            re.Ad,
                            re.Soyad,
                            rez.GirisTarihi,
                            rez.CikisTarihi,
                            rez.Fiyat,
                            rez.Odendi,
                            rez.Iptal,
                            rez.Silindi
                        }).ToList();

            dgvRezervasyon.DataSource = list;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            int rezervasyonID = (int)dgvRezervasyon.SelectedRows[0].Cells[0].Value;
            Rezervasyon rezervasyon = _db.Rezervasyon.Find(rezervasyonID);
            rezervasyon.Iptal = true;
            _db.SaveChanges();
            DgvRezervasyonlarYukle();
            MessageBox.Show("İptal işlemi başarıyla tamamlandı.", "İptal edildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int rezervasyonID = (int)dgvRezervasyon.SelectedRows[0].Cells[0].Value;
            Rezervasyon rezervasyon = _db.Rezervasyon.Find(rezervasyonID);
            rezervasyon.Silindi = true;
            _db.SaveChanges();
            MessageBox.Show("Silme işlemi başarıyla tamamlandı.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DgvRezervasyonlarYukle();
        }

        private void btnOdendi_Click(object sender, EventArgs e)
        {
            int rezervasyonID = (int)dgvRezervasyon.SelectedRows[0].Cells[0].Value;
            Rezervasyon rezervasyon = _db.Rezervasyon.Find(rezervasyonID);
            rezervasyon.Odendi = true;
            _db.SaveChanges();
            MessageBox.Show("Ödeme işlemi başarıyla tamamlandı.", "Ödendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DgvRezervasyonlarYukle();
        }

        private void txtTcKimlikNoFiltre_TextChanged(object sender, EventArgs e)
        {
            if (txtTcKimlikNoFiltre.TextLength == 11)
            { DgvRezervasyonlarYukle(); }



        }

        private void FormRezervasyonGoruntule_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAnaSayfa formAnaSayfa = new FormAnaSayfa();
            formAnaSayfa.Show();
        }
    }
}
