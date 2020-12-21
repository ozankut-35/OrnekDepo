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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Bardak brdk = new Bardak();
            brdk.fiyat = 10;
            brdk.marka = "Paşabahçe";
            brdk.rengi = "mavi";
            brdk.turu = "Çay bardağı";
            comboBox1.Items.Add(brdk.fiyat);
            comboBox2.Items.Add(brdk.marka);
            comboBox3.Items.Add(brdk.rengi);
            comboBox4.Items.Add(brdk.turu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem);
            listBox1.Items.Add(comboBox2.SelectedItem);
            listBox1.Items.Add(comboBox3.SelectedItem);
            listBox1.Items.Add(comboBox4.SelectedItem);

        }
    }
}
