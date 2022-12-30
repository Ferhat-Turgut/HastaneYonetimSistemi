
namespace HastaneYönetim
{
    partial class frm_DoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDoktorAdSoyad = new System.Windows.Forms.Label();
            this.lblDoktorTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtHastaSikayet = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgDoktorRandevulari = new System.Windows.Forms.DataGridView();
            this.btnBilgiDuzenle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoktorRandevulari)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDoktorAdSoyad);
            this.groupBox1.Controls.Add(this.lblDoktorTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgleri";
            // 
            // lblDoktorAdSoyad
            // 
            this.lblDoktorAdSoyad.AutoSize = true;
            this.lblDoktorAdSoyad.Location = new System.Drawing.Point(79, 59);
            this.lblDoktorAdSoyad.Name = "lblDoktorAdSoyad";
            this.lblDoktorAdSoyad.Size = new System.Drawing.Size(66, 13);
            this.lblDoktorAdSoyad.TabIndex = 7;
            this.lblDoktorAdSoyad.Text = "NULL NULL";
            // 
            // lblDoktorTc
            // 
            this.lblDoktorTc.AutoSize = true;
            this.lblDoktorTc.Location = new System.Drawing.Point(79, 36);
            this.lblDoktorTc.Name = "lblDoktorTc";
            this.lblDoktorTc.Size = new System.Drawing.Size(73, 13);
            this.lblDoktorTc.TabIndex = 6;
            this.lblDoktorTc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "AD SOYAD:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtHastaSikayet);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rtxtHastaSikayet
            // 
            this.rtxtHastaSikayet.Location = new System.Drawing.Point(11, 44);
            this.rtxtHastaSikayet.Name = "rtxtHastaSikayet";
            this.rtxtHastaSikayet.Size = new System.Drawing.Size(180, 171);
            this.rtxtHastaSikayet.TabIndex = 9;
            this.rtxtHastaSikayet.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şikayet";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgDoktorRandevulari);
            this.groupBox3.Location = new System.Drawing.Point(215, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(768, 405);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevular";
            // 
            // dtgDoktorRandevulari
            // 
            this.dtgDoktorRandevulari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoktorRandevulari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDoktorRandevulari.Location = new System.Drawing.Point(3, 16);
            this.dtgDoktorRandevulari.Name = "dtgDoktorRandevulari";
            this.dtgDoktorRandevulari.Size = new System.Drawing.Size(762, 386);
            this.dtgDoktorRandevulari.TabIndex = 0;
            this.dtgDoktorRandevulari.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDoktorRandevulari_CellDoubleClick);
            // 
            // btnBilgiDuzenle
            // 
            this.btnBilgiDuzenle.Location = new System.Drawing.Point(11, 16);
            this.btnBilgiDuzenle.Name = "btnBilgiDuzenle";
            this.btnBilgiDuzenle.Size = new System.Drawing.Size(87, 23);
            this.btnBilgiDuzenle.TabIndex = 3;
            this.btnBilgiDuzenle.Text = "Bilgi Düzenle";
            this.btnBilgiDuzenle.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCikis);
            this.groupBox4.Controls.Add(this.btnDuyurular);
            this.groupBox4.Controls.Add(this.btnBilgiDuzenle);
            this.groupBox4.Location = new System.Drawing.Point(12, 334);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 83);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(11, 45);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(180, 23);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Location = new System.Drawing.Point(104, 16);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(87, 23);
            this.btnDuyurular.TabIndex = 6;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // frm_DoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(995, 429);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_DoktorDetay";
            this.Text = "frm_DoktorDetay";
            this.Load += new System.EventHandler(this.frm_DoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoktorRandevulari)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDoktorAdSoyad;
        private System.Windows.Forms.Label lblDoktorTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtHastaSikayet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBilgiDuzenle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.DataGridView dtgDoktorRandevulari;
    }
}