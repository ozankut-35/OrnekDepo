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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PC bilgisayar = new PC();
            bilgisayar.marka = "Monstar";
            bilgisayar.model = "Abra";
            bilgisayar.fiyat = 7799;
            bilgisayar.islemci = "intel i5";
            comboBox1.Items.Add(bilgisayar.marka);
            comboBox2.Items.Add(bilgisayar.model);
            comboBox3.Items.Add(bilgisayar.fiyat);
            comboBox4.Items.Add(bilgisayar.islemci);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Markası:"+comboBox1.SelectedItem);
            listBox1.Items.Add("Modeli:"+comboBox2.SelectedItem);
            listBox1.Items.Add("Fiyatı:"+comboBox3.SelectedItem +"TL");
            listBox1.Items.Add("İslemci:"+comboBox4.SelectedItem);
      
        }
    }
}
