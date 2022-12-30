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
    public partial class frmDoktorEklemePaneli : Form
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public frmDoktorEklemePaneli()
        {
            InitializeComponent();
        }
        public SqlDataAdapter gridDoktorVerisi() 
        {
            //DATAGRİDE DOKTORLARI ATAMAK
            DataTable dt2 = new DataTable();
            SqlDataAdapter doktorlistesi = new SqlDataAdapter("select *  from Tbl_Doktorlar", baglan.baglanti());
            doktorlistesi.Fill(dt2);
            dtgDoktorListesi.DataSource = dt2;
            return doktorlistesi;

        }

        private void frmDoktorEklemePaneli_Load(object sender, EventArgs e)
        {
            //DATAGRİDE DOKTORLARI ATAMAK
            gridDoktorVerisi();
            baglan.baglanti().Close();


            //COMBOBOX A BRANŞLARI ATAMAK
            SqlCommand bransatama = new SqlCommand("select BransAd from Tbl_Branslar", baglan.baglanti());
            SqlDataReader dr2 = bransatama.ExecuteReader();
            while (dr2.Read())
            {
                cmbDoktorBrans.Items.Add(dr2[0]);
            }
            baglan.baglanti().Close();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            SqlCommand DoktorEkle = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)",baglan.baglanti());
            DoktorEkle.Parameters.AddWithValue("@p1",txtDoktorAd.Text);
            DoktorEkle.Parameters.AddWithValue("@p2", txtDoktorSoyad.Text);
            DoktorEkle.Parameters.AddWithValue("@p3", cmbDoktorBrans.Text);
            DoktorEkle.Parameters.AddWithValue("@p4", mskDoktorTc.Text);
            DoktorEkle.Parameters.AddWithValue("@p5", txtDoktorSifre.Text);
            DoktorEkle.ExecuteNonQuery();
            MessageBox.Show("Doktor Kaydı Başarılı");
            baglan.baglanti().Close();
            gridDoktorVerisi();
            baglan.baglanti().Close();


        }

        private void dtgDoktorListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgDoktorListesi.SelectedCells[0].RowIndex;
            SqlCommand secmeislemi = new SqlCommand("select * from Tbl_Doktorlar where Doktorid=@p1",baglan.baglanti());
            secmeislemi.Parameters.AddWithValue("@p1",secilen+1);
            SqlDataReader dr = secmeislemi.ExecuteReader();
            if (dr.Read())
            {
                txtDoktorAd.Text = dr[1].ToString();
                txtDoktorSoyad.Text = dr[2].ToString();
                cmbDoktorBrans.Text = dr[3].ToString();
                mskDoktorTc.Text = dr[4].ToString();
                txtDoktorSifre.Text = dr[5].ToString();
            }
            baglan.baglanti().Close();
        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            SqlCommand DoktorKayitSilme = new SqlCommand("delete from Tbl_Doktorlar where DoktorTc=@p1",baglan.baglanti());
            DoktorKayitSilme.Parameters.AddWithValue("@p1",mskDoktorTc.Text);
            DoktorKayitSilme.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");
            gridDoktorVerisi();
            baglan.baglanti().Close();

        }

        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            
            SqlCommand DoktorVeriGuncelle = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTc=@p5",baglan.baglanti());
            DoktorVeriGuncelle.Parameters.AddWithValue("@p1",txtDoktorAd.Text);
            DoktorVeriGuncelle.Parameters.AddWithValue("@p2", txtDoktorSoyad.Text);
            DoktorVeriGuncelle.Parameters.AddWithValue("@p3", cmbDoktorBrans.Text);
            DoktorVeriGuncelle.Parameters.AddWithValue("@p4", txtDoktorSifre.Text);
            DoktorVeriGuncelle.Parameters.AddWithValue("@p5", mskDoktorTc.Text);
            DoktorVeriGuncelle.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Güncelleme Yapıldı");            
            gridDoktorVerisi();
            baglan.baglanti().Close();
        }
    }
}
