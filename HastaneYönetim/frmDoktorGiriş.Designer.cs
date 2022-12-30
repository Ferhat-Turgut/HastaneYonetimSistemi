
namespace HastaneYönetim
{
    partial class frmDoktorGiriş
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDoktorGiris = new System.Windows.Forms.Button();
            this.mskDoktorTc = new System.Windows.Forms.MaskedTextBox();
            this.txtDoktorSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ŞİFRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "TC:";
            // 
            // btnDoktorGiris
            // 
            this.btnDoktorGiris.Location = new System.Drawing.Point(112, 130);
            this.btnDoktorGiris.Name = "btnDoktorGiris";
            this.btnDoktorGiris.Size = new System.Drawing.Size(75, 23);
            this.btnDoktorGiris.TabIndex = 10;
            this.btnDoktorGiris.Text = "Giriş Yap";
            this.btnDoktorGiris.UseVisualStyleBackColor = true;
            this.btnDoktorGiris.Click += new System.EventHandler(this.btnDoktorGiris_Click);
            // 
            // mskDoktorTc
            // 
            this.mskDoktorTc.Location = new System.Drawing.Point(87, 75);
            this.mskDoktorTc.Mask = "00000000000";
            this.mskDoktorTc.Name = "mskDoktorTc";
            this.mskDoktorTc.Size = new System.Drawing.Size(100, 20);
            this.mskDoktorTc.TabIndex = 9;
            this.mskDoktorTc.ValidatingType = typeof(int);
            // 
            // txtDoktorSifre
            // 
            this.txtDoktorSifre.Location = new System.Drawing.Point(87, 104);
            this.txtDoktorSifre.Name = "txtDoktorSifre";
            this.txtDoktorSifre.Size = new System.Drawing.Size(100, 20);
            this.txtDoktorSifre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "DOKTOR GİRİŞ PANELİ";
            // 
            // frmDoktorGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(285, 189);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDoktorGiris);
            this.Controls.Add(this.mskDoktorTc);
            this.Controls.Add(this.txtDoktorSifre);
            this.Controls.Add(this.label1);
            this.Name = "frmDoktorGiriş";
            this.Text = "frmDoktorGiriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDoktorGiris;
        private System.Windows.Forms.MaskedTextBox mskDoktorTc;
        private System.Windows.Forms.TextBox txtDoktorSifre;
        private System.Windows.Forms.Label label1;
    }
}