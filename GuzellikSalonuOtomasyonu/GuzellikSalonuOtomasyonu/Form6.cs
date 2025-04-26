using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GuzellikSalonuOtomasyonu
{
    public partial class GecmisRandevularForm : Form
    {
        private readonly int uyeId;

        public GecmisRandevularForm(int uyeId)
        {
            this.uyeId = uyeId;
            InitializeComponent();
            LoadPastAppointments();
        }

        private void LoadPastAppointments()
        {
            string connectionString = "server=localhost;database=guzellik_salon;user=root;password=";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, tarih, durum FROM randevular WHERE tarih < CURDATE() AND uye_id = @uyeId";
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
    }
}
