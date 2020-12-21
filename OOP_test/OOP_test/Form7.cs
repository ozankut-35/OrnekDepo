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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Dolap dlp = new Dolap();
            dlp.renk = "mavi";
            dlp.fiyat = 2100;
            dlp.kapaksayisi = 3;
            dlp.marka = "Enzo Mobilya";
            comboBox1.Items.Add(dlp.renk);
            comboBox2.Items.Add(dlp.fiyat);
            comboBox3.Items.Add(dlp.kapaksayisi);
            comboBox5.Items.Add(dlp.marka);
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
