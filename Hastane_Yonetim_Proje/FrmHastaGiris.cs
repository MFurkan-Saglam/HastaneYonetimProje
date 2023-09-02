using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Data.SqlClient;

namespace Hastane_Yonetim_Proje
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUyeOl frmUyeOl = new FrmUyeOl(); 
            frmUyeOl.Show();
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {
            //AutoSizeMode= GrowandShrink yaparsam sağdan soldan büyütmeyi engeller.
            //MaximizeBox=False yaparsak büyütme küçültme kutucuğu inaktif olur.
            //AccepButton ise mesela formu doldurduk enter dediğimiz zaman girsin
            ////isterek AcceptButton özelliğini çalışmasını istediğim buttonu seçiyoru.m
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select * from Tbl_Hastalar " +
                "where HastaTC=@p1 and HastaParola=@p2", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", hastagirisMaskedTC.Text);
            sqlCommand.Parameters.AddWithValue("@p2", HastaGiristxtSifre.Text);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            if(reader.Read())
            {
                FrmHastaDetay frmHastaDetay = new FrmHastaDetay();
                //burada hasta detay kısmındaki tc yi oraya gönderme işlemi yapcaz.
                frmHastaDetay.tcno = hastagirisMaskedTC.Text; //bu işlemin show dan önce olması önemli
                frmHastaDetay.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Şifre veya TC");
            }
            bgl.baglanti().Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisler frmGirisler = new FrmGirisler();
            frmGirisler.Show();
            this.Hide();
        }
    }
}
