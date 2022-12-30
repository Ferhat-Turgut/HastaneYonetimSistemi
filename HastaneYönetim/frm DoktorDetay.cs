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
    public partial class frm_DoktorDetay : Form
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public frm_DoktorDetay()
        {
            InitializeComponent();
        }
        public string tc;
        private void frm_DoktorDetay_Load(object sender, EventArgs e)
        {
            lblDoktorTc.Text = tc;
            SqlCommand doktorAdCek = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTc=@t1",baglan.baglanti());
            doktorAdCek.Parameters.AddWithValue("@t1",tc);
            SqlDataReader dr = doktorAdCek.ExecuteReader();
            while (dr.Read())
            {
                string Doktorad =dr[0]+" "+dr[1].ToString();
                lblDoktorAdSoyad.Text = Doktorad;
                DataTable dt = new DataTable();
                SqlDataAdapter RandevuCek = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDoktor='"+Doktorad+"'" ,baglan.baglanti());
                RandevuCek.Fill(dt);
                dtgDoktorRandevulari.DataSource = dt;

            }
            baglan.baglanti().Close();
            
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular fr = new frmDuyurular();
            fr.Show();
            
        }

        private void dtgDoktorRandevulari_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
