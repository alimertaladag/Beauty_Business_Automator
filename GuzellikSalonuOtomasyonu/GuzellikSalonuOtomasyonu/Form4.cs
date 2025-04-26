using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GuzellikSalonuOtomasyonu
{
    public partial class ProfilForm : Form
    {
        private readonly int uyeId;
        private readonly string connStr = "Server=localhost;Database=guzellik_salon;Uid=root;Pwd=;";

        public ProfilForm(int uyeId)
        {
            this.uyeId = uyeId;
            InitializeComponent();
            YukleProfil();
        }

        private void YukleProfil()
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "SELECT tc_no, ad, soyad, cinsiyet, dogum_tarihi FROM uyeler WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", uyeId);
                using (var rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        txtTC.Text = rdr.GetString("tc_no");
                        txtAd.Text = rdr.GetString("ad");
                        txtSoyad.Text = rdr.GetString("soyad");
                        cmbCinsiyet.SelectedItem = rdr.GetString("cinsiyet");
                        dtpDogum.Value = rdr.GetDateTime("dogum_tarihi");
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    @"UPDATE uyeler 
                      SET ad=@ad, soyad=@soy, cinsiyet=@c, dogum_tarihi=@dt 
                      WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                cmd.Parameters.AddWithValue("@soy", txtSoyad.Text.Trim());
                cmd.Parameters.AddWithValue("@c", cmbCinsiyet.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@dt", dtpDogum.Value.Date);
                cmd.Parameters.AddWithValue("@id", uyeId);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Profiliniz güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
