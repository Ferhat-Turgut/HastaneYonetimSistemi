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
    public partial class frmHastaBilgiDüzenle : Form
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public frmHastaBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string tcno;
        private void frmHastaBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskHastaTC.Text = tcno;
            SqlCommand Hastaverileri = new SqlCommand("select * from Tbl_Hastalar where HastaTc='"+mskHastaTC.Text+"'",baglan.baglanti());
            SqlDataReader dr = Hastaverileri.ExecuteReader();
            while (dr.Read())
            {
                txtHastaAd.Text = dr[1].ToString();
                txtHastaSoyad.Text = dr[2].ToString();
                mskHastaTelefon.Text = dr[4].ToString();
                txtHastaSifre.Text = dr[5].ToString();
                cmbHastaCinsiyet.Text = dr[6].ToString();
            }
            baglan.baglanti().Close();
        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand HastaBilgiGuncelle = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6",baglan.baglanti());
            HastaBilgiGuncelle.Parameters.AddWithValue("@p1",txtHastaAd.Text);
            HastaBilgiGuncelle.Parameters.AddWithValue("@p2", txtHastaSoyad.Text);
            HastaBilgiGuncelle.Parameters.AddWithValue("@p3", mskHastaTelefon.Text);
            HastaBilgiGuncelle.Parameters.AddWithValue("@p4", txtHastaSifre.Text);
            HastaBilgiGuncelle.Parameters.AddWithValue("@p5", cmbHastaCinsiyet.Text);
            HastaBilgiGuncelle.Parameters.AddWithValue("@p6",tcno);
            HastaBilgiGuncelle.ExecuteNonQuery();
            MessageBox.Show("Güncelleme Başarılı");
            baglan.baglanti().Close();
        }
    }
}
