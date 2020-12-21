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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            TV tv = new TV();
            tv.marka = "LG";
            tv.model = "LG 55BX6";
            tv.renk = "Siyah";
            tv.fiyat = 10000;
            comboBox1.Items.Add(tv.marka);
            comboBox2.Items.Add(tv.model);
            comboBox3.Items.Add(tv.renk);
            comboBox5.Items.Add(tv.fiyat);
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
