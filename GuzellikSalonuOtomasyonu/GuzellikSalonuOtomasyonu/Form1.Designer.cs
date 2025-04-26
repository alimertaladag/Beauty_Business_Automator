using System.Drawing;
using System.Windows.Forms;
using System;

namespace GuzellikSalonuOtomasyonu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTC, lblSifre;
        private TextBox txtTC, txtSifre;
        private Button btnGiris;
        private LinkLabel linkKayit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTC = new Label();
            this.txtTC = new TextBox();
            this.lblSifre = new Label();
            this.txtSifre = new TextBox();
            this.btnGiris = new Button();
            this.linkKayit = new LinkLabel();
            this.SuspendLayout();
            // 
            // Form genel tasarım
            // 
            this.BackColor = ColorTranslator.FromHtml("#FCE4EC");
            this.Font = new Font("Segoe UI Semibold", 10F);
            this.ClientSize = new Size(360, 260);
            this.Text = "Güzellik Salonu Giriş";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new Point(30, 30);
            this.lblTC.Text = "TC Kimlik No:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new Point(140, 27);
            this.txtTC.MaxLength = 11;
            this.txtTC.BorderStyle = BorderStyle.None;
            this.txtTC.Padding = new Padding(0, 5, 0, 5);
            // Alt çizgi
            var pnlTC = new Panel
            {
                BackColor = ColorTranslator.FromHtml("#E1BEE7"),
                Height = 2,
                Width = 180,
                Location = new Point(140, 47)
            };
            this.Controls.Add(pnlTC);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new Point(30, 80);
            this.lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new Point(140, 77);
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.BorderStyle = BorderStyle.None;
            this.txtSifre.Padding = new Padding(0, 5, 0, 5);
            var pnlSifre = new Panel
            {
                BackColor = ColorTranslator.FromHtml("#E1BEE7"),
                Height = 2,
                Width = 180,
                Location = new Point(140, 97)
            };
            this.Controls.Add(pnlSifre);
            // 
            // btnGiris
            // 
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Location = new Point(140, 130);
            this.btnGiris.Size = new Size(100, 35);
            this.btnGiris.FlatStyle = FlatStyle.Flat;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#CE93D8");
            this.btnGiris.BackColor = ColorTranslator.FromHtml("#E1BEE7");
            this.btnGiris.ForeColor = Color.White;
            this.btnGiris.Click += new EventHandler(this.btnGiris_Click);
            // 
            // linkKayit
            // 
            this.linkKayit.Text = "Üye Ol";
            this.linkKayit.Location = new Point(260, 135);
            this.linkKayit.LinkColor = ColorTranslator.FromHtml("#AB47BC");
            this.linkKayit.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkKayit_LinkClicked);
            // 
            // Kontrolleri ekle
            // 
            this.Controls.AddRange(new Control[] {
                lblTC, txtTC, lblSifre, txtSifre, btnGiris, linkKayit
            });
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
