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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            Motor mt = new Motor();
            mt.guc = 4800;
            mt.cesit = "Kıpor KDE12STA";
            mt.calismasekli = "Marşlı";
            mt.yakitKapasitesi = 25;
            comboBox1.Items.Add(mt.guc);
            comboBox2.Items.Add(mt.cesit);
            comboBox3.Items.Add(mt.calismasekli);
            comboBox4.Items.Add(mt.yakitKapasitesi);
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
