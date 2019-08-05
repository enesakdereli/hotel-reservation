using OtelRezervasyonu.Enums;
using OtelRezervasyonu.Helpers;
using OtelRezervasyonu.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OtelRezervasyonu
{
    public partial class FormOdaEkle : Form
    {
        OtelRezervasyonDBEntities _db;
        List<TumOdalarView> _tumOdalar;
        List<TumOdalarView> _filtrelenmisOdalar;
        decimal fiyat;
        public FormOdaEkle()
        {
            InitializeComponent();
            _db = new OtelRezervasyonDBEntities();
            txtOdaNo.KeyPress += Helper.OnlyNumber;
            txtOdaFiyati.KeyPress += Helper.OnlyNumber;
        }
        private void FormOdaEkle_Load(object sender, EventArgs e)
        {
            cmbOdaTuru.ListControlDoldur<OdaTuruEnum>();
            cmbOdaKapasitesi.ListControlDoldur<OdaKapasitesiEnum>();
            Listele();
        }
        public void Listele()
        {
            var tumodalar = (from o in _db.Oda
                             select new TumOdalarView
                             {
                                 OdaID = o.OdaID,
                                 OdaNo = o.OdaNo,
                                 OdaKapasitesi = (OdaKapasitesiEnum)o.Kapasite,
                                 OdaTuru = (OdaTuruEnum)o.OdaTuruEnum,
                                 Fiyat = o.Fiyat,
                                 Silindi = o.Silindi,
                             }).OrderBy(o => o.OdaNo);

            _tumOdalar = tumodalar.ToList();
            _filtrelenmisOdalar = _tumOdalar;
            dgvOdaListesi.DataSource = _tumOdalar;
        }

        public void OdaEkle()
        {
            string hataMesaji = "";
            if (string.IsNullOrWhiteSpace(txtOdaNo.Text) || txtOdaNo.Text.Length != 3)
            {
                hataMesaji += "Oda no boş geçilemez ve üç haneli olmalıdır.\n";
            }

            if (cmbOdaKapasitesi.SelectedIndex == -1)
            {
                hataMesaji += "Oda kapasitesi belirtilmedi.\n";
            }

            if (cmbOdaTuru.SelectedIndex == -1)
            {
                hataMesaji += "Oda türü belirtilmedi.\n";
            }

            if (hataMesaji.Length > 0)
            {
                MessageBox.Show(hataMesaji, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Oda oda = new Oda();
            oda.OdaNo = txtOdaNo.Text;
            oda.Kapasite = (byte)(int)cmbOdaKapasitesi.SelectedValue;
            oda.OdaTuruEnum = (byte)(int)cmbOdaTuru.SelectedValue;
            oda.Fiyat = Convert.ToDecimal(txtOdaFiyati.Text);
            _db.Oda.Add(oda);
            _db.SaveChanges();
            MessageBox.Show("Kayıt işlemi başarılı.", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }
        public void OdaSil()
        {
            if (dgvOdaListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silme işlemi yapabilmek için ilk önce silinecek oda seçilmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int odaID = (int)dgvOdaListesi.SelectedRows[0].Cells[0].Value;
            Oda oda = _db.Oda.Find(odaID);
            oda.Silindi = true;
            _db.SaveChanges();
            MessageBox.Show("Silme işlemi başarıyla tamamlandı.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();

        }
        public void OdaGuncelle()
        {
            if (dgvOdaListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemi yapabilmek için ilk önce güncellenecek oda seçilmelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string hataMesaji = "";
            if (string.IsNullOrWhiteSpace(txtOdaNo.Text) || txtOdaNo.Text.Length != 3)
            {
                hataMesaji += "Oda no boş geçilemez ve üç haneli olmalıdır.\n";
            }

            if (cmbOdaKapasitesi.SelectedIndex == -1)
            {
                hataMesaji += "Oda kapasitesi belirtilmedi.\n";
            }

            if (cmbOdaTuru.SelectedIndex == -1)
            {
                hataMesaji += "Oda türü belirtilmedi.\n";
            }

            if (hataMesaji.Length > 0)
            {
                MessageBox.Show(hataMesaji, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int odaID = (int)dgvOdaListesi.SelectedRows[0].Cells[0].Value;
            Oda oda = _db.Oda.Find(odaID);
            oda.Kapasite = (byte)(int)cmbOdaKapasitesi.SelectedValue;
            oda.OdaTuruEnum = (byte)(int)cmbOdaTuru.SelectedValue;
            _db.SaveChanges();
            MessageBox.Show("Oda bilgileri başarıyla güncellendi", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        public void Filtrele()
        {

            if (!string.IsNullOrWhiteSpace(txtOdaNo.Text))
            {
                _filtrelenmisOdalar = _filtrelenmisOdalar.Where(o => o.OdaNo.Contains(txtOdaNo.Text)).ToList();
            }
            if (!string.IsNullOrWhiteSpace(txtOdaFiyati.Text))
            {
                _filtrelenmisOdalar = _filtrelenmisOdalar.Where(o => o.Fiyat == fiyat).ToList();
            }
            if (cmbOdaKapasitesi.SelectedIndex != -1)
            {
                _filtrelenmisOdalar = _filtrelenmisOdalar.Where(o => o.OdaKapasitesi.Equals((OdaKapasitesiEnum)(int)cmbOdaKapasitesi.SelectedValue)).ToList();
            }
            if (cmbOdaTuru.SelectedIndex != -1)
            {
                _filtrelenmisOdalar = _filtrelenmisOdalar.Where(o => o.OdaTuru.Equals((OdaTuruEnum)(int)cmbOdaTuru.SelectedValue)).ToList();
            }

            dgvOdaListesi.DataSource = _filtrelenmisOdalar;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            OdaEkle();
            Helper.ControlTemizle(this);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvOdaListesi.DataSource = _tumOdalar;
            _filtrelenmisOdalar = _tumOdalar;
            Helper.ControlTemizle(this);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OdaGuncelle();
            Helper.ControlTemizle(this);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OdaSil();
            Helper.ControlTemizle(this);
        }


        private void FormOdaEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAnaSayfa formAnaSayfa = new FormAnaSayfa();
            formAnaSayfa.Show();
        }

        private void txtOdaNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOdaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOdaKapasitesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtOdaFiyati_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOdaFiyati.Text))
            {
                fiyat = Convert.ToDecimal(txtOdaFiyati.Text);
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            _filtrelenmisOdalar = _tumOdalar;
            Filtrele();
        }
    }
}
