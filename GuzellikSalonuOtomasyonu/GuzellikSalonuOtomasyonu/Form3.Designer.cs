namespace GuzellikSalonuOtomasyonu
{
    partial class AnasayfaForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnGecmis;
        private System.Windows.Forms.Button btnCikis;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGecmis = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProfil.Location = new System.Drawing.Point(51, 86);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(200, 40);
            this.btnProfil.TabIndex = 0;
            this.btnProfil.Text = "Profil Düzenle";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRandevuAl.Location = new System.Drawing.Point(51, 136);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(200, 40);
            this.btnRandevuAl.TabIndex = 1;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIptal.Location = new System.Drawing.Point(51, 186);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(200, 40);
            this.btnIptal.TabIndex = 2;
            this.btnIptal.Text = "Randevu İptal Et";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGecmis
            // 
            this.btnGecmis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGecmis.Location = new System.Drawing.Point(51, 236);
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.Size = new System.Drawing.Size(200, 40);
            this.btnGecmis.TabIndex = 3;
            this.btnGecmis.Text = "Geçmiş Randevular";
            this.btnGecmis.UseVisualStyleBackColor = false;
            this.btnGecmis.Click += new System.EventHandler(this.btnGecmis_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCikis.Location = new System.Drawing.Point(51, 286);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(200, 40);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnasayfaForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(300, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGecmis);
            this.Controls.Add(this.btnCikis);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.Name = "AnasayfaForm";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button1;
    }
}
