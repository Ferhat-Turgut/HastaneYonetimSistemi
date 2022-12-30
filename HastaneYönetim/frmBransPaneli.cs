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
    public partial class frmBransPaneli : Form
    {
        sqlbaglantisi baglan = new sqlbaglantisi();

        public frmBransPaneli()
        {
            InitializeComponent();
        }

        public SqlDataAdapter BransCek() 
        {
            DataTable dt = new DataTable();
            SqlDataAdapter BransCek = new SqlDataAdapter("select * from Tbl_Branslar", baglan.baglanti());
            BransCek.Fill(dt);
            dtgBransListesi.DataSource = dt;
            return BransCek;
        }
        private void frmBransPaneli_Load(object sender, EventArgs e)
        {
            BransCek();
            baglan.baglanti().Close();

        }

        private void dtgBransListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string secilen = dtgBransListesi.CurrentRow.Cells[1].Value.ToString();
            SqlCommand BransCek1 = new SqlCommand("select * from Tbl_Branslar where BransAd=@p1",baglan.baglanti());
            BransCek1.Parameters.AddWithValue("@p1",secilen);
            SqlDataReader dr = BransCek1.ExecuteReader();
            while (dr.Read())
            {
                txtBransId.Text = dr[0].ToString();
                txtBransAdi.Text = dr[1].ToString();
            }
            baglan.baglanti().Close();
           
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            SqlCommand BransEkle = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@p1)",baglan.baglanti());
            BransEkle.Parameters.AddWithValue("@p1",txtBransAdi.Text);
            BransEkle.ExecuteNonQuery();
            MessageBox.Show("Branş Eklendi");
            baglan.baglanti().Close();
            BransCek();
            baglan.baglanti().Close();

        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            SqlCommand BransSil = new SqlCommand("delete from Tbl_Branslar where BransAd=@p1",baglan.baglanti());
            BransSil.Parameters.AddWithValue("@p1",txtBransAdi.Text);
            BransSil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");
            baglan.baglanti().Close();
            BransCek();
            baglan.baglanti().Close();
        }

        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand BransGuncelle = new SqlCommand("update Tbl_Branslar set BransAd=@p1 where Bransid=@p2",baglan.baglanti());
            BransGuncelle.Parameters.AddWithValue("@p1",txtBransAdi.Text);
            BransGuncelle.Parameters.AddWithValue("@p2",txtBransId.Text);
            BransGuncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi");
            baglan.baglanti().Close();
            BransCek();
            baglan.baglanti().Close();
        }

        
    }
}
