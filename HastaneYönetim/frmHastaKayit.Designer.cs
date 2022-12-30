
namespace HastaneYönetim
{
    partial class frmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaKayit));
            this.txtHastaAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHastaSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHastaSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskHastaTC = new System.Windows.Forms.MaskedTextBox();
            this.mskHastaTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbHastaCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnHastaKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHastaAd
            // 
            this.txtHastaAd.Location = new System.Drawing.Point(87, 64);
            this.txtHastaAd.Name = "txtHastaAd";
            this.txtHastaAd.Size = new System.Drawing.Size(128, 20);
            this.txtHastaAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOYAD:";
            // 
            // txtHastaSoyad
            // 
            this.txtHastaSoyad.Location = new System.Drawing.Point(87, 90);
            this.txtHastaSoyad.Name = "txtHastaSoyad";
            this.txtHastaSoyad.Size = new System.Drawing.Size(128, 20);
            this.txtHastaSoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TC:";
            // 
            // txtHastaSifre
            // 
            this.txtHastaSifre.Location = new System.Drawing.Point(87, 164);
            this.txtHastaSifre.Name = "txtHastaSifre";
            this.txtHastaSifre.Size = new System.Drawing.Size(128, 20);
            this.txtHastaSifre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TELEFON NO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ŞİFRE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CİNSİYET:";
            // 
            // mskHastaTC
            // 
            this.mskHastaTC.Location = new System.Drawing.Point(87, 112);
            this.mskHastaTC.Mask = "00000000000";
            this.mskHastaTC.Name = "mskHastaTC";
            this.mskHastaTC.Size = new System.Drawing.Size(128, 20);
            this.mskHastaTC.TabIndex = 2;
            this.mskHastaTC.ValidatingType = typeof(int);
            // 
            // mskHastaTelefon
            // 
            this.mskHastaTelefon.Location = new System.Drawing.Point(87, 138);
            this.mskHastaTelefon.Mask = "(999) 000-0000";
            this.mskHastaTelefon.Name = "mskHastaTelefon";
            this.mskHastaTelefon.Size = new System.Drawing.Size(128, 20);
            this.mskHastaTelefon.TabIndex = 3;
            // 
            // cmbHastaCinsiyet
            // 
            this.cmbHastaCinsiyet.FormattingEnabled = true;
            this.cmbHastaCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbHastaCinsiyet.Location = new System.Drawing.Point(87, 190);
            this.cmbHastaCinsiyet.Name = "cmbHastaCinsiyet";
            this.cmbHastaCinsiyet.Size = new System.Drawing.Size(128, 21);
            this.cmbHastaCinsiyet.TabIndex = 5;
            // 
            // btnHastaKaydet
            // 
            this.btnHastaKaydet.Location = new System.Drawing.Point(140, 217);
            this.btnHastaKaydet.Name = "btnHastaKaydet";
            this.btnHastaKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnHastaKaydet.TabIndex = 6;
            this.btnHastaKaydet.Text = "KAYDET";
            this.btnHastaKaydet.UseVisualStyleBackColor = true;
            this.btnHastaKaydet.Click += new System.EventHandler(this.btnHastaKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(38, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "HASTA KAYIT PANELİ";
            // 
            // frmHastaKayit
            // 
            this.AcceptButton = this.btnHastaKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(273, 277);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHastaKaydet);
            this.Controls.Add(this.cmbHastaCinsiyet);
            this.Controls.Add(this.mskHastaTelefon);
            this.Controls.Add(this.mskHastaTC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHastaSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHastaSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHastaAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHastaAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHastaSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHastaSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskHastaTC;
        private System.Windows.Forms.MaskedTextBox mskHastaTelefon;
        private System.Windows.Forms.ComboBox cmbHastaCinsiyet;
        private System.Windows.Forms.Button btnHastaKaydet;
        private System.Windows.Forms.Label label7;
    }
}