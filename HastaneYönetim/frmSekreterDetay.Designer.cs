
namespace HastaneYönetim
{
    partial class frmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSekreterAdSoyad = new System.Windows.Forms.Label();
            this.lblSekreterTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuyuruOlustur = new System.Windows.Forms.Button();
            this.rchDuyurular = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRandevuKaydet = new System.Windows.Forms.Button();
            this.cbRandevuDurum = new System.Windows.Forms.CheckBox();
            this.mskRandevuTc = new System.Windows.Forms.MaskedTextBox();
            this.cmbRandevuDoktor = new System.Windows.Forms.ComboBox();
            this.cmbRandevuBrans = new System.Windows.Forms.ComboBox();
            this.mskRandevuSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskRandevuTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtRandevuId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRandevular = new System.Windows.Forms.Button();
            this.btnBransPaneli = new System.Windows.Forms.Button();
            this.btnDoktorPaneli = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSekreterAdSoyad);
            this.groupBox1.Controls.Add(this.lblSekreterTc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgileri";
            // 
            // lblSekreterAdSoyad
            // 
            this.lblSekreterAdSoyad.AutoSize = true;
            this.lblSekreterAdSoyad.Location = new System.Drawing.Point(80, 49);
            this.lblSekreterAdSoyad.Name = "lblSekreterAdSoyad";
            this.lblSekreterAdSoyad.Size = new System.Drawing.Size(66, 13);
            this.lblSekreterAdSoyad.TabIndex = 7;
            this.lblSekreterAdSoyad.Text = "NULL NULL";
            // 
            // lblSekreterTc
            // 
            this.lblSekreterTc.AutoSize = true;
            this.lblSekreterTc.Location = new System.Drawing.Point(80, 26);
            this.lblSekreterTc.Name = "lblSekreterTc";
            this.lblSekreterTc.Size = new System.Drawing.Size(73, 13);
            this.lblSekreterTc.TabIndex = 6;
            this.lblSekreterTc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "AD SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuyuruOlustur);
            this.groupBox2.Controls.Add(this.rchDuyurular);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnDuyuruOlustur
            // 
            this.btnDuyuruOlustur.Location = new System.Drawing.Point(53, 174);
            this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            this.btnDuyuruOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnDuyuruOlustur.TabIndex = 1;
            this.btnDuyuruOlustur.Text = "Oluştur";
            this.btnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
            // 
            // rchDuyurular
            // 
            this.rchDuyurular.Location = new System.Drawing.Point(12, 33);
            this.rchDuyurular.Name = "rchDuyurular";
            this.rchDuyurular.Size = new System.Drawing.Size(179, 135);
            this.rchDuyurular.TabIndex = 0;
            this.rchDuyurular.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRandevuKaydet);
            this.groupBox3.Controls.Add(this.cbRandevuDurum);
            this.groupBox3.Controls.Add(this.mskRandevuTc);
            this.groupBox3.Controls.Add(this.cmbRandevuDoktor);
            this.groupBox3.Controls.Add(this.cmbRandevuBrans);
            this.groupBox3.Controls.Add(this.mskRandevuSaat);
            this.groupBox3.Controls.Add(this.mskRandevuTarih);
            this.groupBox3.Controls.Add(this.txtRandevuId);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(215, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 303);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btnRandevuKaydet
            // 
            this.btnRandevuKaydet.Location = new System.Drawing.Point(73, 254);
            this.btnRandevuKaydet.Name = "btnRandevuKaydet";
            this.btnRandevuKaydet.Size = new System.Drawing.Size(110, 23);
            this.btnRandevuKaydet.TabIndex = 13;
            this.btnRandevuKaydet.Text = "KAYDET";
            this.btnRandevuKaydet.UseVisualStyleBackColor = true;
            this.btnRandevuKaydet.Click += new System.EventHandler(this.btnRandevuKaydet_Click);
            // 
            // cbRandevuDurum
            // 
            this.cbRandevuDurum.AutoSize = true;
            this.cbRandevuDurum.Location = new System.Drawing.Point(73, 219);
            this.cbRandevuDurum.Name = "cbRandevuDurum";
            this.cbRandevuDurum.Size = new System.Drawing.Size(67, 17);
            this.cbRandevuDurum.TabIndex = 12;
            this.cbRandevuDurum.Text = "DURUM";
            this.cbRandevuDurum.UseVisualStyleBackColor = true;
            // 
            // mskRandevuTc
            // 
            this.mskRandevuTc.Location = new System.Drawing.Point(72, 184);
            this.mskRandevuTc.Mask = "00000000000";
            this.mskRandevuTc.Name = "mskRandevuTc";
            this.mskRandevuTc.Size = new System.Drawing.Size(111, 20);
            this.mskRandevuTc.TabIndex = 11;
            this.mskRandevuTc.ValidatingType = typeof(int);
            // 
            // cmbRandevuDoktor
            // 
            this.cmbRandevuDoktor.FormattingEnabled = true;
            this.cmbRandevuDoktor.Location = new System.Drawing.Point(72, 157);
            this.cmbRandevuDoktor.Name = "cmbRandevuDoktor";
            this.cmbRandevuDoktor.Size = new System.Drawing.Size(111, 21);
            this.cmbRandevuDoktor.TabIndex = 10;
            // 
            // cmbRandevuBrans
            // 
            this.cmbRandevuBrans.FormattingEnabled = true;
            this.cmbRandevuBrans.Location = new System.Drawing.Point(73, 132);
            this.cmbRandevuBrans.Name = "cmbRandevuBrans";
            this.cmbRandevuBrans.Size = new System.Drawing.Size(111, 21);
            this.cmbRandevuBrans.TabIndex = 9;
            this.cmbRandevuBrans.SelectedIndexChanged += new System.EventHandler(this.cmbRandevuBrans_SelectedIndexChanged);
            // 
            // mskRandevuSaat
            // 
            this.mskRandevuSaat.Location = new System.Drawing.Point(72, 105);
            this.mskRandevuSaat.Mask = "00:00";
            this.mskRandevuSaat.Name = "mskRandevuSaat";
            this.mskRandevuSaat.Size = new System.Drawing.Size(111, 20);
            this.mskRandevuSaat.TabIndex = 8;
            this.mskRandevuSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskRandevuTarih
            // 
            this.mskRandevuTarih.Location = new System.Drawing.Point(73, 79);
            this.mskRandevuTarih.Mask = "00/00/0000";
            this.mskRandevuTarih.Name = "mskRandevuTarih";
            this.mskRandevuTarih.Size = new System.Drawing.Size(111, 20);
            this.mskRandevuTarih.TabIndex = 7;
            this.mskRandevuTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtRandevuId
            // 
            this.txtRandevuId.Location = new System.Drawing.Point(73, 53);
            this.txtRandevuId.Name = "txtRandevuId";
            this.txtRandevuId.Size = new System.Drawing.Size(111, 20);
            this.txtRandevuId.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "DOKTOR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "BRANŞ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "SAAT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "TARİH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(413, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 209);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(413, 229);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(375, 209);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(369, 190);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDuyurular);
            this.groupBox6.Controls.Add(this.btnRandevular);
            this.groupBox6.Controls.Add(this.btnBransPaneli);
            this.groupBox6.Controls.Add(this.btnDoktorPaneli);
            this.groupBox6.Location = new System.Drawing.Point(12, 335);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(395, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnRandevular
            // 
            this.btnRandevular.Location = new System.Drawing.Point(192, 31);
            this.btnRandevular.Name = "btnRandevular";
            this.btnRandevular.Size = new System.Drawing.Size(74, 41);
            this.btnRandevular.TabIndex = 4;
            this.btnRandevular.Text = "Randevular";
            this.btnRandevular.UseVisualStyleBackColor = true;
            this.btnRandevular.Click += new System.EventHandler(this.btnRandevular_Click);
            // 
            // btnBransPaneli
            // 
            this.btnBransPaneli.Location = new System.Drawing.Point(105, 31);
            this.btnBransPaneli.Name = "btnBransPaneli";
            this.btnBransPaneli.Size = new System.Drawing.Size(74, 41);
            this.btnBransPaneli.TabIndex = 3;
            this.btnBransPaneli.Text = "Branş Paneli";
            this.btnBransPaneli.UseVisualStyleBackColor = true;
            this.btnBransPaneli.Click += new System.EventHandler(this.btnBransPaneli_Click);
            // 
            // btnDoktorPaneli
            // 
            this.btnDoktorPaneli.Location = new System.Drawing.Point(13, 31);
            this.btnDoktorPaneli.Name = "btnDoktorPaneli";
            this.btnDoktorPaneli.Size = new System.Drawing.Size(74, 41);
            this.btnDoktorPaneli.TabIndex = 2;
            this.btnDoktorPaneli.Text = "Doktor Paneli";
            this.btnDoktorPaneli.UseVisualStyleBackColor = true;
            this.btnDoktorPaneli.Click += new System.EventHandler(this.btnDoktorPaneli_Click);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Location = new System.Drawing.Point(276, 31);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(92, 41);
            this.btnDuyurular.TabIndex = 5;
            this.btnDuyurular.Text = "DUYURULAR";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // frmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSekreterDetay";
            this.Text = "frmSekreterDetay";
            this.Load += new System.EventHandler(this.frmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSekreterAdSoyad;
        private System.Windows.Forms.Label lblSekreterTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuyuruOlustur;
        private System.Windows.Forms.RichTextBox rchDuyurular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRandevuKaydet;
        private System.Windows.Forms.CheckBox cbRandevuDurum;
        private System.Windows.Forms.MaskedTextBox mskRandevuTc;
        private System.Windows.Forms.ComboBox cmbRandevuDoktor;
        private System.Windows.Forms.ComboBox cmbRandevuBrans;
        private System.Windows.Forms.MaskedTextBox mskRandevuSaat;
        private System.Windows.Forms.MaskedTextBox mskRandevuTarih;
        private System.Windows.Forms.TextBox txtRandevuId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRandevular;
        private System.Windows.Forms.Button btnBransPaneli;
        private System.Windows.Forms.Button btnDoktorPaneli;
        private System.Windows.Forms.Button btnDuyurular;
    }
}