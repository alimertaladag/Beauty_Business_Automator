using System;
using System.Windows.Forms;

namespace GuzellikSalonuOtomasyonu
{
    public partial class AnasayfaForm : Form
    {
        private readonly int uyeId;

        public AnasayfaForm(int uyeId)
        {
            this.uyeId = uyeId;
            InitializeComponent();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            var form = new ProfilForm(uyeId);
            form.ShowDialog();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            var form = new RandevuForm(uyeId);
            form.ShowDialog();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            var form = new RandevuIptalForm(uyeId);
            form.ShowDialog();
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            var form = new GecmisRandevularForm(uyeId);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new RandevuOnayForm();
            form.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
