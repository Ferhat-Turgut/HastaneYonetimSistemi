
namespace HastaneYönetim
{
    partial class frmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.mskHastaTc = new System.Windows.Forms.MaskedTextBox();
            this.btnHastaGiris = new System.Windows.Forms.Button();
            this.lnkHastaKayit = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHastaSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA GİRİŞ PANELİ";
            // 
            // mskHastaTc
            // 
            this.mskHastaTc.Location = new System.Drawing.Point(147, 79);
            this.mskHastaTc.Mask = "00000000000";
            this.mskHastaTc.Name = "mskHastaTc";
            this.mskHastaTc.Size = new System.Drawing.Size(100, 20);
            this.mskHastaTc.TabIndex = 2;
            this.mskHastaTc.ValidatingType = typeof(int);
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.Location = new System.Drawing.Point(172, 131);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(75, 23);
            this.btnHastaGiris.TabIndex = 3;
            this.btnHastaGiris.Text = "Giriş Yap";
            this.btnHastaGiris.UseVisualStyleBackColor = true;
            this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // lnkHastaKayit
            // 
            this.lnkHastaKayit.AutoSize = true;
            this.lnkHastaKayit.Location = new System.Drawing.Point(268, 112);
            this.lnkHastaKayit.Name = "lnkHastaKayit";
            this.lnkHastaKayit.Size = new System.Drawing.Size(43, 13);
            this.lnkHastaKayit.TabIndex = 4;
            this.lnkHastaKayit.TabStop = true;
            this.lnkHastaKayit.Text = "Kayıt Ol";
            this.lnkHastaKayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHastaKayit_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ŞİFRE:";
            // 
            // txtHastaSifre
            // 
            this.txtHastaSifre.Location = new System.Drawing.Point(147, 105);
            this.txtHastaSifre.Name = "txtHastaSifre";
            this.txtHastaSifre.Size = new System.Drawing.Size(100, 20);
            this.txtHastaSifre.TabIndex = 1;
            // 
            // frmHastaGiris
            // 
            this.AcceptButton = this.btnHastaGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 169);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkHastaKayit);
            this.Controls.Add(this.btnHastaGiris);
            this.Controls.Add(this.mskHastaTc);
            this.Controls.Add(this.txtHastaSifre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHastaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HastaGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskHastaTc;
        private System.Windows.Forms.Button btnHastaGiris;
        private System.Windows.Forms.LinkLabel lnkHastaKayit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHastaSifre;
    }
}