using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GuzellikSalonuOtomasyonu
{
    public partial class KayitForm : Form
    {
        private readonly string connStr = "Server=localhost;Database=guzellik_salon;Uid=root;Pwd=;";

        public KayitForm()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string tc = txtTC.Text.Trim();
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string cins = cmbCinsiyet.SelectedItem?.ToString() ?? "";
            DateTime dt = dtpDogum.Value.Date;
            string sifre = txtSifre.Text;

            if (tc.Length != 11 || ad == "" || soyad == "" || cins == "" || sifre == "")
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    @"INSERT INTO uyeler (tc_no, ad, soyad, cinsiyet, dogum_tarihi, sifre)
                      VALUES(@tc,@ad,@soy,@c,@dt,@s)", conn);
                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soy", soyad);
                cmd.Parameters.AddWithValue("@c", cins);
                cmd.Parameters.AddWithValue("@dt", dt);
                cmd.Parameters.AddWithValue("@s", sifre);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kayıt başarılı!", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            var girisForm = new Form1();
            girisForm.Show();
            this.Close();
        }
    }
}
