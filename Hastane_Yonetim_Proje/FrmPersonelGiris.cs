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
    public partial class FrmPersonelGiris : Form
    {
        public FrmPersonelGiris()
        {
            InitializeComponent();
        }


        SqlBaglanti bgl = new SqlBaglanti();

        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Sekreter where SekreterTC=@p1 and SekreterParola=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskPersonelGirisTC.Text);
            komut.Parameters.AddWithValue("@p2", txtPersonelGirisSifre.Text);

            SqlDataReader rd=komut.ExecuteReader();
            if(rd.Read())
            {
                FrmSekreterDetay frmSekreterDetay = new FrmSekreterDetay();
                frmSekreterDetay.SktrTC = mskPersonelGirisTC.Text;
                frmSekreterDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Parola hatalı...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();

        }

        private void FrmPersonelGiris_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisler frmGirisler = new FrmGirisler();
            frmGirisler.Show();
            this.Hide();
        }
    }
}
