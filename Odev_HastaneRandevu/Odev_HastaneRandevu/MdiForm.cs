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
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }

        RandevuOlustur randevuOlustur = new RandevuOlustur();
        BransForm bransForm = new BransForm();
        DoktorForm doktorForm = new DoktorForm();
        RandevuForm randevuForm = new RandevuForm();

        private void randevuOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {

            randevularToolStripMenuItem.Enabled = true;
            randevuOlustur.MdiParent = this;
            randevuOlustur.Show();
        }

        private void branşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doktorToolStripMenuItem.Enabled = true;
            bransForm.MdiParent = this;
            bransForm.Show();
        }

        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            randevuOlusturToolStripMenuItem.Enabled=true;
            doktorForm.MdiParent = this;
            doktorForm.Show();
        }

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            randevuForm.MdiParent = this;
            randevuForm.Show();
        }

        private void MdiForm_Load(object sender, EventArgs e)
        {
            doktorToolStripMenuItem.Enabled = false;
            randevularToolStripMenuItem.Enabled = false;
            randevuOlusturToolStripMenuItem.Enabled = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
