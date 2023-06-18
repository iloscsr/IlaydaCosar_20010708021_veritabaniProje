namespace IlaydaCosar_20010708021_veritabaniProje.UI
{
    partial class FrmUrun
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.nmFiyat = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(181, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(100, 137);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Tamam";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fiyat";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(66, 46);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(190, 20);
            this.txtUrunAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ad";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(66, 20);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.ReadOnly = true;
            this.txtUrunID.Size = new System.Drawing.Size(190, 20);
            this.txtUrunID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Vücut Bakımı",
            "Saç Bakımı",
            "Cilt Bakımı",
            "Tırnak Bakımı",
            "Makyaj Ürünleri"});
            this.cbKategori.Location = new System.Drawing.Point(66, 73);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(190, 21);
            this.cbKategori.TabIndex = 2;
            // 
            // nmFiyat
            // 
            this.nmFiyat.Location = new System.Drawing.Point(66, 101);
            this.nmFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmFiyat.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmFiyat.Name = "nmFiyat";
            this.nmFiyat.Size = new System.Drawing.Size(190, 20);
            this.nmFiyat.TabIndex = 3;
            this.nmFiyat.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUrun
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.nmFiyat);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmUrun";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.NumericUpDown nmFiyat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}