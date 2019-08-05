using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu.ViewModel
{
    public class RezervasyonVM
    {
        public List<string> SecilenOdaNolar = new List<string>();
        public DateTime GirisTarihi;
        public DateTime CikisTarihi;
        public decimal Fiyat;
    }
}
