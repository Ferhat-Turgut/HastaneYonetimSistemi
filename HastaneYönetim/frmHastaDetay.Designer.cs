
namespace HastaneYönetim
{
    partial class frmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHastaAdSoyad = new System.Windows.Forms.Label();
            this.lblHastaTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnkHastaBilgiDuzenle = new System.Windows.Forms.LinkLabel();
            this.btnRndevuAl = new System.Windows.Forms.Button();
            this.rtxtSikayet = new System.Windows.Forms.RichTextBox();
            this.cmbDoktorSecimi = new System.Windows.Forms.ComboBox();
            this.cmbBranssecimi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgRandevuGecmisi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgAktifRandevu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRandevuGecmisi)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAktifRandevu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHastaAdSoyad);
            this.groupBox1.Controls.Add(this.lblHastaTc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // lblHastaAdSoyad
            // 
            this.lblHastaAdSoyad.AutoSize = true;
            this.lblHastaAdSoyad.Location = new System.Drawing.Point(77, 58);
            this.lblHastaAdSoyad.Name = "lblHastaAdSoyad";
            this.lblHastaAdSoyad.Size = new System.Drawing.Size(66, 13);
            this.lblHastaAdSoyad.TabIndex = 3;
            this.lblHastaAdSoyad.Text = "NULL NULL";
            // 
            // lblHastaTc
            // 
            this.lblHastaTc.AutoSize = true;
            this.lblHastaTc.Location = new System.Drawing.Point(77, 35);
            this.lblHastaTc.Name = "lblHastaTc";
            this.lblHastaTc.Size = new System.Drawing.Size(73, 13);
            this.lblHastaTc.TabIndex = 2;
            this.lblHastaTc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lnkHastaBilgiDuzenle);
            this.groupBox2.Controls.Add(this.btnRndevuAl);
            this.groupBox2.Controls.Add(this.rtxtSikayet);
            this.groupBox2.Controls.Add(this.cmbDoktorSecimi);
            this.groupBox2.Controls.Add(this.cmbBranssecimi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // lnkHastaBilgiDuzenle
            // 
            this.lnkHastaBilgiDuzenle.AutoSize = true;
            this.lnkHastaBilgiDuzenle.Location = new System.Drawing.Point(86, 228);
            this.lnkHastaBilgiDuzenle.Name = "lnkHastaBilgiDuzenle";
            this.lnkHastaBilgiDuzenle.Size = new System.Drawing.Size(91, 13);
            this.lnkHastaBilgiDuzenle.TabIndex = 7;
            this.lnkHastaBilgiDuzenle.TabStop = true;
            this.lnkHastaBilgiDuzenle.Text = "Bilgilerimi Düzenle";
            this.lnkHastaBilgiDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHastaBilgiDuzenle_LinkClicked);
            // 
            // btnRndevuAl
            // 
            this.btnRndevuAl.Location = new System.Drawing.Point(5, 218);
            this.btnRndevuAl.Name = "btnRndevuAl";
            this.btnRndevuAl.Size = new System.Drawing.Size(75, 23);
            this.btnRndevuAl.TabIndex = 6;
            this.btnRndevuAl.Text = "Randevu Al";
            this.btnRndevuAl.UseVisualStyleBackColor = true;
            this.btnRndevuAl.Click += new System.EventHandler(this.btnRndevuAl_Click);
            // 
            // rtxtSikayet
            // 
            this.rtxtSikayet.Location = new System.Drawing.Point(68, 95);
            this.rtxtSikayet.Name = "rtxtSikayet";
            this.rtxtSikayet.Size = new System.Drawing.Size(119, 119);
            this.rtxtSikayet.TabIndex = 5;
            this.rtxtSikayet.Text = "";
            // 
            // cmbDoktorSecimi
            // 
            this.cmbDoktorSecimi.FormattingEnabled = true;
            this.cmbDoktorSecimi.Location = new System.Drawing.Point(68, 67);
            this.cmbDoktorSecimi.Name = "cmbDoktorSecimi";
            this.cmbDoktorSecimi.Size = new System.Drawing.Size(119, 21);
            this.cmbDoktorSecimi.TabIndex = 4;
            this.cmbDoktorSecimi.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorSecimi_SelectedIndexChanged);
            // 
            // cmbBranssecimi
            // 
            this.cmbBranssecimi.FormattingEnabled = true;
            this.cmbBranssecimi.Location = new System.Drawing.Point(68, 41);
            this.cmbBranssecimi.Name = "cmbBranssecimi";
            this.cmbBranssecimi.Size = new System.Drawing.Size(119, 21);
            this.cmbBranssecimi.TabIndex = 3;
            this.cmbBranssecimi.SelectedIndexChanged += new System.EventHandler(this.cmbBranssecimi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "ŞİKAYET:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "DOKTOR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "BRANŞ:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgRandevuGecmisi);
            this.groupBox3.Location = new System.Drawing.Point(211, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(728, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmiş";
            // 
            // dtgRandevuGecmisi
            // 
            this.dtgRandevuGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRandevuGecmisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRandevuGecmisi.Location = new System.Drawing.Point(3, 16);
            this.dtgRandevuGecmisi.Name = "dtgRandevuGecmisi";
            this.dtgRandevuGecmisi.Size = new System.Drawing.Size(722, 149);
            this.dtgRandevuGecmisi.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgAktifRandevu);
            this.groupBox4.Location = new System.Drawing.Point(214, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(725, 255);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dtgAktifRandevu
            // 
            this.dtgAktifRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAktifRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgAktifRandevu.Location = new System.Drawing.Point(3, 16);
            this.dtgAktifRandevu.Name = "dtgAktifRandevu";
            this.dtgAktifRandevu.Size = new System.Drawing.Size(719, 236);
            this.dtgAktifRandevu.TabIndex = 0;
            this.dtgAktifRandevu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAktifRandevu_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(945, 453);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHastaDetay";
            this.Text = "Hasta Paneli";
            this.Load += new System.EventHandler(this.frmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRandevuGecmisi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAktifRandevu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHastaAdSoyad;
        private System.Windows.Forms.Label lblHastaTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRndevuAl;
        private System.Windows.Forms.RichTextBox rtxtSikayet;
        private System.Windows.Forms.ComboBox cmbDoktorSecimi;
        private System.Windows.Forms.ComboBox cmbBranssecimi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgRandevuGecmisi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgAktifRandevu;
        private System.Windows.Forms.LinkLabel lnkHastaBilgiDuzenle;
        private System.Windows.Forms.Button button1;
    }
}