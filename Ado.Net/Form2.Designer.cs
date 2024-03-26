namespace Ado.Net
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstUrunListesi = new System.Windows.Forms.ListBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Seçiniz";
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(76, 124);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(718, 45);
            this.cmbKategoriler.TabIndex = 1;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Listesi";
            // 
            // lstUrunListesi
            // 
            this.lstUrunListesi.FormattingEnabled = true;
            this.lstUrunListesi.ItemHeight = 37;
            this.lstUrunListesi.Location = new System.Drawing.Point(76, 246);
            this.lstUrunListesi.Name = "lstUrunListesi";
            this.lstUrunListesi.Size = new System.Drawing.Size(385, 522);
            this.lstUrunListesi.TabIndex = 3;
            this.lstUrunListesi.SelectedIndexChanged += new System.EventHandler(this.lstUrunListesi_SelectedIndexChanged);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(496, 196);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(503, 37);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = ".............. Adlı Sipariş Detay Listesi";
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(503, 246);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.RowHeadersWidth = 62;
            this.dgvSiparisler.RowTemplate.Height = 28;
            this.dgvSiparisler.Size = new System.Drawing.Size(1111, 522);
            this.dgvSiparisler.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 832);
            this.Controls.Add(this.dgvSiparisler);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lstUrunListesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstUrunListesi;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DataGridView dgvSiparisler;
    }
}