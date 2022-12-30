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
    public partial class frmRandevuListesi : Form
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public frmRandevuListesi()
        {
            InitializeComponent();
        }

        private void frmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter RndevuListesi = new SqlDataAdapter("select * from Tbl_Randevular",baglan.baglanti());
            RndevuListesi.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.baglanti().Close();
            
            
        }
       
    }
}
