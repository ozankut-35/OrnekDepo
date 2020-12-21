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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            Motorsiklet motor = new Motorsiklet();
            motor.marka = "Yamaha";
            motor.model = "mt500";
            motor.yili = 2017;
            motor.rengi = "kırmızı";
            
            comboBox1.Items.Add(motor.marka);
            comboBox2.Items.Add(motor.model);
            comboBox3.Items.Add(motor.yili);
            comboBox4.Items.Add(motor.rengi);
            
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
