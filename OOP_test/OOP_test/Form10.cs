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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            masa ms = new masa();
            ms.tur = "bahçe masası";
            ms.ayaksayisi = 3;
            ms.yapısı = "tahta";
            ms.marka = "bahous";
            comboBox1.Items.Add(ms.tur);
            comboBox2.Items.Add(ms.ayaksayisi);
            comboBox3.Items.Add(ms.yapısı);
            comboBox5.Items.Add(ms.marka);
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
