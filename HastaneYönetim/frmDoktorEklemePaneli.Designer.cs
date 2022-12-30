
namespace HastaneYönetim
{
    partial class frmDoktorEklemePaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorEklemePaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDoktorAd = new System.Windows.Forms.TextBox();
            this.txtDoktorSoyad = new System.Windows.Forms.TextBox();
            this.txtDoktorSifre = new System.Windows.Forms.TextBox();
            this.cmbDoktorBrans = new System.Windows.Forms.ComboBox();
            this.mskDoktorTc = new System.Windows.Forms.MaskedTextBox();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.btnDoktorSil = new System.Windows.Forms.Button();
            this.btnDoktorGuncelle = new System.Windows.Forms.Button();
            this.dtgDoktorListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoktorListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "DOKTOR BİLGİ DEĞİŞİM PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "SOYAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "BRANŞ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ŞİFRE:";
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Location = new System.Drawing.Point(56, 42);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(121, 20);
            this.txtDoktorAd.TabIndex = 0;
            // 
            // txtDoktorSoyad
            // 
            this.txtDoktorSoyad.Location = new System.Drawing.Point(56, 72);
            this.txtDoktorSoyad.Name = "txtDoktorSoyad";
            this.txtDoktorSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtDoktorSoyad.TabIndex = 1;
            // 
            // txtDoktorSifre
            // 
            this.txtDoktorSifre.Location = new System.Drawing.Point(56, 156);
            this.txtDoktorSifre.Name = "txtDoktorSifre";
            this.txtDoktorSifre.Size = new System.Drawing.Size(121, 20);
            this.txtDoktorSifre.TabIndex = 4;
            // 
            // cmbDoktorBrans
            // 
            this.cmbDoktorBrans.FormattingEnabled = true;
            this.cmbDoktorBrans.Location = new System.Drawing.Point(56, 98);
            this.cmbDoktorBrans.Name = "cmbDoktorBrans";
            this.cmbDoktorBrans.Size = new System.Drawing.Size(121, 21);
            this.cmbDoktorBrans.TabIndex = 2;
            // 
            // mskDoktorTc
            // 
            this.mskDoktorTc.Location = new System.Drawing.Point(56, 126);
            this.mskDoktorTc.Mask = "00000000000";
            this.mskDoktorTc.Name = "mskDoktorTc";
            this.mskDoktorTc.Size = new System.Drawing.Size(121, 20);
            this.mskDoktorTc.TabIndex = 3;
            this.mskDoktorTc.ValidatingType = typeof(int);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.Location = new System.Drawing.Point(56, 182);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(43, 23);
            this.btnDoktorEkle.TabIndex = 5;
            this.btnDoktorEkle.Text = "EKLE";
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.Location = new System.Drawing.Point(134, 182);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(43, 23);
            this.btnDoktorSil.TabIndex = 6;
            this.btnDoktorSil.Text = "SİL";
            this.btnDoktorSil.UseVisualStyleBackColor = true;
            this.btnDoktorSil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(56, 211);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(121, 23);
            this.btnDoktorGuncelle.TabIndex = 7;
            this.btnDoktorGuncelle.Text = "GÜNCELLE";
            this.btnDoktorGuncelle.UseVisualStyleBackColor = true;
            this.btnDoktorGuncelle.Click += new System.EventHandler(this.btnDoktorGuncelle_Click);
            // 
            // dtgDoktorListesi
            // 
            this.dtgDoktorListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDoktorListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoktorListesi.Location = new System.Drawing.Point(183, 42);
            this.dtgDoktorListesi.Name = "dtgDoktorListesi";
            this.dtgDoktorListesi.Size = new System.Drawing.Size(729, 199);
            this.dtgDoktorListesi.TabIndex = 8;
            this.dtgDoktorListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDoktorListesi_CellClick);
            // 
            // frmDoktorEklemePaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(917, 250);
            this.Controls.Add(this.dtgDoktorListesi);
            this.Controls.Add(this.btnDoktorGuncelle);
            this.Controls.Add(this.btnDoktorSil);
            this.Controls.Add(this.btnDoktorEkle);
            this.Controls.Add(this.mskDoktorTc);
            this.Controls.Add(this.cmbDoktorBrans);
            this.Controls.Add(this.txtDoktorSifre);
            this.Controls.Add(this.txtDoktorSoyad);
            this.Controls.Add(this.txtDoktorAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDoktorEklemePaneli";
            this.Text = "Doktor Ekleme Paneli";
            this.Load += new System.EventHandler(this.frmDoktorEklemePaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoktorListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDoktorAd;
        private System.Windows.Forms.TextBox txtDoktorSoyad;
        private System.Windows.Forms.TextBox txtDoktorSifre;
        private System.Windows.Forms.ComboBox cmbDoktorBrans;
        private System.Windows.Forms.MaskedTextBox mskDoktorTc;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.Button btnDoktorSil;
        private System.Windows.Forms.Button btnDoktorGuncelle;
        private System.Windows.Forms.DataGridView dtgDoktorListesi;
    }
}