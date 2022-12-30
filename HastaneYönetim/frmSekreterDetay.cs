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
    public partial class frmSekreterDetay : Form
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public frmSekreterDetay()
        {
            InitializeComponent();
        }

        public string tc;
        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            //Randevu listesinden gelen randevuyu ekleme
           
            lblSekreterTc.Text = tc;

            //sekreter ad soyad çekme
            SqlCommand SekreterisimCekme = new SqlCommand("select SekreterAdSoyad from Tbl_Sekreterler where SekreterTc='"+tc+"'",baglan.baglanti());
            SqlDataReader dr = SekreterisimCekme.ExecuteReader();
            if (dr.Read())
            {
                lblSekreterAdSoyad.Text = dr[0].ToString();
            }
            baglan.baglanti().Close();

            //branşları datagrid1 e aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter branscekme = new SqlDataAdapter("select * from Tbl_Branslar",baglan.baglanti());
            branscekme.Fill(dt1);
            dataGridView1.DataSource = dt1;
            baglan.baglanti().Close();

            //doktor listesi çekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter doktorlistesi = new SqlDataAdapter("select (DoktorAd+' '+DoktorSoyad ) Doktor ,DoktorBrans Branş from Tbl_Doktorlar", baglan.baglanti());
            doktorlistesi.Fill(dt2);
            dataGridView2.DataSource = dt2;
            baglan.baglanti().Close();

            //branşı comboboxa atama

            SqlCommand bransatama = new SqlCommand("select BransAd from Tbl_Branslar",baglan.baglanti());
            SqlDataReader dr2 = bransatama.ExecuteReader();
            while (dr2.Read())
            {
                cmbRandevuBrans.Items.Add(dr2[0]);
            }
            baglan.baglanti().Close();
        
        }

        private void cmbRandevuBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BRANŞA GÖRE CMX A DOKTOR LİSTELEME
            cmbRandevuDoktor.Items.Clear();
            SqlCommand bransaDoktorCek = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans='"+cmbRandevuBrans.Text+"'",baglan.baglanti());
            SqlDataReader dr3 = bransaDoktorCek.ExecuteReader();
            while (dr3.Read())
            {
                cmbRandevuDoktor.Items.Add(dr3[0]+" "+dr3[1]);
            }
            baglan.baglanti().Close();
        }

        private void btnRandevuKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand RandevuKayit = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)",baglan.baglanti());
            RandevuKayit.Parameters.AddWithValue("@p1",mskRandevuTarih.Text);
            RandevuKayit.Parameters.AddWithValue("@p2",mskRandevuSaat.Text);
            RandevuKayit.Parameters.AddWithValue("@p3", cmbRandevuBrans.Text);
            RandevuKayit.Parameters.AddWithValue("@p4", cmbRandevuDoktor.Text);
            RandevuKayit.ExecuteNonQuery();
            MessageBox.Show("Randevu Oluşturuldu");
            baglan.baglanti().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand DuyuruKaydet = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@p1)",baglan.baglanti());
            DuyuruKaydet.Parameters.AddWithValue("@p1",rchDuyurular.Text);
            DuyuruKaydet.ExecuteNonQuery();
            MessageBox.Show("Duyuru Kaydedildi");
            rchDuyurular.Clear();
            baglan.baglanti().Close();
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            frmDoktorEklemePaneli fr = new frmDoktorEklemePaneli();
            fr.Show();
            this.Hide();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            frmBransPaneli fr = new frmBransPaneli();
            fr.Show();
            this.Hide();
        }

        private void btnRandevular_Click(object sender, EventArgs e)
        {
            frmRandevuListesi fr = new frmRandevuListesi();
            fr.Show();
            
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular fr = new frmDuyurular();
            fr.Show();
        }
    }
}
