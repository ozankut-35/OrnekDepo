using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_HastaneRandevu
{
    public partial class RandevuOlustur : Form
    {
        public RandevuOlustur()
        {
            InitializeComponent();
        }

        Randevu randevu = new Randevu();


        private void RandevuOlustur_Load(object sender, EventArgs e)
        {
            cmbRandevuBrans.DataSource = Brans.Branslar.ToList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            List<string> saatler = new List<string>()
            {
                "10.00","10.30","11.00","11.30","12.00","13.00","13.30"
            };

            if (txtTcKimlik.Text == null || txtAd.Text == null || txtSoyad.Text == null || cmbRandevuBrans.SelectedItem == null || cmbRandevuDoktor.SelectedItem == null)
            {
                MessageBox.Show("Bilgi alanları boş bırakılamaz!");
            }
            else
            {
                if (DateTime.Now <= dateTimePicker1.Value.AddMinutes(1))
                {
                    ButonOlustur(saatler);
                }
                else
                {
                    MessageBox.Show("Geçmiş zamanlı randevu oluşturamazsınız!");
                }
               
            }
        }

        private void ButonOlustur(List<string> saatler)
        {
            for (int i = 0; i < saatler.Count; i++)
            {
                Button button = new Button();
                button.Width = 60;
                button.Height = 60;
                button.Text = saatler[i];
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Button_Click;               
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            DialogResult result = MessageBox.Show(dateTimePicker1.Value.ToShortDateString() + " tarihinde" + button.Text + " saatinde randevu oluşturmak istiyor musunuz?","Randevu Talebi",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                button.BackColor = Color.Red;
                button.Enabled = false;

                randevu.Tckn = txtTcKimlik.Text;
                randevu.Ad = txtAd.Text;
                randevu.Soyad = txtSoyad.Text;
                randevu.Tarih = dateTimePicker1.Value;
                randevu.Saat = button.Text;
                randevu.Brans = (Brans)cmbRandevuBrans.SelectedItem;
                randevu.Doktor = (Doktor)cmbRandevuDoktor.SelectedItem;

                Randevu.Randevular.Add(randevu);
            }
            else
            {
                MessageBox.Show("Randevu işleminiz gerçekleştirilememiştir!");
            }
        }

        private void cmbRandevuBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRandevuDoktor.Items.Clear();

            foreach (Doktor doktor in Brans.Doktorlar)
            {
                if (doktor.Brans == cmbRandevuBrans.SelectedItem)
                {
                    cmbRandevuDoktor.Items.Add(doktor);
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
