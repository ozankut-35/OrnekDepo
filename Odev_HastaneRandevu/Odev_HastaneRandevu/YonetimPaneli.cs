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
    public partial class YonetimPaneli : Form
    {
        public YonetimPaneli()
        {
            InitializeComponent();
        }

        private void YonetimPaneli_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();

            kullanici.KullaniciAdi = txtKullaniciAdi.Text.ToLower();
            kullanici.Sifre = txtSifre.Text;
           
            
                switch (kullanici.KullaniciAdi)
                {
                    case "admin":
                        switch (kullanici.Sifre)
                        {
                            case "1234":
                                MdiForm mdiForm = new MdiForm();
                                mdiForm.Show();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                                break;
                        }
                        break;
                    default:
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                        break;
                }
            
        }
    }
}
