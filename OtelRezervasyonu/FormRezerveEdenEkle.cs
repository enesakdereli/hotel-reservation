using OtelRezervasyonu.Helpers;
using OtelRezervasyonu.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonu
{
    public partial class FormRezerveEdenEkle : Form
    {
        OtelRezervasyonDBEntities _db;
        RezervasyonVM _rezervasyonVM;
        bool _kilitli = true;
        public FormRezerveEdenEkle(RezervasyonVM rezervasyonVM)
        {
            InitializeComponent();
            txtTcKimlikNo.KeyPress += Helper.OnlyNumber;
            txtAd.KeyPress += Helper.LetterOnly;
            txtSoyad.KeyPress += Helper.LetterOnly;
            txtTelefon.KeyPress += Helper.OnlyNumber;
            txtTcKimlikNoFiltre.KeyPress += Helper.OnlyNumber;
            _db = new OtelRezervasyonDBEntities();
            _rezervasyonVM = rezervasyonVM;
        }

        private void FormRezerveEdenEkle_Load(object sender, EventArgs e)
        {
            DgvRezerveEdenlerYukle();
            dgvRezerveEdenler.ClearSelection();
            txtSecilenOda.Text = "";
            txtFiyat.Text = _rezervasyonVM.Fiyat.ToString();
            int odaSayisi = _rezervasyonVM.SecilenOdaNolar.Count;

            for (int i = 0; i < odaSayisi; i++)
            {
                if (i != odaSayisi - 1)
                {
                    txtSecilenOda.Text += _rezervasyonVM.SecilenOdaNolar[i] + ", ";
                }
                else
                {
                    txtSecilenOda.Text += _rezervasyonVM.SecilenOdaNolar[i];
                }
            }

            txtGirisTarihi.Text = _rezervasyonVM.GirisTarihi.ToString("d");
            txtCikisTarihi.Text = _rezervasyonVM.CikisTarihi.ToString("d");
        }
        public void DgvRezerveEdenlerYukle()
        {
            var liste = _db.RezerveEden.Where(r => r.Silindi == false && r.TcKimlikNo.Contains(txtTcKimlikNoFiltre.Text)).Select(r => new
            {
                ID = r.RezerveEdenID,
                TcKimlikNo = r.TcKimlikNo,
                Ad = r.Ad,
                Soyad = r.Soyad,
                Telefon = r.Telefon,
                Email = r.Email
            }).ToList();

            dgvRezerveEdenler.DataSource = liste;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string hataMesaji = "";
            RezerveEden rezerveEden = new RezerveEden();

            if (string.IsNullOrWhiteSpace(txtTcKimlikNo.Text))
            {
                hataMesaji += "T.C. Kimlik Numarası boş olamaz.\n";
            }
            if (txtTcKimlikNo.Text.Length != 11)
            {
                hataMesaji += "T.C. Kimlik Numarası 11 haneli olmalıdır.\n";
            }
            if (_db.RezerveEden.Any(r => r.TcKimlikNo == txtTcKimlikNo.Text && r.Silindi == true))
            {
                MessageBox.Show("Bu kişi önceden eklenmiş, kişi verilerinin yeniden getirilmesini istiyor musunuz?");
                return;
            }
            if (_db.RezerveEden.Any(r => r.TcKimlikNo == txtTcKimlikNo.Text))
            {
                MessageBox.Show("Bu kişi önceden eklenmiş, güncelleme için güncelle butonunu kullanınız.");
                return;
            }


            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                hataMesaji += "Ad boş olamaz.\n";
            }
            if (txtAd.Text.Length > 30)
            {
                hataMesaji += "Ad 30 karakteri geçemez.\n";
            }

            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                hataMesaji += "Soyad boş olamaz.\n";
            }
            if (txtSoyad.Text.Length > 30)
            {
                hataMesaji += "Soyad 30 karakteri geçemez.\n";
            }

            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                hataMesaji += "Telefon boş olamaz.\n";
            }
            if (txtTelefon.Text.Length != 10)
            {
                hataMesaji += "Telefon 10 haneli olmalıdır.\n";
            }

            if (txtEmail.Text.Length > 50)
            {
                hataMesaji += "Email 50 karakteri geçemez.";
            }

            if (hataMesaji.Length > 0)
            {
                MessageBox.Show(hataMesaji, "Dikkat");
                return;
            }

            DialogResult result = MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " isimli kişi eklenecektir, emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            rezerveEden.TcKimlikNo = txtTcKimlikNo.Text;
            rezerveEden.Ad = txtAd.Text;
            rezerveEden.Soyad = txtSoyad.Text;
            rezerveEden.Telefon = txtTelefon.Text;
            rezerveEden.Silindi = false;

            #region E-mail Regex
            Regex rx = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

            if (rx.IsMatch(txtEmail.Text))
            {
                rezerveEden.Email = txtTelefon.Text;
                try
                {
                    _db.RezerveEden.Add(rezerveEden);
                    _db.SaveChanges();
                    DgvRezerveEdenlerYukle();
                    Helper.ControlTemizle(this);
                    MessageBox.Show("Kayıt başarılı.", "Başarılı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata nedeniyle ekleme işlemi gerçekleştirilemedi.", "Hata");
                    return;
                }
            }

            else
                MessageBox.Show("Geçerli bir mail adresi giriniz!");
            #endregion
        }

        private void FormRezerveEdenEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAnaSayfa formAnaSayfa = new FormAnaSayfa();
            formAnaSayfa.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvRezerveEdenler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silme işlemi için önce silinecek kişi seçilmelidir.", "Dikkat");
                return;
            }

            int rezerveEdenID = (int)dgvRezerveEdenler.SelectedRows[0].Cells[0].Value;

            DialogResult result = MessageBox.Show("Seçilen kişi silinecektir, emin misiniz?", "Onay", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                RezerveEden rezerveEden = _db.RezerveEden.Find(rezerveEdenID);
                rezerveEden.Silindi = true;
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata nedeniyle silme işlemi gerçekleştirilemedi.", "Hata");
            }
            finally
            {
                DgvRezerveEdenlerYukle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_kilitli)
            {
                MessageBox.Show("Güncellemek için önce kilidi açınız.", "Dikkat");
                return;
            }
            DialogResult result = MessageBox.Show("Seçilen kişi güncellenecektir, emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }
            DataGridViewRow row = dgvRezerveEdenler.CurrentRow;
            if (dgvRezerveEdenler.SelectedRows.Count != 1)
            {
                MessageBox.Show("Güncelleme için bir kişi seçiniz.", "Dikkat");
                return;
            }
            int rezerveEdenID = (int)row.Cells["ID"].Value;
            if (!_db.RezerveEden.Any(r => r.RezerveEdenID == rezerveEdenID))
            {
                MessageBox.Show("Seçtiğiniz kişi silinmiş.", "Hata");
                DgvRezerveEdenlerYukle();
                return;
            }

            int secilenRezerveEdenID = Convert.ToInt32(row.Cells["ID"].Value);
            RezerveEden rezerveEden = _db.RezerveEden.Find(secilenRezerveEdenID);
            rezerveEden.TcKimlikNo = txtTcKimlikNo.Text;
            rezerveEden.Ad = txtAd.Text;
            rezerveEden.Soyad = txtSoyad.Text;
            rezerveEden.Telefon = txtTelefon.Text;

            #region E-mail Regex
            Regex rx = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

            if (rx.IsMatch(txtEmail.Text))
            {
                rezerveEden.Email = txtEmail.Text;
                try
                {
                    _db.SaveChanges();
                    MessageBox.Show("Güncelleme başarılı.", "Başarılı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata nedeniyle güncelleme işlemi gerçekleştirilemedi.", "Hata");
                }
                finally
                {
                    DgvRezerveEdenlerYukle();
                    Helper.ControlTemizle(this);
                }
            }
            else
                MessageBox.Show("Geçerli bir mail adresi giriniz!");
            #endregion
        }

        private void btnRezervasyonuEkle_Click(object sender, EventArgs e)
        {
            if (dgvRezerveEdenler.SelectedRows.Count != 1)
            {
                MessageBox.Show("Lütfen bir rezerve eden kişi seçiniz.", "Dikkat");
                return;
            }
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.RezerveEdenID = Convert.ToInt32(dgvRezerveEdenler.SelectedRows[0].Cells["ID"].Value);
            rezervasyon.GirisTarihi = _rezervasyonVM.GirisTarihi;
            rezervasyon.CikisTarihi = _rezervasyonVM.CikisTarihi;
            rezervasyon.Fiyat = _rezervasyonVM.Fiyat;
            rezervasyon.Odendi = true;
            rezervasyon.Iptal = false;
            rezervasyon.Silindi = false;

            _db.Rezervasyon.Add(rezervasyon);

            foreach (string odaNo in _rezervasyonVM.SecilenOdaNolar)
            {
                int odaID = _db.Oda.Where(o => o.OdaNo == odaNo).FirstOrDefault().OdaID;
                RezervasyonDetay rezervasyonDetay = new RezervasyonDetay
                {
                    RezervasyonID = rezervasyon.RezervasyonID,
                    OdaID = odaID
                };
                _db.RezervasyonDetay.Add(rezervasyonDetay);
            }
            _db.SaveChanges();
            FormKonaklayanEkle formKonaklayanEkle = new FormKonaklayanEkle();
            formKonaklayanEkle.Show();
            this.Hide();
        }

        private void TxtTcKimlikNoFiltre_TextChanged(object sender, EventArgs e)
        {
            DgvRezerveEdenlerYukle();
        }

        private void txtTcKimlikNo_TextChanged(object sender, EventArgs e)
        {
            if (txtTcKimlikNo.TextLength == 11)
            {
                var sorgu = (from r in _db.RezerveEden
                             where r.TcKimlikNo == txtTcKimlikNo.Text
                             select r).SingleOrDefault();
                if (sorgu != null)
                {
                    txtAd.Text = sorgu.Ad;
                    txtSoyad.Text = sorgu.Soyad;
                    txtTelefon.Text = sorgu.Telefon;
                    txtEmail.Text = sorgu.Email;
                }
            }
        }

        private void DgvRezerveEdenler_Click(object sender, EventArgs e)
        {
            txtTcKimlikNo.Text = (string)dgvRezerveEdenler.CurrentRow.Cells["TcKimlikNo"].Value;
            txtAd.Text = (string)dgvRezerveEdenler.CurrentRow.Cells["Ad"].Value;
            txtSoyad.Text = (string)dgvRezerveEdenler.CurrentRow.Cells["Soyad"].Value;
            txtTelefon.Text = (string)dgvRezerveEdenler.CurrentRow.Cells["Telefon"].Value;
            txtEmail.Text = (string)dgvRezerveEdenler.CurrentRow.Cells["Email"].Value;
        }
        private void RezerveEdenTextBoxMakeReadOnly()
        {
            if (_kilitli)
            {
                txtTcKimlikNo.ReadOnly = true;
                txtSoyad.ReadOnly = true;
                txtAd.ReadOnly = true;
                txtTelefon.ReadOnly = true;
                txtEmail.ReadOnly = true;
            }
            else
            {txtTcKimlikNo.ReadOnly = false;
                txtSoyad.ReadOnly = false;
                txtAd.ReadOnly = false;
                txtTelefon.ReadOnly = false;
                txtEmail.ReadOnly = false;
            }
        }

        private void BtnKilidiAc_Click(object sender, EventArgs e)
        {
            RezerveEdenTextBoxMakeReadOnly();
            if (_kilitli)
            {
                btnKilidiAc.Image = Properties.Resources.Unlocked;
                _kilitli = false;
                RezerveEdenTextBoxMakeReadOnly();
            }
            else
            {
                btnKilidiAc.Image = Properties.Resources.Locked;
                _kilitli = true;
                RezerveEdenTextBoxMakeReadOnly();
            }
        }
    }
}
