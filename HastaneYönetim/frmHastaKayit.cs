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
    public partial class frmHastaKayit : Form
    {

        sqlbaglantisi bagla = new sqlbaglantisi();
        public frmHastaKayit()
        {
            InitializeComponent();
        }

        private void btnHastaKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bagla.baglanti());
            kaydet.Parameters.AddWithValue("@p1",txtHastaAd.Text);
            kaydet.Parameters.AddWithValue("@p2", txtHastaSoyad.Text);
            kaydet.Parameters.AddWithValue("@p3", mskHastaTC.Text);
            kaydet.Parameters.AddWithValue("@p4", mskHastaTelefon.Text);
            kaydet.Parameters.AddWithValue("@p5", txtHastaSifre.Text);
            kaydet.Parameters.AddWithValue("@p6", cmbHastaCinsiyet.Text);
            kaydet.ExecuteNonQuery();
            bagla.baglanti().Close();
            MessageBox.Show("Kaydınız Başarılı. Şifreniz:"+txtHastaSifre.Text,"Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}
