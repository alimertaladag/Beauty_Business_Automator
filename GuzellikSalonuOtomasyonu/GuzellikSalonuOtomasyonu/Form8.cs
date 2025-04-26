using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GuzellikSalonuOtomasyonu
{
    public partial class RandevuOnayForm : Form
    {
        public RandevuOnayForm()
        {
            InitializeComponent();
            LoadPendingAppointments();
        }

        // Beklemede olan randevuları yükleyen metod
        private void LoadPendingAppointments()
        {
            string connectionString = "server=localhost;database=guzellik_salon;user=root;password=";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, tarih, durum, uye_id FROM randevular WHERE durum = 'Beklemede'";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

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

        // Randevu onaylama işlemi
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int randevuId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string connectionString = "server=localhost;database=guzellik_salon;user=root;password=";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string updateQuery = "UPDATE randevular SET durum = 'Onaylandı' WHERE id = @randevuId";
                        MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@randevuId", randevuId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Randevu onaylandı.");
                            LoadPendingAppointments(); // Güncel randevuları yeniden yükle
                        }
                        else
                        {
                            MessageBox.Show("Onay işlemi başarısız.");
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
                MessageBox.Show("Lütfen onaylamak için bir randevu seçin.");
            }
        }
    }
}
