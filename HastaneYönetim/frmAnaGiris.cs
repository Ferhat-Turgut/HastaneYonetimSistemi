using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetim
{
    public partial class frmAnaGiris : Form
    {
        public frmAnaGiris()
        {
            InitializeComponent();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            frmHastaGiris fr = new frmHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            frmDoktorGiriş fr = new frmDoktorGiriş();
            fr.Show();
            this.Hide();
        }

        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {
            frmSekreterGiris fr = new frmSekreterGiris();
            fr.Show();
            this.Hide();
        }
    }
}
