using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GuzellikSalonuOtomasyonu
{
    public partial class RandevuForm : Form
    {
        private readonly int uyeId;
        private readonly string connStr = "Server=localhost;Database=guzellik_salon;Uid=root;Pwd=;";
        private Button seciliButon = null;

        public RandevuForm(int uyeId)
        {
            this.uyeId = uyeId;
            InitializeComponent();
            OlusturSaatButonlari();
        }

        private void OlusturSaatButonlari()
        {
            TimeSpan bas = new TimeSpan(9, 0, 0);
            TimeSpan bit = new TimeSpan(17, 0, 0);
            TimeSpan yarimSaat = new TimeSpan(0, 30, 0);

            for (var ts = bas; ts <= bit; ts += yarimSaat)
            {
                var btn = new Button
                {
                    Text = ts.ToString(@"hh\:mm"),
                    Width = 80,
                    Height = 40,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = ColorTranslator.FromHtml("#E1BEE7"),
                    ForeColor = Color.White,
                    Tag = ts,
                    Margin = new Padding(5)
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#CE93D8");
                btn.Click += SaatButon_Click;
                flpSaatler.Controls.Add(btn);
            }
        }

        private void SaatButon_Click(object sender, EventArgs e)
        {
            if (seciliButon != null)
                seciliButon.BackColor = ColorTranslator.FromHtml("#E1BEE7");

            seciliButon = (Button)sender;
            seciliButon.BackColor = ColorTranslator.FromHtml("#AB47BC");
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            if (seciliButon == null)
            {
                MessageBox.Show("Lütfen bir saat seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime tarih = dtpTarih.Value.Date + (TimeSpan)seciliButon.Tag;
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string q = "INSERT INTO randevular (uye_id, hizmet, tarih) VALUES (@u, @h, @t)";
                using (var cmd = new MySqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@u", uyeId);
                    cmd.Parameters.AddWithValue("@h", cmbHizmet.SelectedItem?.ToString() ?? "Genel");
                    cmd.Parameters.AddWithValue("@t", tarih);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Randevu alındı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
