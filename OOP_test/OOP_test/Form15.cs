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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            Yatak ytk = new Yatak();
            ytk.marka = "Yataş";
            ytk.fiyat =3000;
            ytk.model = "Joyful 300";
            ytk.garanti = 2;
            comboBox1.Items.Add(ytk.marka);
            comboBox2.Items.Add(ytk.fiyat);
            comboBox3.Items.Add(ytk.model);
            comboBox5.Items.Add(ytk.garanti);
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
