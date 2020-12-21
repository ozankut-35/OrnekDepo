using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_test
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            Kalem klm = new Kalem();
            klm.tur = "Tükenmez kalem";
            klm.fiyat = 45;
            klm.renk = "siyah";
            klm.marka = "Faber Castel";
            comboBox1.Items.Add(klm.fiyat);
            comboBox2.Items.Add(klm.tur);
            comboBox3.Items.Add(klm.marka);
            comboBox5.Items.Add(klm.renk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem);
            listBox1.Items.Add(comboBox2.SelectedItem);
            listBox1.Items.Add(comboBox3.SelectedItem);
            listBox1.Items.Add(comboBox5.SelectedItem);
        }
    }
}
