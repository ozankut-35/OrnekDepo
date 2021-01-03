
namespace Odev_HastaneRandevu
{
    partial class MdiForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.randevuOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuOlusturToolStripMenuItem,
            this.yönetimPaneliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1716, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // randevuOlusturToolStripMenuItem
            // 
            this.randevuOlusturToolStripMenuItem.Name = "randevuOlusturToolStripMenuItem";
            this.randevuOlusturToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.randevuOlusturToolStripMenuItem.Text = "Randevu Olustur";
            this.randevuOlusturToolStripMenuItem.Click += new System.EventHandler(this.randevuOlusturToolStripMenuItem_Click);
            // 
            // yönetimPaneliToolStripMenuItem
            // 
            this.yönetimPaneliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.branşToolStripMenuItem,
            this.doktorToolStripMenuItem,
            this.randevularToolStripMenuItem});
            this.yönetimPaneliToolStripMenuItem.Name = "yönetimPaneliToolStripMenuItem";
            this.yönetimPaneliToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.yönetimPaneliToolStripMenuItem.Text = "Yönetim Paneli";
            // 
            // branşToolStripMenuItem
            // 
            this.branşToolStripMenuItem.Name = "branşToolStripMenuItem";
            this.branşToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.branşToolStripMenuItem.Text = "Branş";
            this.branşToolStripMenuItem.Click += new System.EventHandler(this.branşToolStripMenuItem_Click);
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.doktorToolStripMenuItem.Text = "Doktor";
            this.doktorToolStripMenuItem.Click += new System.EventHandler(this.doktorToolStripMenuItem_Click);
            // 
            // randevularToolStripMenuItem
            // 
            this.randevularToolStripMenuItem.Name = "randevularToolStripMenuItem";
            this.randevularToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.randevularToolStripMenuItem.Text = "Randevular";
            this.randevularToolStripMenuItem.Click += new System.EventHandler(this.randevularToolStripMenuItem_Click);
            // 
            // MdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 769);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MdiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MdiForm";
            this.Load += new System.EventHandler(this.MdiForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randevuOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yönetimPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branşToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevularToolStripMenuItem;
    }
}