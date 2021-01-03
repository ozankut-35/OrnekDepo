using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_HastaneRandevu
{
    public class Brans
    {
        public string Ad { get; set; }
        public static List<Doktor> Doktorlar = new List<Doktor>();
        public static List<Brans> Branslar = new List<Brans>();

        public override string ToString()
        {
            return Ad;
        }
    }
}
