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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Ev ev = new Ev();
            ev.fiyat = 1500000;
            ev.HavuzluMu = true;
            ev.oda = "2+1";
            ev.yeri = "İzmir";
            comboBox1.Items.Add(ev.fiyat);
            comboBox2.Items.Add(ev.HavuzluMu);
            comboBox3.Items.Add(ev.oda);
            comboBox1.Items.Add(ev.yeri);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Fiyatı:" + comboBox1.SelectedItem + "TL");
            listBox1.Items.Add("Havuzlu Mu:" + comboBox2.SelectedItem);
            listBox1.Items.Add("Oda Sayısı:" + comboBox3.SelectedItem);
            listBox1.Items.Add("Nerede:" + comboBox4.SelectedItem);
        }
    }
}
