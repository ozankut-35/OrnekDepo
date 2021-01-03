using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_HastaneRandevu
{
    public class Doktor
    {
        public string Ad { get; set; }
        public Brans Brans { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }
}
