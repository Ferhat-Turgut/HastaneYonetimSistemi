
namespace HastaneYönetim
{
    partial class frmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSekreterGiris));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSekreterGiris = new System.Windows.Forms.Button();
            this.mskSekreterTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSekreterSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ŞİFRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "TC:";
            // 
            // btnSekreterGiris
            // 
            this.btnSekreterGiris.Location = new System.Drawing.Point(148, 150);
            this.btnSekreterGiris.Name = "btnSekreterGiris";
            this.btnSekreterGiris.Size = new System.Drawing.Size(75, 23);
            this.btnSekreterGiris.TabIndex = 3;
            this.btnSekreterGiris.Text = "Giriş Yap";
            this.btnSekreterGiris.UseVisualStyleBackColor = true;
            this.btnSekreterGiris.Click += new System.EventHandler(this.btnSekreterGiris_Click);
            // 
            // mskSekreterTc
            // 
            this.mskSekreterTc.Location = new System.Drawing.Point(121, 99);
            this.mskSekreterTc.Mask = "00000000000";
            this.mskSekreterTc.Name = "mskSekreterTc";
            this.mskSekreterTc.Size = new System.Drawing.Size(100, 20);
            this.mskSekreterTc.TabIndex = 0;
            this.mskSekreterTc.Text = "44444444444";
            this.mskSekreterTc.ValidatingType = typeof(int);
            // 
            // txtSekreterSifre
            // 
            this.txtSekreterSifre.Location = new System.Drawing.Point(121, 125);
            this.txtSekreterSifre.Name = "txtSekreterSifre";
            this.txtSekreterSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSekreterSifre.TabIndex = 1;
            this.txtSekreterSifre.Text = "306565";
            this.txtSekreterSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "SEKRETER GİRİŞ PANELİ";
            // 
            // frmSekreterGiris
            // 
            this.AcceptButton = this.btnSekreterGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(349, 179);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSekreterGiris);
            this.Controls.Add(this.mskSekreterTc);
            this.Controls.Add(this.txtSekreterSifre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmSekreterGiris";
            this.Text = "Sekreter Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSekreterGiris;
        private System.Windows.Forms.MaskedTextBox mskSekreterTc;
        private System.Windows.Forms.TextBox txtSekreterSifre;
        private System.Windows.Forms.Label label1;
    }
}