﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HastaneYönetim
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti() 
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-SKDKUH5\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
