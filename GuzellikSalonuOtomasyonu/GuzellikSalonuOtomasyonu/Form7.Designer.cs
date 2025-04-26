using System.Drawing;
using System.Windows.Forms;
using System;

namespace GuzellikSalonuOtomasyonu
{
    partial class RandevuForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTalimat;
        private DateTimePicker dtpTarih;
        private ComboBox cmbHizmet;
        private FlowLayoutPanel flpSaatler;
        private Button btnRandevuAl;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTalimat = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbHizmet = new System.Windows.Forms.ComboBox();
            this.flpSaatler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTalimat
            // 
            this.lblTalimat.AutoSize = true;
            this.lblTalimat.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblTalimat.Location = new System.Drawing.Point(92, 23);
            this.lblTalimat.Name = "lblTalimat";
            this.lblTalimat.Size = new System.Drawing.Size(323, 19);
            this.lblTalimat.TabIndex = 0;
            this.lblTalimat.Text = "Tarih ve saati seçip alttan saati butonla işaretleyin:";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(92, 53);
            this.dtpTarih.MaxDate = new System.DateTime(2025, 5, 18, 0, 0, 0, 0);
            this.dtpTarih.MinDate = new System.DateTime(2025, 4, 18, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.ShowUpDown = true;
            this.dtpTarih.Size = new System.Drawing.Size(100, 20);
            this.dtpTarih.TabIndex = 1;
            // 
            // cmbHizmet
            // 
            this.cmbHizmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHizmet.Items.AddRange(new object[] {
            "Saç Kesimi",
            "Manikür",
            "Pedikür",
            "Cilt Bakımı",
            "Masaj"});
            this.cmbHizmet.Location = new System.Drawing.Point(212, 53);
            this.cmbHizmet.Name = "cmbHizmet";
            this.cmbHizmet.Size = new System.Drawing.Size(150, 21);
            this.cmbHizmet.TabIndex = 2;
            // 
            // flpSaatler
            // 
            this.flpSaatler.AutoScroll = true;
            this.flpSaatler.Location = new System.Drawing.Point(20, 90);
            this.flpSaatler.Name = "flpSaatler";
            this.flpSaatler.Size = new System.Drawing.Size(480, 312);
            this.flpSaatler.TabIndex = 3;
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(231)))));
            this.btnRandevuAl.FlatAppearance.BorderSize = 0;
            this.btnRandevuAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(147)))), ((int)(((byte)(216)))));
            this.btnRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuAl.ForeColor = System.Drawing.Color.White;
            this.btnRandevuAl.Location = new System.Drawing.Point(92, 408);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(297, 35);
            this.btnRandevuAl.TabIndex = 4;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // RandevuForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(512, 455);
            this.Controls.Add(this.lblTalimat);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbHizmet);
            this.Controls.Add(this.flpSaatler);
            this.Controls.Add(this.btnRandevuAl);
            this.Name = "RandevuForm";
            this.Text = "Randevu Al";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
