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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Class1 canta = new Class1();
            canta.fiyat = 56;
            canta.cesit = "spor çantaları";
            canta.renk = "mavi";
            canta.model = "";
            canta.marka = "nike";
            comboBox1.Items.Add(canta.fiyat);
            comboBox2.Items.Add(canta.cesit);
            comboBox3.Items.Add(canta.renk);
            comboBox4.Items.Add(canta.model);
            comboBox5.Items.Add(canta.marka);
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
