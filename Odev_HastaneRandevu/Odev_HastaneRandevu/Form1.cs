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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hasta randevu sistemi
            /*
             sol tarafta bulunan branş bölümünden herhangi bir branş eklenecek. Eklenen branşlar doktor bilgisinin bulunduğu group box içerisindeki combobox'da görüntülenecek. Doktor bilgiisi girilip branş seçimi yapıldıktan sonra ilgili branş'a tanımlanan doktor dahil edilerek randevu içerisinde bulunan branş'a ait combobox'a gönderilecek.
            Hasta randevu bilgilerini girdikten sonra branş seçimini gerçekleştirdiği anda o branş'a ait doktorlar randevu doktor combobox içerisinde listelenecek. 
            Hasta branş ve doktor seçimini yaptıkran sonra randevu tarihini girecek. Eğer girilen tarih geçmiş bir tarih ise ekranda uyarı gösterilecek "geçmiş bir tarih giremezsiniz!" şeklinde...
            Tarih seçiminin ardından sağ alanda bulunan flowlayout panel içerisine "10:00","10:30","11:00","11:30","12:00" saatlerine ait ayrı ayrı butonlar eklenecek.
            Hasta istemiş olduğu herhangi bir saate tıkladığında bir uyarı mesajı gösterilecek " xxx tarihinde xxxx saatine randevu oluşturmak istiyor musun?" kullanıcı yes butonuna tıkladığında oluşturulan randevu bilgileri formun altında yeralan listview içerisine dahil edilerek ilgili butonun arkaplan rengi kırmızı olarak değiştirilecek. No tuşuna basıldığında herhangi bir işlem yapılmayacak.
             */

            gbxRandevu.Enabled = false;
            txtDoktor.Enabled = false;
            lvwRandevular.Enabled = false;
        }



        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            Brans brans = new Brans();
            brans.BransName = txtBrans.Text;
            Brans.branslar.Add(brans);
            cmbDoktorBrans.Items.Add(brans);
            cmbRandevuBrans.Items.Add(brans);

            txtDoktor.Enabled = true;
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();
            doktor.Adı = txtDoktor.Text;
            Brans brans1 = (Brans)cmbDoktorBrans.SelectedItem;
            doktor.Brans = brans1;
            brans1.doktorlar.Add(doktor);

            Doktor.doktorlar.Add(doktor);

            gbxRandevu.Enabled = true;
        }

        private void cmbRandevuBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRandevuDoktor.Items.Clear();

            foreach (Doktor doktor in Doktor.doktorlar)
            {
                if (doktor.Brans.BransName == cmbRandevuBrans.Text)
                {
                    cmbRandevuDoktor.Items.Add(doktor.Adı);
                }
            }
        }

        private void dpRandevuTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now <= dpRandevuTarihi.Value.AddMinutes(5))
            {
                string[] textler = { "10.00", "10.30", "11.00", "11.30", "12.00", "12.30", "14.00", "14.30", "15.00", "15.30", "16.00", "16.30" };
                foreach (Control control in this.Controls)
                {
                    if (control is FlowLayoutPanel)
                    {
                        FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)control;

                        for (int i = 0; i < 12; i++)
                        {
                            Button button = new Button();
                            button.Width = 60;
                            button.Height = 30;
                            button.Text = textler[i];
                            button.Click += Button_Click;
                            flowLayoutPanel.Controls.Add(button);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçmiş bir tarih seçemezsiniz!!!");
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.Adı = txtAd.Text;
            hasta.Soyadı = txtSoyad.Text;

            lvwRandevular.Enabled = true;

            foreach (Button control1 in flpSaatler.Controls)
            {
                if (control1.Capture)
                {
                    DialogResult result = MessageBox.Show(dpRandevuTarihi.Value.ToShortDateString()+" tarihinde "+control1.Text+" saatine randevu almak istediğinize emin misiniz?","",MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Randevunuz oluşturulmuştur,gemiş olsun!");

                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Text = hasta.Adı;
                        listViewItem.SubItems.Add(hasta.Soyadı);
                        listViewItem.SubItems.Add(cmbRandevuBrans.SelectedItem.ToString());
                        listViewItem.SubItems.Add(cmbRandevuDoktor.SelectedItem.ToString());
                        listViewItem.SubItems.Add(dpRandevuTarihi.Value.ToShortDateString() + " " + control1.Text);
                        lvwRandevular.Items.Add(listViewItem);

                        control1.BackColor = Color.Red;
                        control1.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Randevu işleminiz tamamlanamamıştır!");
                    }
                }
            }
        }
    }
}
