using System.Drawing;
using System.Windows.Forms;
using System;

namespace GuzellikSalonuOtomasyonu
{
    partial class ProfilForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTC, lblAd, lblSoyad, lblCins, lblDT;
        private TextBox txtTC, txtAd, txtSoyad;
        private ComboBox cmbCinsiyet;
        private DateTimePicker dtpDogum;
        private Button btnGuncelle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTC = new Label();
            this.txtTC = new TextBox();
            this.lblAd = new Label();
            this.txtAd = new TextBox();
            this.lblSoyad = new Label();
            this.txtSoyad = new TextBox();
            this.lblCins = new Label();
            this.cmbCinsiyet = new ComboBox();
            this.lblDT = new Label();
            this.dtpDogum = new DateTimePicker();
            this.btnGuncelle = new Button();
            this.SuspendLayout();
            // 
            // Form
            // 
            this.BackColor = ColorTranslator.FromHtml("#FCE4EC");
            this.Font = new Font("Segoe UI Semibold", 10F);
            this.ClientSize = new Size(360, 300);
            this.Text = "Profil Düzenle";
            // 
            // lblTC
            // 
            this.lblTC.Text = "TC Kimlik No:";
            this.lblTC.Location = new Point(20, 20);
            // 
            // txtTC
            // 
            this.txtTC.Location = new Point(140, 17);
            this.txtTC.ReadOnly = true;
            this.txtTC.BorderStyle = BorderStyle.None;
            // Alt çizgi paneli
            var pnlTC = new Panel
            {
                BackColor = ColorTranslator.FromHtml("#E1BEE7"),
                Height = 2,
                Width = 180,
                Location = new Point(140, 37)
            };
            this.Controls.Add(pnlTC);
            // 
            // lblAd / txtAd
            // 
            this.lblAd.Text = "Ad:";
            this.lblAd.Location = new Point(20, 60);
            this.txtAd.Location = new Point(140, 57);
            this.txtAd.BorderStyle = BorderStyle.None;
            var pnlAd = new Panel
            {
                BackColor = ColorTranslator.FromHtml("#E1BEE7"),
                Height = 2,
                Width = 180,
                Location = new Point(140, 77)
            };
            this.Controls.Add(pnlAd);
            // 
            // lblSoyad / txtSoyad
            // 
            this.lblSoyad.Text = "Soyad:";
            this.lblSoyad.Location = new Point(20, 100);
            this.txtSoyad.Location = new Point(140, 97);
            this.txtSoyad.BorderStyle = BorderStyle.None;
            var pnlSoyad = new Panel
            {
                BackColor = ColorTranslator.FromHtml("#E1BEE7"),
                Height = 2,
                Width = 180,
                Location = new Point(140, 117)
            };
            this.Controls.Add(pnlSoyad);
            // 
            // lblCins / cmbCinsiyet
            // 
            this.lblCins.Text = "Cinsiyet:";
            this.lblCins.Location = new Point(20, 140);
            this.cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın", "Diğer" });
            this.cmbCinsiyet.Location = new Point(140, 137);
            this.cmbCinsiyet.Width = 180;
            // 
            // lblDT / dtpDogum
            // 
            this.lblDT.Text = "Doğum Tarihi:";
            this.lblDT.Location = new Point(20, 180);
            this.dtpDogum.Format = DateTimePickerFormat.Short;
            this.dtpDogum.Location = new Point(140, 177);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Location = new Point(140, 230);
            this.btnGuncelle.Size = new Size(100, 35);
            this.btnGuncelle.FlatStyle = FlatStyle.Flat;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#CE93D8");
            this.btnGuncelle.BackColor = ColorTranslator.FromHtml("#E1BEE7");
            this.btnGuncelle.ForeColor = Color.White;
            this.btnGuncelle.Click += new EventHandler(this.btnGuncelle_Click);
            // 
            // Kontrolleri ekle
            // 
            this.Controls.AddRange(new Control[] {
                lblTC, txtTC,
                lblAd, txtAd,
                lblSoyad, txtSoyad,
                lblCins, cmbCinsiyet,
                lblDT, dtpDogum,
                btnGuncelle
            });
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
