using OtelRezervasyonu.Enums;
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

    public partial class FormKonaklayanEkle : Form
    {
        OtelRezervasyonDBEntities _db;
        int ID;
        int RezID;
        int RezDetayID;

        public FormKonaklayanEkle()
        {
            InitializeComponent();
            txtTcKimlikNo.KeyPress += Helper.OnlyNumber;
            txtAd.KeyPress += Helper.LetterOnly;
            txtSoyad.KeyPress += Helper.LetterOnly;
            txtTelefon.KeyPress += Helper.OnlyNumber;
            txtTcKimlikNoFiltre.KeyPress += Helper.OnlyNumber;

            _db = new OtelRezervasyonDBEntities();

        }

        public void KonaklayanGuncelle()
        {
            try
            {
                Konaklayan konaklayanGuncelle = _db.Konaklayan.Where(x => x.KonaklayanID == ID).FirstOrDefault();
                konaklayanGuncelle.TcKimlikNo = txtTcKimlikNo.Text;
                konaklayanGuncelle.Ad = txtAd.Text;
                konaklayanGuncelle.Soyad = txtSoyad.Text;
                konaklayanGuncelle.DogumTarihi = dtpDogumTarihi.Value;
                konaklayanGuncelle.CinsiyetEnum = (byte)(int)cmbCinsiyet.SelectedValue;
                konaklayanGuncelle.Telefon = txtTelefon.Text;

                int sonuc = _db.SaveChanges();
                if (sonuc == 1)
                {
                    MessageBox.Show("Güncelleme Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Hatalı Güncelleme");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        public void KonaklayanSil()
        {

            int KonaklayanID = (int)dgvKonaklayan.SelectedRows[0].Cells[0].Value;
            Konaklayan konaklayan = _db.Konaklayan.Find(KonaklayanID);
            konaklayan.Silindi = true;
            _db.SaveChanges();
            KonaklayanListesiGetir();
            MessageBox.Show("Silme işlemi başarıyla tamamlandı.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //DialogResult cevap = MessageBox.Show("Silmek İstediğinizden Emin Misiniz?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //try
            //{
            //    if (cevap == DialogResult.Yes)
            //    {
            //        Konaklayan konaklayanSil = _db.Konaklayan.Where(x => x.KonaklayanID == ID).FirstOrDefault();
            //        _db.Konaklayan.Remove(konaklayanSil);
            //        int sonuc = _db.SaveChanges();
            //        if (sonuc == 1)
            //        {
            //            MessageBox.Show("Konaklayan Silindi");
            //            KonaklayanListesiGetir();
            //        }

            //        else
            //        {
            //            MessageBox.Show("Bir Hata Oluştu - Tekrar Deneyin");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.ToString());
            //}
        }
        public void RezervasyonListesiGetir()
        {
            var list = (from re in _db.RezerveEden
                        join rez in _db.Rezervasyon on re.RezerveEdenID equals rez.RezerveEdenID
                        join rd in _db.RezervasyonDetay on rez.RezervasyonID equals rd.RezervasyonID
                        join o in _db.Oda on rd.OdaID equals o.OdaID
                        where re.Silindi == false && re.TcKimlikNo.Contains(txtTcKimlikNoFiltre.Text)
                        select new
                        {
                            ID = rez.RezervasyonID,
                            re.TcKimlikNo,
                            AdSoyad = re.Ad + " " + re.Soyad,
                            rez.GirisTarihi,
                            rez.CikisTarihi,
                            o.OdaNo,
                            rdID = rd.RezervasyonDetayID

                        }).ToList();

            dgvKonaklayan.DataSource = list;
        }
        public void KonaklayanListesiGetir()
        {
            var liste = _db.Konaklayan.Where(x => x.Silindi == false && x.TcKimlikNo.Contains(txtTcKimlikNoFiltre.Text)).Select(x => new
            {
                ID = x.KonaklayanID,
                TCKimlikNo = x.TcKimlikNo,
                Ad = x.Ad,
                Soyad = x.Soyad,
                DogumTarihi = x.DogumTarihi,
                Cinsiyet = x.CinsiyetEnum,
                TelefonNo = x.Telefon,
                Silindi = x.Silindi
            });

            dgvKonaklayan.DataSource = liste.ToList(); ;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            #region Validation

            string hataMesaji = "";
            RezerveEden rezerveEden = new RezerveEden();

            if (string.IsNullOrWhiteSpace(txtTcKimlikNo.Text)) { hataMesaji += "T.C. Kimlik Numarası boş olamaz."; }
            if (txtTcKimlikNo.Text.Length != 11) { hataMesaji += "T.C. Kimlik Numarası 11 haneli olmalıdır."; }
            if (string.IsNullOrWhiteSpace(txtAd.Text)) { hataMesaji += "Ad boş olamaz."; }
            if (txtAd.Text.Length > 30) { hataMesaji += "Ad 30 karakteri geçemez."; }
            if (cmbCinsiyet.SelectedIndex == -1) { hataMesaji += "Cinsiyet bilgisi girilmedi."; }
            if (string.IsNullOrWhiteSpace(txtSoyad.Text)) { hataMesaji += "Soyad boş olamaz."; }
            if (txtSoyad.Text.Length > 30) { hataMesaji += "Soyad 30 karakteri geçemez."; }
            if (string.IsNullOrWhiteSpace(txtTelefon.Text)) { hataMesaji += "Telefon boş olamaz."; }
            if (txtTelefon.Text.Length != 10) { hataMesaji += "Telefon 10 haneli olmalıdır."; }
            if (hataMesaji.Length > 0)
            {
                MessageBox.Show(hataMesaji);
                return;
            }

            #endregion


            Konaklayan konaklayan = new Konaklayan();
            konaklayan.TcKimlikNo = txtTcKimlikNo.Text;
            konaklayan.Ad = txtAd.Text;
            konaklayan.Soyad = txtSoyad.Text;
            konaklayan.Telefon = txtTelefon.Text;
            konaklayan.CinsiyetEnum = (byte)(int)cmbCinsiyet.SelectedValue;
            konaklayan.DogumTarihi = dtpDogumTarihi.Value.Date;

            try
            {
                _db.Konaklayan.Add(konaklayan);
                _db.SaveChanges();

            }
            catch (Exception)
            {
                MessageBox.Show("Bu Tc Kimlik No zaten var.", "Geçersiz İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            KonaklayanListesiGetir();

            foreach (Control item in this.Controls)
            {
                Helper.ControlTemizle(item);
            }

            MessageBox.Show("Kayıt başarılı.");

            //int konakID = _db.Konaklayan.LastOrDefault().KonaklayanID;

        }

        private void FormKonaklayanEkle_Load(object sender, EventArgs e)
        {

            cmbCinsiyet.ListControlDoldur<CinsiyetEnum>();

        }

        private void FormKonaklayanEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAnaSayfa formAnaSayfa = new FormAnaSayfa();
            formAnaSayfa.Show();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            KonaklayanGuncelle();
            KonaklayanListesiGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            KonaklayanSil();
        }

        private void dgvKonaklayan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdbtnRezervasyon.Checked == true)
            {
                DataGridViewRow row = dgvKonaklayan.CurrentRow;
                lblRezerveEden.Text = row.Cells["AdSoyad"].Value.ToString();
                RezID = Convert.ToInt32(row.Cells["ID"].Value);
                RezDetayID = Convert.ToInt32(row.Cells["rdID"].Value);
            }

            if (rdbtnKonaklayan.Checked == true)
            {
                DataGridViewRow row = dgvKonaklayan.CurrentRow;
                ID = Convert.ToInt32(row.Cells["ID"].Value);
                txtTcKimlikNo.Text = row.Cells["TCKimlikNo"].Value.ToString();
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                dtpDogumTarihi.Value = Convert.ToDateTime(row.Cells["DogumTarihi"].Value);
                cmbCinsiyet.SelectedValue = row.Cells["Cinsiyet"].Value.ToString();
                txtTelefon.Text = row.Cells["TelefonNo"].Value.ToString();
            }
        }

        private void rdbtnRezervasyon_CheckedChanged(object sender, EventArgs e)
        {
            RezervasyonListesiGetir();
        }

        private void rdbtnKonaklayan_CheckedChanged(object sender, EventArgs e)
        {
            KonaklayanListesiGetir();
        }

        private void txtTcKimlikNoFiltre_TextChanged(object sender, EventArgs e)
        {
            if (rdbtnKonaklayan.Checked == true)
                KonaklayanListesiGetir();

            if (rdbtnRezervasyon.Checked == true)
                RezervasyonListesiGetir();
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            // int rdID = _db.RezervasyonDetay.Where(r => r.RezervasyonID == RezID).FirstOrDefault().RezervasyonDetayID;
            // int kID = _db.Konaklayan.LastOrDefault().KonaklayanID;

            var kID = (from rez in _db.Rezervasyon
                       join rd in _db.RezervasyonDetay on rez.RezervasyonID equals rd.RezervasyonID
                       join kd in _db.KonaklayanDetay on rd.RezervasyonDetayID equals kd.RezervasyonDetayID
                       join k in _db.Konaklayan on kd.KonaklayanID equals k.KonaklayanID

                       where RezID == rez.RezervasyonID && RezDetayID == rd.RezervasyonDetayID
                       select new
                       {
                           rd.RezervasyonDetayID
                       }).ToList();

            //foreach(int ID in kID )
            //KonaklayanDetay konakdetay = new KonaklayanDetay();
            //konakdetay.RezervasyonDetayID = RezDetayID;
            //konakdetay.KonaklayanID = (int)kID;
            //_db.KonaklayanDetay.Add(konakdetay);
            //_db.SaveChanges();
            //this.Hide();

        }
    }
}
