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
    public partial class BransForm : Form
    {
        public BransForm()
        {
            InitializeComponent();
        }

        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            Brans brans = new Brans();
            brans.Ad = txtBrans.Text;
            listView1.Items.Add(brans.Ad);
            Brans.Branslar.Add(brans);

        }

        private void BransForm_Load(object sender, EventArgs e)
        {

        }
    }
}
