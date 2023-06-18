using ilaydaCosar_veritabani.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlaydaCosar_20010708021_veritabaniProje.UI
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Müşteri Ekle",
                Musteri = new Musteri() { ID = Guid.NewGuid() },
            };

        tekrar:

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriEkle(frmMusteri.Musteri);
                if (b)
                {
                    DataSet ds = BLogic.MusteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else

                    goto tekrar;

            }
        }
        private void btnMusteriDuzenle_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Müşteri Güncelle",
                Guncelleme = true,
                Musteri = new IlaydaCosar_20010708021_veritabaniProje.Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    AD = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Adres = row.Cells[4].Value.ToString(),
                },
            };
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriGuncelle(frmMusteri.Musteri);
                if (b)
                {
                    row.Cells[1].Value = frmMusteri.Musteri.AD;
                    row.Cells[2].Value = frmMusteri.Musteri.Soyad;
                    row.Cells[3].Value = frmMusteri.Musteri.Telefon;
                    row.Cells[4].Value = frmMusteri.Musteri.Adres;
                }

            };
        }
        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MusteriGetir(toolStripTextBox1.Text);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriSil(ID);
                if (b)
                {
                    DataSet ds = BLogic.MusteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void Musterilercs_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MusteriGetir("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }
        public Musteri Musteri { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.SelectedRows[0];
           
                Musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    AD = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Adres = row.Cells[4].Value.ToString(),
                };

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
