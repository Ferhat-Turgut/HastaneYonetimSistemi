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
    public partial class frmHastaDetay : Form
    {
        public frmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bagla = new sqlbaglantisi();
        
        private void frmHastaDetay_Load(object sender, EventArgs e)
        {
            //AD Soyad Çekme
            lblHastaTc.Text = tc;            
            SqlCommand HastaBilgileri = new SqlCommand("select HastaAD,HastaSoyad from Tbl_Hastalar where HastaTc=@p1",bagla.baglanti());
            HastaBilgileri.Parameters.AddWithValue("@p1",lblHastaTc.Text);
            SqlDataReader dr = HastaBilgileri.ExecuteReader();
            while (dr.Read())
            {
                lblHastaAdSoyad.Text = (dr[0] + " " + dr[1]).ToUpper();
            }
            bagla.baglanti().Close();

            //Randevu Geçmişi çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where HastaTc="+tc,bagla.baglanti());
            da.Fill(dt);
            dtgRandevuGecmisi.DataSource = dt;

            //Branşları Çekme
            SqlCommand BransCekme = new SqlCommand("select BransAd from Tbl_Branslar",bagla.baglanti());
            SqlDataReader rd = BransCekme.ExecuteReader();
            while (rd.Read())
            {
                cmbBranssecimi.Items.Add(rd[0]);
            }
            bagla.baglanti().Close();

        }
        
        private void cmbBranssecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçilen branşa göre doktorları çekme
            cmbDoktorSecimi.Items.Clear();
            cmbDoktorSecimi.Text = "";
            SqlCommand DoktorCek = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1",bagla.baglanti());
            DoktorCek.Parameters.AddWithValue("@p1",cmbBranssecimi.Text);
            SqlDataReader rd = DoktorCek.ExecuteReader();
            
            while (rd.Read())
            {
                cmbDoktorSecimi.Items.Add(rd[0]+" "+rd[1]);
            }
            bagla.baglanti().Close();
        }

        private void cmbDoktorSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçilen doktora göre randevuları datagrid2 ye aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDoktor='"+cmbDoktorSecimi.Text+"'"+" and RandevuBrans='"+cmbBranssecimi.Text+"'"+"and RandevuDurum=0",bagla.baglanti());
            da.Fill(dt);
            dtgAktifRandevu.DataSource = dt;
            bagla.baglanti().Close();
        }

        private void lnkHastaBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //hasta bilgi düzenleme ekranına geçme ve tc noyu aktarma
            frmHastaBilgiDüzenle fr = new frmHastaBilgiDüzenle();
            fr.tcno = lblHastaTc.Text;
            fr.Show();
            this.Hide();
        }
        string secilenId;
        private void dtgAktifRandevu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenId = dtgAktifRandevu.CurrentRow.Cells[0].Value.ToString();
            cmbBranssecimi.Enabled = false;
            cmbDoktorSecimi.Enabled = false;
        }
        private void btnRndevuAl_Click(object sender, EventArgs e)
        {
          
            if (secilenId==null)
            {
                MessageBox.Show("Randevu Seçiniz");
            }
            else
            {
                SqlCommand RandevuKayit = new SqlCommand("update  Tbl_Randevular set RandevuDurum=1,HastaTc=@p1 where Randevuid=@p2", bagla.baglanti());
                RandevuKayit.Parameters.AddWithValue("@p1", lblHastaTc.Text);
                RandevuKayit.Parameters.AddWithValue("@p2", secilenId);
                RandevuKayit.ExecuteNonQuery();
                MessageBox.Show("Randevu Alındı");
                bagla.baglanti().Close();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDoktor='" + cmbDoktorSecimi.Text + "'" + " and RandevuBrans='" + cmbBranssecimi.Text + "'" + "and RandevuDurum=0", bagla.baglanti());
            da.Fill(dt);
            dtgAktifRandevu.DataSource = dt;
            bagla.baglanti().Close();

        }
        
       
    }
}
