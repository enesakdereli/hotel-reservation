using OtelRezervasyonu.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu.ViewModel
{
    class TumOdalarView
    {
        public int OdaID { get; set; }
        public string OdaNo { get; set; }
        public OdaKapasitesiEnum OdaKapasitesi { get; set; }
        public OdaTuruEnum OdaTuru { get; set; }
        public decimal Fiyat { get; set; }
        public bool Silindi { get; set; }
    }
}
