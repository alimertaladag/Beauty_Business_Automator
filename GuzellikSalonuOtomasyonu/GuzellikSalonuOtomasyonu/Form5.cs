using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GuzellikSalonuOtomasyonu
{
    public partial class RandevuIptalForm : Form
    {
        private int uyeId; // Kullanıcı ID'si

        public RandevuIptalForm(int uyeId)
        {
            InitializeComponent();
            this.uyeId = uyeId;
            LoadUserAppointments();
        }

        // Kullanıcının randevularını yükleyen metod
        private void LoadUserAppointments()
        {
            string connectionString = "server=localhost;database=guzellik_salon;user=root;password="; // Veritabanı bağlantı dizesi
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, tarih, durum FROM randevular WHERE uye_id = @uyeId AND durum = 'Beklemede'";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@uyeId", uyeId);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        // Randevu iptal etme metod
        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int randevuId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value); // Seçilen randevunun ID'si
                string connectionString = "server=localhost;database=guzellik_salon;user=root;password=";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string updateQuery = "UPDATE randevular SET durum = 'İptal' WHERE id = @randevuId";
                        MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@randevuId", randevuId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Randevu iptal edildi.");
                            LoadUserAppointments(); // Güncel randevuları yeniden yükle
                        }
                        else
                        {
                            MessageBox.Show("İptal işlemi başarısız.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen iptal etmek için bir randevu seçin.");
            }
        }
    }
}
