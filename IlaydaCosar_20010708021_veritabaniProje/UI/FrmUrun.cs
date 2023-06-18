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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Urun Urun { get; set; }
        public bool Guncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtUrunAd)) return;
            if (!ErrorControl(cbKategori)) return;
            if (!ErrorControl(nmFiyat)) return;

            Urun.AD = txtUrunAd.Text;
            Urun.Kategori = cbKategori.Text;
            Urun.Fiyat = (double)nmFiyat.Value;

            DialogResult =DialogResult.OK;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, " ");
                    return true;
                }
            }
            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, " ");
                    return true;
                }
            }

            return true;
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            txtUrunID.Text = Urun.ID.ToString();
            if (!Guncelleme)
            {
                txtUrunAd.Text = Urun.AD;
                cbKategori.Text = Urun.Kategori;
                nmFiyat.Value = (decimal)Urun.Fiyat;
            }
        }
    }
}
