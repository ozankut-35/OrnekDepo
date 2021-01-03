
namespace Odev_HastaneRandevu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxBranslar = new System.Windows.Forms.GroupBox();
            this.btnBransEkle = new System.Windows.Forms.Button();
            this.txtBrans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDoktorEkle = new System.Windows.Forms.GroupBox();
            this.cmbDoktorBrans = new System.Windows.Forms.ComboBox();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.txtDoktor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxRandevu = new System.Windows.Forms.GroupBox();
            this.dpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbRandevuDoktor = new System.Windows.Forms.ComboBox();
            this.cmbRandevuBrans = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTcKn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flpSaatler = new System.Windows.Forms.FlowLayoutPanel();
            this.lvwRandevular = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxBranslar.SuspendLayout();
            this.gbDoktorEkle.SuspendLayout();
            this.gbxRandevu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBranslar
            // 
            this.gbxBranslar.Controls.Add(this.btnBransEkle);
            this.gbxBranslar.Controls.Add(this.txtBrans);
            this.gbxBranslar.Controls.Add(this.label1);
            this.gbxBranslar.Location = new System.Drawing.Point(17, 13);
            this.gbxBranslar.Margin = new System.Windows.Forms.Padding(4);
            this.gbxBranslar.Name = "gbxBranslar";
            this.gbxBranslar.Padding = new System.Windows.Forms.Padding(4);
            this.gbxBranslar.Size = new System.Drawing.Size(307, 176);
            this.gbxBranslar.TabIndex = 0;
            this.gbxBranslar.TabStop = false;
            this.gbxBranslar.Text = "Branş";
            // 
            // btnBransEkle
            // 
            this.btnBransEkle.Location = new System.Drawing.Point(28, 114);
            this.btnBransEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnBransEkle.Name = "btnBransEkle";
            this.btnBransEkle.Size = new System.Drawing.Size(204, 28);
            this.btnBransEkle.TabIndex = 2;
            this.btnBransEkle.Text = "Branş Ekle";
            this.btnBransEkle.UseVisualStyleBackColor = true;
            this.btnBransEkle.Click += new System.EventHandler(this.btnBransEkle_Click);
            // 
            // txtBrans
            // 
            this.txtBrans.Location = new System.Drawing.Point(28, 82);
            this.txtBrans.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrans.Name = "txtBrans";
            this.txtBrans.Size = new System.Drawing.Size(203, 22);
            this.txtBrans.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branş Adı:";
            // 
            // gbDoktorEkle
            // 
            this.gbDoktorEkle.Controls.Add(this.cmbDoktorBrans);
            this.gbDoktorEkle.Controls.Add(this.btnDoktorEkle);
            this.gbDoktorEkle.Controls.Add(this.txtDoktor);
            this.gbDoktorEkle.Controls.Add(this.label2);
            this.gbDoktorEkle.Location = new System.Drawing.Point(333, 13);
            this.gbDoktorEkle.Margin = new System.Windows.Forms.Padding(4);
            this.gbDoktorEkle.Name = "gbDoktorEkle";
            this.gbDoktorEkle.Padding = new System.Windows.Forms.Padding(4);
            this.gbDoktorEkle.Size = new System.Drawing.Size(336, 176);
            this.gbDoktorEkle.TabIndex = 1;
            this.gbDoktorEkle.TabStop = false;
            this.gbDoktorEkle.Text = "Doktor Ekle";
            // 
            // cmbDoktorBrans
            // 
            this.cmbDoktorBrans.FormattingEnabled = true;
            this.cmbDoktorBrans.Location = new System.Drawing.Point(65, 86);
            this.cmbDoktorBrans.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDoktorBrans.Name = "cmbDoktorBrans";
            this.cmbDoktorBrans.Size = new System.Drawing.Size(203, 24);
            this.cmbDoktorBrans.TabIndex = 3;
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.Location = new System.Drawing.Point(65, 124);
            this.btnDoktorEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(204, 28);
            this.btnDoktorEkle.TabIndex = 2;
            this.btnDoktorEkle.Text = "Doktor Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // txtDoktor
            // 
            this.txtDoktor.Location = new System.Drawing.Point(65, 53);
            this.txtDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoktor.Name = "txtDoktor";
            this.txtDoktor.Size = new System.Drawing.Size(203, 22);
            this.txtDoktor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doktor Adı:";
            // 
            // gbxRandevu
            // 
            this.gbxRandevu.Controls.Add(this.dpRandevuTarihi);
            this.gbxRandevu.Controls.Add(this.cmbRandevuDoktor);
            this.gbxRandevu.Controls.Add(this.cmbRandevuBrans);
            this.gbxRandevu.Controls.Add(this.label8);
            this.gbxRandevu.Controls.Add(this.label7);
            this.gbxRandevu.Controls.Add(this.txtSoyad);
            this.gbxRandevu.Controls.Add(this.label6);
            this.gbxRandevu.Controls.Add(this.label5);
            this.gbxRandevu.Controls.Add(this.txtAd);
            this.gbxRandevu.Controls.Add(this.label4);
            this.gbxRandevu.Controls.Add(this.txtTcKn);
            this.gbxRandevu.Controls.Add(this.label3);
            this.gbxRandevu.Location = new System.Drawing.Point(17, 197);
            this.gbxRandevu.Margin = new System.Windows.Forms.Padding(4);
            this.gbxRandevu.Name = "gbxRandevu";
            this.gbxRandevu.Padding = new System.Windows.Forms.Padding(4);
            this.gbxRandevu.Size = new System.Drawing.Size(308, 237);
            this.gbxRandevu.TabIndex = 2;
            this.gbxRandevu.TabStop = false;
            this.gbxRandevu.Text = "Randevu Bilgileri";
            // 
            // dpRandevuTarihi
            // 
            this.dpRandevuTarihi.Location = new System.Drawing.Point(125, 205);
            this.dpRandevuTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dpRandevuTarihi.Name = "dpRandevuTarihi";
            this.dpRandevuTarihi.Size = new System.Drawing.Size(160, 22);
            this.dpRandevuTarihi.TabIndex = 3;
            this.dpRandevuTarihi.ValueChanged += new System.EventHandler(this.dpRandevuTarihi_ValueChanged);
            // 
            // cmbRandevuDoktor
            // 
            this.cmbRandevuDoktor.FormattingEnabled = true;
            this.cmbRandevuDoktor.Location = new System.Drawing.Point(125, 162);
            this.cmbRandevuDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRandevuDoktor.Name = "cmbRandevuDoktor";
            this.cmbRandevuDoktor.Size = new System.Drawing.Size(160, 24);
            this.cmbRandevuDoktor.TabIndex = 2;
            // 
            // cmbRandevuBrans
            // 
            this.cmbRandevuBrans.FormattingEnabled = true;
            this.cmbRandevuBrans.Location = new System.Drawing.Point(125, 129);
            this.cmbRandevuBrans.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRandevuBrans.Name = "cmbRandevuBrans";
            this.cmbRandevuBrans.Size = new System.Drawing.Size(160, 24);
            this.cmbRandevuBrans.TabIndex = 2;
            this.cmbRandevuBrans.SelectedIndexChanged += new System.EventHandler(this.cmbRandevuBrans_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Doktor:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(125, 91);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(149, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(125, 59);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(149, 22);
            this.txtAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad:";
            // 
            // txtTcKn
            // 
            this.txtTcKn.Location = new System.Drawing.Point(125, 27);
            this.txtTcKn.Margin = new System.Windows.Forms.Padding(4);
            this.txtTcKn.Name = "txtTcKn";
            this.txtTcKn.Size = new System.Drawing.Size(149, 22);
            this.txtTcKn.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tc Kimlik No:";
            // 
            // flpSaatler
            // 
            this.flpSaatler.Location = new System.Drawing.Point(333, 197);
            this.flpSaatler.Margin = new System.Windows.Forms.Padding(4);
            this.flpSaatler.Name = "flpSaatler";
            this.flpSaatler.Size = new System.Drawing.Size(339, 237);
            this.flpSaatler.TabIndex = 3;
            // 
            // lvwRandevular
            // 
            this.lvwRandevular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwRandevular.GridLines = true;
            this.lvwRandevular.HideSelection = false;
            this.lvwRandevular.Location = new System.Drawing.Point(17, 442);
            this.lvwRandevular.Margin = new System.Windows.Forms.Padding(4);
            this.lvwRandevular.Name = "lvwRandevular";
            this.lvwRandevular.Size = new System.Drawing.Size(909, 300);
            this.lvwRandevular.TabIndex = 4;
            this.lvwRandevular.UseCompatibleStateImageBehavior = false;
            this.lvwRandevular.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hasta Adı";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hasta Soyadı";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Branş";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doktor";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Randevu Tarihi";
            this.columnHeader5.Width = 178;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 755);
            this.Controls.Add(this.lvwRandevular);
            this.Controls.Add(this.flpSaatler);
            this.Controls.Add(this.gbxRandevu);
            this.Controls.Add(this.gbDoktorEkle);
            this.Controls.Add(this.gbxBranslar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxBranslar.ResumeLayout(false);
            this.gbxBranslar.PerformLayout();
            this.gbDoktorEkle.ResumeLayout(false);
            this.gbDoktorEkle.PerformLayout();
            this.gbxRandevu.ResumeLayout(false);
            this.gbxRandevu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBranslar;
        private System.Windows.Forms.Button btnBransEkle;
        private System.Windows.Forms.TextBox txtBrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDoktorEkle;
        private System.Windows.Forms.ComboBox cmbDoktorBrans;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.TextBox txtDoktor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxRandevu;
        private System.Windows.Forms.DateTimePicker dpRandevuTarihi;
        private System.Windows.Forms.ComboBox cmbRandevuDoktor;
        private System.Windows.Forms.ComboBox cmbRandevuBrans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTcKn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpSaatler;
        private System.Windows.Forms.ListView lvwRandevular;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

