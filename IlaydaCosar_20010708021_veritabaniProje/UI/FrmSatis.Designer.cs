namespace IlaydaCosar_20010708021_veritabaniProje.UI
{
    partial class FrmSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nmFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSatisID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMusteriSeç = new System.Windows.Forms.Button();
            this.btnUrunSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nmFiyat
            // 
            this.nmFiyat.Location = new System.Drawing.Point(78, 134);
            this.nmFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmFiyat.Name = "nmFiyat";
            this.nmFiyat.Size = new System.Drawing.Size(190, 20);
            this.nmFiyat.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(193, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(112, 170);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Tamam";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fiyat";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(78, 48);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.ReadOnly = true;
            this.txtMusteri.Size = new System.Drawing.Size(190, 20);
            this.txtMusteri.TabIndex = 1;
            this.txtMusteri.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Müşteri";
            // 
            // txtSatisID
            // 
            this.txtSatisID.Location = new System.Drawing.Point(78, 22);
            this.txtSatisID.Name = "txtSatisID";
            this.txtSatisID.ReadOnly = true;
            this.txtSatisID.Size = new System.Drawing.Size(190, 20);
            this.txtSatisID.TabIndex = 0;
            this.txtSatisID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(78, 106);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(190, 20);
            this.dtTarih.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ürün";
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(78, 74);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.ReadOnly = true;
            this.txtUrun.Size = new System.Drawing.Size(190, 20);
            this.txtUrun.TabIndex = 2;
            this.txtUrun.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMusteriSeç
            // 
            this.btnMusteriSeç.Location = new System.Drawing.Point(275, 44);
            this.btnMusteriSeç.Name = "btnMusteriSeç";
            this.btnMusteriSeç.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriSeç.TabIndex = 23;
            this.btnMusteriSeç.Text = "Müşteri Seç";
            this.btnMusteriSeç.UseVisualStyleBackColor = true;
            this.btnMusteriSeç.Click += new System.EventHandler(this.btnMusteriSeç_Click);
            // 
            // btnUrunSec
            // 
            this.btnUrunSec.Location = new System.Drawing.Point(274, 74);
            this.btnUrunSec.Name = "btnUrunSec";
            this.btnUrunSec.Size = new System.Drawing.Size(75, 23);
            this.btnUrunSec.TabIndex = 23;
            this.btnUrunSec.Text = "Ürün Seç";
            this.btnUrunSec.UseVisualStyleBackColor = true;
            this.btnUrunSec.Click += new System.EventHandler(this.btnUrunSec_Click);
            // 
            // FrmSatis
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(361, 223);
            this.Controls.Add(this.btnUrunSec);
            this.Controls.Add(this.btnMusteriSeç);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.nmFiyat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSatisID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSatis";
            this.Click += new System.EventHandler(this.FrmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmFiyat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatisID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnMusteriSeç;
        private System.Windows.Forms.Button btnUrunSec;
    }
}