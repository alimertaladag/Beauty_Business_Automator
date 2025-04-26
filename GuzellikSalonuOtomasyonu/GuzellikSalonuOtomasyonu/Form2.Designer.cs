namespace GuzellikSalonuOtomasyonu
{
    partial class KayitForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTC, lblAd, lblSoyad, lblCins, lblDT, lblSifre;
        private System.Windows.Forms.TextBox txtTC, txtAd, txtSoyad, txtSifre;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker dtpDogum;
        private System.Windows.Forms.Button btnKayit, btnGeri;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTC = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            var pnlTC = new System.Windows.Forms.Panel();

            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            var pnlAd = new System.Windows.Forms.Panel();

            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            var pnlSoyad = new System.Windows.Forms.Panel();

            this.lblCins = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();

            this.lblDT = new System.Windows.Forms.Label();
            this.dtpDogum = new System.Windows.Forms.DateTimePicker();

            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            var pnlSifre = new System.Windows.Forms.Panel();

            this.btnKayit = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Form Ayarları
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Text = "Üye Ol";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#FCE4EC");
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);

            // TC
            lblTC.Text = "TC Kimlik No:";
            lblTC.Location = new System.Drawing.Point(30, 30);
            txtTC.Location = new System.Drawing.Point(160, 27);
            txtTC.MaxLength = 11;
            txtTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pnlTC.BackColor = System.Drawing.ColorTranslator.FromHtml("#E1BEE7");
            pnlTC.Size = new System.Drawing.Size(200, 2);
            pnlTC.Location = new System.Drawing.Point(160, 47);

            // Ad
            lblAd.Text = "Ad:";
            lblAd.Location = new System.Drawing.Point(30, 80);
            txtAd.Location = new System.Drawing.Point(160, 77);
            txtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pnlAd.BackColor = System.Drawing.ColorTranslator.FromHtml("#E1BEE7");
            pnlAd.Size = new System.Drawing.Size(200, 2);
            pnlAd.Location = new System.Drawing.Point(160, 97);

            // Soyad
            lblSoyad.Text = "Soyad:";
            lblSoyad.Location = new System.Drawing.Point(30, 130);
            txtSoyad.Location = new System.Drawing.Point(160, 127);
            txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pnlSoyad.BackColor = System.Drawing.ColorTranslator.FromHtml("#E1BEE7");
            pnlSoyad.Size = new System.Drawing.Size(200, 2);
            pnlSoyad.Location = new System.Drawing.Point(160, 147);

            // Cinsiyet
            lblCins.Text = "Cinsiyet:";
            lblCins.Location = new System.Drawing.Point(30, 180);
            cmbCinsiyet.Location = new System.Drawing.Point(160, 177);
            cmbCinsiyet.Size = new System.Drawing.Size(200, 25);
            cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın", "Diğer" });

            // Doğum Tarihi
            lblDT.Text = "Doğum Tarihi:";
            lblDT.Location = new System.Drawing.Point(30, 230);
            dtpDogum.Location = new System.Drawing.Point(160, 227);
            dtpDogum.Size = new System.Drawing.Size(200, 25);
            dtpDogum.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Şifre
            lblSifre.Text = "Şifre:";
            lblSifre.Location = new System.Drawing.Point(30, 280);
            txtSifre.Location = new System.Drawing.Point(160, 277);
            txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSifre.UseSystemPasswordChar = true;
            pnlSifre.BackColor = System.Drawing.ColorTranslator.FromHtml("#E1BEE7");
            pnlSifre.Size = new System.Drawing.Size(200, 2);
            pnlSifre.Location = new System.Drawing.Point(160, 297);

            // Kayıt Butonu
            btnKayit.Text = "Kayıt Ol";
            btnKayit.Location = new System.Drawing.Point(160, 330);
            btnKayit.Size = new System.Drawing.Size(120, 40);
            btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnKayit.BackColor = System.Drawing.ColorTranslator.FromHtml("#E1BEE7");
            btnKayit.ForeColor = System.Drawing.Color.White;
            btnKayit.FlatAppearance.BorderSize = 0;
            btnKayit.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#CE93D8");
            btnKayit.Click += new System.EventHandler(this.btnKayit_Click);

            // Geri Butonu
            btnGeri.Text = "← Geri";
            btnGeri.Location = new System.Drawing.Point(30, 330);
            btnGeri.Size = new System.Drawing.Size(100, 40);
            btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGeri.BackColor = System.Drawing.ColorTranslator.FromHtml("#E1BEE7");
            btnGeri.ForeColor = System.Drawing.Color.White;
            btnGeri.FlatAppearance.BorderSize = 0;
            btnGeri.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#CE93D8");
            btnGeri.Click += new System.EventHandler(this.btnGeri_Click);

            // Kontroller
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblTC, txtTC, pnlTC,
                lblAd, txtAd, pnlAd,
                lblSoyad, txtSoyad, pnlSoyad,
                lblCins, cmbCinsiyet,
                lblDT, dtpDogum,
                lblSifre, txtSifre, pnlSifre,
                btnKayit, btnGeri
            });

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
