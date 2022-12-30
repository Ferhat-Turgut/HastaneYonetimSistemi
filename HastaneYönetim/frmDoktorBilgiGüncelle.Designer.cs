
namespace HastaneYönetim
{
    partial class frmDoktorBilgiGüncelle
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnDoktorGuncelle = new System.Windows.Forms.Button();
            this.mskDoktorTC = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoktorSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoktorAd = new System.Windows.Forms.TextBox();
            this.cmbDoktorBrans = new System.Windows.Forms.ComboBox();
            this.txtDoktorSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(65, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 50);
            this.label7.TabIndex = 43;
            this.label7.Text = "      DOKTOR KAYIT \r\nGÜNCELLEME PANELİ";
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(186, 217);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnDoktorGuncelle.TabIndex = 42;
            this.btnDoktorGuncelle.Text = "GÜNCELLE";
            this.btnDoktorGuncelle.UseVisualStyleBackColor = true;
            // 
            // mskDoktorTC
            // 
            this.mskDoktorTC.Location = new System.Drawing.Point(133, 139);
            this.mskDoktorTC.Mask = "00000000000";
            this.mskDoktorTC.Name = "mskDoktorTC";
            this.mskDoktorTC.Size = new System.Drawing.Size(128, 20);
            this.mskDoktorTC.TabIndex = 39;
            this.mskDoktorTC.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "ŞİFRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "BRANŞ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "SOYAD:";
            // 
            // txtDoktorSoyad
            // 
            this.txtDoktorSoyad.Location = new System.Drawing.Point(133, 117);
            this.txtDoktorSoyad.Name = "txtDoktorSoyad";
            this.txtDoktorSoyad.Size = new System.Drawing.Size(128, 20);
            this.txtDoktorSoyad.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "AD:";
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Location = new System.Drawing.Point(133, 91);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(128, 20);
            this.txtDoktorAd.TabIndex = 30;
            // 
            // cmbDoktorBrans
            // 
            this.cmbDoktorBrans.FormattingEnabled = true;
            this.cmbDoktorBrans.Location = new System.Drawing.Point(133, 165);
            this.cmbDoktorBrans.Name = "cmbDoktorBrans";
            this.cmbDoktorBrans.Size = new System.Drawing.Size(128, 21);
            this.cmbDoktorBrans.TabIndex = 44;
            // 
            // txtDoktorSifre
            // 
            this.txtDoktorSifre.Location = new System.Drawing.Point(133, 191);
            this.txtDoktorSifre.Name = "txtDoktorSifre";
            this.txtDoktorSifre.Size = new System.Drawing.Size(128, 20);
            this.txtDoktorSifre.TabIndex = 45;
            // 
            // frmDoktorBilgiGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(369, 268);
            this.Controls.Add(this.txtDoktorSifre);
            this.Controls.Add(this.cmbDoktorBrans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDoktorGuncelle);
            this.Controls.Add(this.mskDoktorTC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDoktorSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoktorAd);
            this.Name = "frmDoktorBilgiGüncelle";
            this.Text = "frmDoktorBilgiGüncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDoktorGuncelle;
        private System.Windows.Forms.MaskedTextBox mskDoktorTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoktorSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoktorAd;
        private System.Windows.Forms.ComboBox cmbDoktorBrans;
        private System.Windows.Forms.TextBox txtDoktorSifre;
    }
}