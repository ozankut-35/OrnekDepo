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
    public partial class DoktorForm : Form
    {
        public DoktorForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            Doktor doktor = new Doktor();
            doktor.Ad = txtDoktor.Text;
            doktor.Brans = (Brans)cmbDoktorBrans.SelectedItem;
            Brans.Doktorlar.Add(doktor);
           
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = doktor.Ad;
            listViewItem.SubItems.Add(doktor.Brans.ToString());
            listView1.Items.Add(listViewItem);
        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {
            cmbDoktorBrans.DataSource = Brans.Branslar.ToList();
        }
    }
}
