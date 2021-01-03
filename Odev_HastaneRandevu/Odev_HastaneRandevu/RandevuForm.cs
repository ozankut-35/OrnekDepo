using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_HastaneRandevu
{
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();
        }

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            foreach (Randevu randevu in Randevu.Randevular)
            {
                string[] randevuBilgileri = { randevu.Ad,randevu.Soyad,randevu.Brans.ToString(),randevu.Doktor.ToString(),randevu.Tarih.ToShortDateString() };

                ListViewItem listViewItem = new ListViewItem(randevuBilgileri);
                listView1.Items.Add(listViewItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
