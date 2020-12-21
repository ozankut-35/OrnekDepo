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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba araba = new Araba();
            araba.marka = "Audi";
            araba.model = "A3";
            araba.yili = 2020;
            araba.rengi = "beyaz";
            araba.vites = "otomatik";
            Araba araba1 = new Araba();
            araba1.model = "A5";
            araba1.yili = 2019;
            araba1.rengi = "Kırmızı";
            araba1.vites = "otomatik";
            comboBox1.Items.Add(araba.marka);
            comboBox2.Items.Add(araba.model);
            comboBox2.Items.Add(araba1.model);
            comboBox3.Items.Add(araba.yili);
            comboBox3.Items.Add(araba1.yili);
            comboBox4.Items.Add(araba.rengi);
            comboBox4.Items.Add(araba1.rengi);
            comboBox5.Items.Add(araba.vites);

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
