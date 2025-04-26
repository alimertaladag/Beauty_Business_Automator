using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GuzellikSalonuOtomasyonu
{
    public partial class Form1 : Form
    {
        private readonly string connStr = "Server=localhost;Database=guzellik_salon;Uid=root;Pwd=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string tc = txtTC.Text.Trim();
            string sifre = txtSifre.Text;
            if (tc.Length != 11 || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen 11 haneli TC ve şifrenizi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "SELECT id FROM uyeler WHERE tc_no=@tc AND sifre=@sifre", conn);
                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    int uyeId = Convert.ToInt32(result);
                    AnasayfaForm home = new AnasayfaForm(uyeId);
                    home.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("TC veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitForm kf = new KayitForm();
            kf.Show();
            this.Hide();
        }
    }
}
