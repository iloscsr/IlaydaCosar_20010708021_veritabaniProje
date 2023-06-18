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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun()
            {
                Text = "Urun Ekle",
                Urun = new Urun() { ID = Guid.NewGuid() },
            };

        tekrar:

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunEkle(frm.Urun);
                if (b)
                {
                    DataSet ds = BLogic.UrunGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
                else

                    goto tekrar;

            }
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            FrmUrun frm = new FrmUrun()
            {
                Text = "Urun Güncelle",
                Guncelleme = true,
                Urun = new Urun()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    AD = row.Cells[1].Value.ToString(),
                    Fiyat = double.Parse(row.Cells[2].Value.ToString()),
                    Kategori = row.Cells[4].Value.ToString(),
                },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunGuncelle(frm.Urun);
                if (b)
                {
                    row.Cells[1].Value = frm.Urun.AD;
                    row.Cells[2].Value = frm.Urun.Fiyat;
                    row.Cells[3].Value = frm.Urun.Kategori;
                }

            };
        }

        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.UrunGetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunSil(ID);
                if (b)
                {
                    DataSet ds = BLogic.UrunGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.UrunGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];   
        }

        public Urun Urun { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            Urun = new Urun()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                AD = row.Cells[1].Value.ToString(),
                Fiyat = double.Parse(row.Cells[2].Value.ToString()),
                Kategori = row.Cells[4].Value.ToString(),
            };          
            
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
