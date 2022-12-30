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
    public partial class frmDoktorGiriş : Form
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public frmDoktorGiriş()
        {
            InitializeComponent();
        }
      
        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            SqlCommand DoktorGiris = new SqlCommand("select * from Tbl_Doktorlar where DoktorTc=@p1 and DoktorSifre=@p2",baglan.baglanti());
            DoktorGiris.Parameters.AddWithValue("@p1",mskDoktorTc.Text);
            DoktorGiris.Parameters.AddWithValue("@p2",txtDoktorSifre.Text);
            SqlDataReader dr = DoktorGiris.ExecuteReader();
            if (dr.Read())
            {
                
                
                frm_DoktorDetay fr = new frm_DoktorDetay();
                fr.tc = dr[4].ToString();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
