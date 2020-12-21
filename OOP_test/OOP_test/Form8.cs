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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Kitap ktp = new Kitap();
            ktp.kitapadi = "Armagedon ";
            ktp.tur = "Gerilim";
            ktp.fiyat = 50;
            ktp.yazar = "Aydoğan Vatandaş";
            ktp.baskiyili = 2020;
            comboBox5.Items.Add(ktp.kitapadi);
            comboBox1.Items.Add(ktp.tur);
            comboBox1.Items.Add(ktp.fiyat);
            comboBox1.Items.Add(ktp.baskiyili);
            comboBox1.Items.Add(ktp.tur);
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
