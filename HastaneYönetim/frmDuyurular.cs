﻿using System;
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
    public partial class frmDuyurular : Form
    {
        sqlbaglantisi baglan = new sqlbaglantisi();
        public frmDuyurular()
        {
            InitializeComponent();
        }

        private void frmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Duyurular",baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.baglanti().Close();
        }
    }
}
