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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Telefon tlf = new Telefon();
            tlf.marka = "Samsung";
            tlf.model = "S10";
            tlf.renk = "Uzay mavisi";
            tlf.hafıza = "256 GB";
            tlf.fiyat = 6800;
            comboBox1.Items.Add(tlf.marka);
            comboBox2.Items.Add(tlf.model);
            comboBox3.Items.Add(tlf.renk);
            comboBox4.Items.Add(tlf.hafıza);
            comboBox5.Items.Add(tlf.fiyat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem);
            listBox1.Items.Add(comboBox2.SelectedItem);
            listBox1.Items.Add(comboBox3.SelectedItem);
            listBox1.Items.Add(comboBox4.SelectedItem);
            listBox1.Items.Add(comboBox5.SelectedItem);
        }
    }
}
