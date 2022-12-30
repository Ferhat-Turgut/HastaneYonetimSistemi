using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HastaneYönetim
{
    public partial class frmHastaGiris : Form
    {
        sqlbaglantisi bagla = new sqlbaglantisi();
        public frmHastaGiris()
        {
            InitializeComponent();
        }

        private void lnkHastaKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaKayit fr = new frmHastaKayit();
            fr.Show();
            this.Hide();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            SqlCommand HastaGirisKontrol = new SqlCommand("select * from Tbl_Hastalar where HastaTc=@p1 and HastaSifre=@p2",bagla.baglanti());
            HastaGirisKontrol.Parameters.AddWithValue("@p1",mskHastaTc.Text);
            HastaGirisKontrol.Parameters.AddWithValue("@p2",txtHastaSifre.Text);
            SqlDataReader rd = HastaGirisKontrol.ExecuteReader();
            if (rd.Read())
            {
                frmHastaDetay Hastagiris = new frmHastaDetay();
                Hastagiris.tc = mskHastaTc.Text;
                Hastagiris.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            bagla.baglanti().Close();
        }
    }
}
