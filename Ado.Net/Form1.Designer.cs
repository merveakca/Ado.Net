namespace Ado.Net
{
    partial class Form1
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
            this.btnGetir = new System.Windows.Forms.Button();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.btnNesne = new System.Windows.Forms.Button();
            this.btnYakala = new System.Windows.Forms.Button();
            this.btnUrunleriGetir = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(36, 57);
            this.btnGetir.Margin = new System.Windows.Forms.Padding(6);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(342, 107);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "1-ÜRÜNLERİ GETİR";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 37;
            this.lstListe.Location = new System.Drawing.Point(400, 57);
            this.lstListe.Margin = new System.Windows.Forms.Padding(6);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(377, 559);
            this.lstListe.TabIndex = 1;
            // 
            // btnNesne
            // 
            this.btnNesne.Location = new System.Drawing.Point(36, 173);
            this.btnNesne.Name = "btnNesne";
            this.btnNesne.Size = new System.Drawing.Size(342, 158);
            this.btnNesne.TabIndex = 2;
            this.btnNesne.Text = "2-GELEN VERİLERİ KULLANARAK NESNE OLUŞTURALIM";
            this.btnNesne.UseVisualStyleBackColor = true;
            this.btnNesne.Click += new System.EventHandler(this.btnNesne_Click);
            // 
            // btnYakala
            // 
            this.btnYakala.Location = new System.Drawing.Point(36, 346);
            this.btnYakala.Name = "btnYakala";
            this.btnYakala.Size = new System.Drawing.Size(342, 126);
            this.btnYakala.TabIndex = 3;
            this.btnYakala.Text = "3-SEÇİLEN NESNELERİ YAKALA";
            this.btnYakala.UseVisualStyleBackColor = true;
            this.btnYakala.Click += new System.EventHandler(this.btnYakala_Click);
            // 
            // btnUrunleriGetir
            // 
            this.btnUrunleriGetir.Location = new System.Drawing.Point(36, 490);
            this.btnUrunleriGetir.Name = "btnUrunleriGetir";
            this.btnUrunleriGetir.Size = new System.Drawing.Size(342, 126);
            this.btnUrunleriGetir.TabIndex = 4;
            this.btnUrunleriGetir.Text = "4-DATA TABLE İLE ÜRÜNLERİ GETİR";
            this.btnUrunleriGetir.UseVisualStyleBackColor = true;
            this.btnUrunleriGetir.Click += new System.EventHandler(this.btnUrunleriGetir_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(828, 57);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(442, 107);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLEME İŞLEMİ (INSERT)";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(828, 205);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(442, 103);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "SİLME İŞLEMİ (DELETE)";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(828, 346);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(442, 103);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLEME İŞLEMİ (UPDATE)";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 768);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnUrunleriGetir);
            this.Controls.Add(this.btnYakala);
            this.Controls.Add(this.btnNesne);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.btnGetir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Button btnNesne;
        private System.Windows.Forms.Button btnYakala;
        private System.Windows.Forms.Button btnUrunleriGetir;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

