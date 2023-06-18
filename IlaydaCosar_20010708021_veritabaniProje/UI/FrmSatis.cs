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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

       public Satis Satis { get; set; }
        public bool Guncelleme { get; set; } = false;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(nmFiyat.Value == 0)
            {
                errorProvider1.SetError(nmFiyat, "Lütfen fiyat giriniz");
                nmFiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }

            Satis.Tarih = dtTarih.Value;
            Satis.Fiyat = (double)nmFiyat.Value;
            Satis.UrunID = Guid.Parse(txtUrun.Text);
            Satis.MusteriID = Guid.Parse(txtMusteri.Text);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            txtSatisID.Text = Satis.ID.ToString();
            if (Guncelleme)
            {
                txtMusteri.Text = Satis.MusteriID.ToString();
                txtUrun.Text = Satis.UrunID.ToString();
                nmFiyat.Value = (decimal)Satis.Fiyat;
                dtTarih.Value = Satis.Tarih;
            }
        }

        private void btnMusteriSeç_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            if(frm.ShowDialog() == DialogResult.OK )
            {
                txtMusteri.Text = frm.Musteri.ID.ToString();
            }
        }

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
            Urunler frm = new Urunler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUrun.Text = frm.Urun.ID.ToString() ;
            }
        }
    }
}
