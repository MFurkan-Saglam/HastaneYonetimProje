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
namespace Hastane_Yonetim_Proje
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {


        }

      
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisler frmGirisler = new FrmGirisler();
            frmGirisler.Show();
            this.Hide();
        }

        private void btnDoktorGiris_Click_1(object sender, EventArgs e)
        {
            SqlCommand commandLogin = new SqlCommand("select * from Tbl_Doktorlar " +
               "where DoktorTC=@p1 and DoktorParola=@p2", bgl.baglanti());
            commandLogin.Parameters.AddWithValue("@p1", mskDoktorGirisTC.Text);
            commandLogin.Parameters.AddWithValue("@p2", txtDoktorGirisParola.Text);

            SqlDataReader sqlDataReader = commandLogin.ExecuteReader();
            if (sqlDataReader.Read())
            {
                FrmDoktorDetay frmDoktorDetay = new FrmDoktorDetay();
                frmDoktorDetay.DoktorTC = mskDoktorGirisTC.Text;
                frmDoktorDetay.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Girdiğiniz Bilgiler Hatalıdır....","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
    }
}
