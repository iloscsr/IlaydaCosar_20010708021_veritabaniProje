using System;

namespace IlaydaCosar_20010708021_veritabaniProje
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMusteriler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUrunler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSatisYap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOdemeYap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSatisDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnSatisSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSatisBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnOdemeDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnOdemeSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOdemeBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMusteriler,
            this.toolStripSeparator3,
            this.btnUrunler,
            this.toolStripSeparator2,
            this.btnSatisYap,
            this.toolStripSeparator4,
            this.btnOdemeYap,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(870, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.Image")));
            this.btnMusteriler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(96, 36);
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunler.Image")));
            this.btnUrunler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(82, 36);
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisYap.Image")));
            this.btnSatisYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(67, 36);
            this.btnSatisYap.Text = "Satış";
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeYap.Image")));
            this.btnOdemeYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(82, 36);
            this.btnOdemeYap.Text = "Ödeme";
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 411);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SATIŞLAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 42);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(856, 340);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSatisDuzenle,
            this.btnSatisSil,
            this.toolStripSeparator5,
            this.btnSatisBul,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(856, 39);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSatisDuzenle
            // 
            this.btnSatisDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisDuzenle.Image")));
            this.btnSatisDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatisDuzenle.Name = "btnSatisDuzenle";
            this.btnSatisDuzenle.Size = new System.Drawing.Size(85, 36);
            this.btnSatisDuzenle.Text = "Düzenle";
            this.btnSatisDuzenle.Click += new System.EventHandler(this.btnSatisDuzenle_Click);
            // 
            // btnSatisSil
            // 
            this.btnSatisSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisSil.Image")));
            this.btnSatisSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatisSil.Name = "btnSatisSil";
            this.btnSatisSil.Size = new System.Drawing.Size(55, 36);
            this.btnSatisSil.Text = "Sil";
            this.btnSatisSil.Click += new System.EventHandler(this.btnSatisSil_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSatisBul
            // 
            this.btnSatisBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSatisBul.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisBul.Image")));
            this.btnSatisBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatisBul.Name = "btnSatisBul";
            this.btnSatisBul.Size = new System.Drawing.Size(60, 36);
            this.btnSatisBul.Text = "Bul";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(28, 36);
            this.toolStripLabel1.Text = "Ara:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ÖDEMELER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 42);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(856, 340);
            this.dataGridView2.TabIndex = 3;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOdemeDüzenle,
            this.btnOdemeSil,
            this.toolStripSeparator6,
            this.btnOdemeBul,
            this.toolStripTextBox2,
            this.toolStripLabel2});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(856, 39);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnOdemeDüzenle
            // 
            this.btnOdemeDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeDüzenle.Image")));
            this.btnOdemeDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeDüzenle.Name = "btnOdemeDüzenle";
            this.btnOdemeDüzenle.Size = new System.Drawing.Size(85, 36);
            this.btnOdemeDüzenle.Text = "Düzenle";
            this.btnOdemeDüzenle.Click += new System.EventHandler(this.btnOdemeDüzenle_Click);
            // 
            // btnOdemeSil
            // 
            this.btnOdemeSil.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeSil.Image")));
            this.btnOdemeSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeSil.Name = "btnOdemeSil";
            this.btnOdemeSil.Size = new System.Drawing.Size(55, 36);
            this.btnOdemeSil.Text = "Sil";
            this.btnOdemeSil.Click += new System.EventHandler(this.btnOdemeSil_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // btnOdemeBul
            // 
            this.btnOdemeBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOdemeBul.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeBul.Image")));
            this.btnOdemeBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeBul.Name = "btnOdemeBul";
            this.btnOdemeBul.Size = new System.Drawing.Size(60, 36);
            this.btnOdemeBul.Text = "Bul";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(28, 36);
            this.toolStripLabel2.Text = "Ara:";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(870, 472);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AnaForm";
            this.Text = "Kozmetik Veritabani";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOdemeYap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnMusteriler;
        private System.Windows.Forms.ToolStripButton btnUrunler;
        private System.Windows.Forms.ToolStripButton btnSatisYap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSatisDuzenle;
        private System.Windows.Forms.ToolStripButton btnSatisSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSatisBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnOdemeDüzenle;
        private System.Windows.Forms.ToolStripButton btnOdemeSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnOdemeBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

