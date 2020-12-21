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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            Halı hali = new Halı();
            hali.fiyat = 5000;
            hali.uzunluk = 3.2;
            hali.cesidi = "kilim";
            hali.marka = "merşnos";
            comboBox1.Items.Add(hali.fiyat);
            comboBox2.Items.Add(hali.uzunluk);
            comboBox3.Items.Add(hali.cesidi);
            comboBox5.Items.Add(hali.marka);
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
