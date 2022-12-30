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
    public partial class frmSekreterGiris : Form
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public frmSekreterGiris()
        {
            InitializeComponent();
        }

        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {

            SqlCommand SekreterGiris = new SqlCommand("select * from Tbl_Sekreterler where SekreterTc='"+mskSekreterTc.Text+"'"+"and SekreterSifre='"+txtSekreterSifre.Text+"'",baglan.baglanti());
            SqlDataReader dr = SekreterGiris.ExecuteReader();
            if (dr.Read())
            {
                frmSekreterDetay fr = new frmSekreterDetay();
                fr.tc = mskSekreterTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            baglan.baglanti().Close();
        }
    }
}
