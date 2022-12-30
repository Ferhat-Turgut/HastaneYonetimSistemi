
namespace HastaneYönetim
{
    partial class frmBransPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBransPaneli));
            this.dtgBransListesi = new System.Windows.Forms.DataGridView();
            this.btnDoktorSil = new System.Windows.Forms.Button();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.txtBransAdi = new System.Windows.Forms.TextBox();
            this.txtBransId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoktorGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBransListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBransListesi
            // 
            this.dtgBransListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBransListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBransListesi.Location = new System.Drawing.Point(267, 18);
            this.dtgBransListesi.Name = "dtgBransListesi";
            this.dtgBransListesi.Size = new System.Drawing.Size(406, 192);
            this.dtgBransListesi.TabIndex = 36;
            this.dtgBransListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBransListesi_CellClick);
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.Location = new System.Drawing.Point(164, 158);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(43, 23);
            this.btnDoktorSil.TabIndex = 35;
            this.btnDoktorSil.Text = "SİL";
            this.btnDoktorSil.UseVisualStyleBackColor = true;
            this.btnDoktorSil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.Location = new System.Drawing.Point(86, 158);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(43, 23);
            this.btnDoktorEkle.TabIndex = 34;
            this.btnDoktorEkle.Text = "EKLE";
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // txtBransAdi
            // 
            this.txtBransAdi.Location = new System.Drawing.Point(86, 113);
            this.txtBransAdi.Name = "txtBransAdi";
            this.txtBransAdi.Size = new System.Drawing.Size(121, 20);
            this.txtBransAdi.TabIndex = 30;
            // 
            // txtBransId
            // 
            this.txtBransId.Enabled = false;
            this.txtBransId.Location = new System.Drawing.Point(86, 83);
            this.txtBransId.Name = "txtBransId";
            this.txtBransId.Size = new System.Drawing.Size(121, 20);
            this.txtBransId.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "BRANŞ ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "BRANŞ ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "BRANŞ BİLGİ DEĞİŞİM PANELİ";
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(86, 187);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(121, 23);
            this.btnDoktorGuncelle.TabIndex = 37;
            this.btnDoktorGuncelle.Text = "GÜNCELLE";
            this.btnDoktorGuncelle.UseVisualStyleBackColor = true;
            this.btnDoktorGuncelle.Click += new System.EventHandler(this.btnDoktorGuncelle_Click);
            // 
            // frmBransPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(677, 213);
            this.Controls.Add(this.btnDoktorGuncelle);
            this.Controls.Add(this.dtgBransListesi);
            this.Controls.Add(this.btnDoktorSil);
            this.Controls.Add(this.btnDoktorEkle);
            this.Controls.Add(this.txtBransAdi);
            this.Controls.Add(this.txtBransId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmBransPaneli";
            this.Text = "frmBransPaneli";
            this.Load += new System.EventHandler(this.frmBransPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBransListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBransListesi;
        private System.Windows.Forms.Button btnDoktorSil;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.TextBox txtBransAdi;
        private System.Windows.Forms.TextBox txtBransId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoktorGuncelle;
    }
}