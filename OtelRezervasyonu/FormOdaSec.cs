using OtelRezervasyonu.Enums;
using OtelRezervasyonu.Helpers;
using OtelRezervasyonu.ViewModel;
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
    public partial class FormOdaSec : Form
    {
        OtelRezervasyonDBEntities _db;
        int _gunsayisi;
        decimal _fiyat;
        int _kisisayisi;
        int _toplamkapasite;
        List<BosOdaView> _bosOdalar;
        List<BosOdaView> _bosOdalarSecileniSil;
        public FormOdaSec()
        {
            InitializeComponent();
            txtToplamKisiSayisi.KeyPress += Helper.OnlyNumber;
            _db = new OtelRezervasyonDBEntities();
        }

        private void FormOdaSec_Load(object sender, EventArgs e)
        {
            cmbOdaTuru.ListControlDoldur<OdaTuruEnum>();
            cmbOdaKapasitesi.ListControlDoldur<OdaKapasitesiEnum>();
            DtpCikisTarihi.MinDate = DtpGirisTarihi.Value.Date.AddDays(1);
        }

        //todo = filtrele ve doluodalar metodları delegate edilecek
        public void BosOdalariGetir()
        {
            DateTime giristarihi = DtpGirisTarihi.Value.Date;
            DateTime cikistarihi = DtpCikisTarihi.Value.Date;

            var filtrele = (from o in _db.Oda
                            where !(from o2 in _db.Oda
                                    join rd in _db.RezervasyonDetay on o.OdaID equals rd.OdaID
                                    join r in _db.Rezervasyon on rd.RezervasyonID equals r.RezervasyonID
                                    where r.GirisTarihi < cikistarihi && r.CikisTarihi > giristarihi && o.Silindi == false
                                    select o2.OdaID).Contains(o.OdaID)
                            select new BosOdaView
                            {
                                OdaNo = o.OdaNo,
                                OdaTuru = (OdaTuruEnum)o.OdaTuruEnum,
                                OdaKapasitesi = (OdaKapasitesiEnum)o.Kapasite,
                                Fiyat = o.Fiyat,
                            }).OrderBy(o => o.OdaNo);


            if (cmbOdaKapasitesi.SelectedIndex != -1)
            {
                filtrele = filtrele.Where(o => o.OdaKapasitesi == (OdaKapasitesiEnum)(int)cmbOdaKapasitesi.SelectedValue).Select(o => o).OrderBy(o => o.OdaNo);
            }

            if (cmbOdaTuru.SelectedIndex != -1)
            {
                filtrele = filtrele.Where(o => o.OdaTuru == (OdaTuruEnum)(int)cmbOdaTuru.SelectedValue).Select(o => o).OrderBy(o => o.OdaNo);
            }
            _bosOdalar = filtrele.ToList();
            _bosOdalarSecileniSil = _bosOdalar;
            dgvBosOdalar.DataSource = _bosOdalar;
        }

        public void DoluOdalariGetir()
        {
            DateTime giristarihi = DtpGirisTarihi.Value.Date;
            DateTime cikistarihi = DtpCikisTarihi.Value.Date;

            var filtrele = (from o in _db.Oda
                            join rd in _db.RezervasyonDetay on o.OdaID equals rd.OdaID
                            join r in _db.Rezervasyon on rd.RezervasyonID equals r.RezervasyonID
                            where r.GirisTarihi < cikistarihi && r.CikisTarihi > giristarihi && o.Silindi == false
                            select new
                            {
                                o.OdaNo,
                                OdaTuru = (OdaTuruEnum)o.OdaTuruEnum,
                                Kapasite = (OdaKapasitesiEnum)o.Kapasite,
                                o.Fiyat,
                                r.GirisTarihi,
                                r.CikisTarihi,
                            }).OrderBy(o => o.OdaNo);

            dgvDoluOdalar.DataSource = filtrele.ToList();
        }


        private void DtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            BosOdalariGetir();
            DoluOdalariGetir();
            DtpCikisTarihi.MinDate = DtpGirisTarihi.Value.Date.AddDays(1);
            TarihFarkiniAl(DtpGirisTarihi.Value.Date, DtpCikisTarihi.Value.Date);
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            BosOdalariGetir();
            DoluOdalariGetir();
            TarihFarkiniAl(DtpGirisTarihi.Value.Date, DtpCikisTarihi.Value.Date);
        }
        public void TarihFarkiniAl(DateTime giris, DateTime cikis)
        {
            _gunsayisi = (cikis.Date - giris.Date).Days;
            if (_gunsayisi > 0)
            {
                txtGunSayisi.Text = (cikis.Date - giris.Date).Days.ToString();
            }
            else
            {
                MessageBox.Show("Çıkış tarihi giriş tarihinden sonraki bir gün olmalıdır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbOdaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            BosOdalariGetir();
            DoluOdalariGetir();
        }

        private void cmbOdaKapasitesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            BosOdalariGetir();
            DoluOdalariGetir();
        }

        private void btnTumBosOdalar_Click(object sender, EventArgs e)
        {
            Helper.ControlTemizle(this);
            dgvBosOdalar.DataSource = _bosOdalar;
        }

        private void btnListeyiTemizle_Click(object sender, EventArgs e)
        {
            lboxSecilenOdalar.Items.Clear();
            _fiyat = 0;
            _toplamkapasite = 0;
            Helper.ControlTemizle(this);
            dgvBosOdalar.DataSource = _bosOdalar;
            _bosOdalarSecileniSil = _bosOdalar;
        }

        private void btnRezervasyonaDevamEt_Click(object sender, EventArgs e)
        {
            string hataMesaji = "";
            if (lboxSecilenOdalar.Items.Count == 0)
            {
                hataMesaji += "Lütfen en az bir oda seçiniz.\n";
            }
            if (DtpGirisTarihi.Value.Date == null)
            {
                hataMesaji += "Lütfen bir giriş tarihi seçiniz.\n";
            }
            if (DtpCikisTarihi.Value.Date == null)
            {
                hataMesaji += "Lütfen bir çıkış tarihi seçiniz.\n";
            }
            if (_toplamkapasite < _kisisayisi || string.IsNullOrWhiteSpace(txtToplamKisiSayisi.Text))
            {
                hataMesaji += "Toplam kişi sayısı oda kapasitesinden büyük olamaz ve boş geçilemez. \n";
            }
            if (hataMesaji.Length > 0)
            {
                MessageBox.Show(hataMesaji, "Dikkat");
                return;
            }

            RezervasyonVM rezervasyonVM = new RezervasyonVM();

            foreach (string odaNo in lboxSecilenOdalar.Items)
            {
                rezervasyonVM.SecilenOdaNolar.Add(odaNo);
            }
            rezervasyonVM.GirisTarihi = DtpGirisTarihi.Value.Date;
            rezervasyonVM.CikisTarihi = DtpCikisTarihi.Value.Date;
            rezervasyonVM.Fiyat = _fiyat;

            FormRezerveEdenEkle formRezerveEdenEkle = new FormRezerveEdenEkle(rezervasyonVM);
            formRezerveEdenEkle.Show();
            this.Hide();
        }



        private void DgvBosOdalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtToplamKisiSayisi_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtToplamKisiSayisi.Text))
            {
                _kisisayisi = Convert.ToInt16(txtToplamKisiSayisi.Text);
            }
        }

        private void btnSecilenOdayiAktar_Click(object sender, EventArgs e)
        {

        }

        private void btnSecilenOdayiEkle_Click(object sender, EventArgs e)
        {
            if (dgvBosOdalar.SelectedRows.Count == 1 && _bosOdalarSecileniSil.Count != 0)
            {
                string secilenOdaNo = dgvBosOdalar.SelectedRows[0].Cells["OdaNo"].Value.ToString();
                if (!lboxSecilenOdalar.Items.Contains(secilenOdaNo))
                {
                    lboxSecilenOdalar.Items.Add(secilenOdaNo);
                    _fiyat += Convert.ToDecimal(dgvBosOdalar.SelectedRows[0].Cells["Fiyat"].Value) * _gunsayisi;
                    _toplamkapasite = _toplamkapasite + Convert.ToInt16(dgvBosOdalar.CurrentRow.Cells["OdaKapasitesi"].Value);
                    txtToplamFiyat.Text = _fiyat.ToString();
                    _bosOdalarSecileniSil = _bosOdalarSecileniSil.Where(o => o.OdaNo != secilenOdaNo).ToList();
                }
                txtToplamOdaKapasitesi.Text = _toplamkapasite.ToString();
                dgvBosOdalar.DataSource = _bosOdalarSecileniSil;
            }
            else { MessageBox.Show("Hiçbir oda seçilmedi.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
