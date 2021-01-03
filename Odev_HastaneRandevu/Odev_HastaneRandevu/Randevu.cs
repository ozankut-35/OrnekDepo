using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_HastaneRandevu
{
    public class Randevu
    {
        public string Tckn { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Doktor Doktor { get; set; }
        public Brans Brans { get; set; }
        public string Saat { get; set; }
        public DateTime Tarih { get; set; }

        public static List<Randevu> Randevular = new List<Randevu>();
    }
}
