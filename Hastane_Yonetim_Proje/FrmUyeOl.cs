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
    public partial class FrmUyeOl : Form
    {
        public FrmUyeOl()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl=new SqlBaglanti();
        private void btnKayitYap_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Hastalar " +
                "(HastaAdı,HastaSoyad,HastaTC,HastaTelefon,HastaParola,HastaCinsiyet) " +
                "values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti() );

            sqlCommand.Parameters.AddWithValue("@p1", txtAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", maskedTextTC.Text);
            sqlCommand.Parameters.AddWithValue("@p4", maskedTextTel.Text);
            sqlCommand.Parameters.AddWithValue("@p5", txtSifre.Text);
            sqlCommand.Parameters.AddWithValue("@p6", comboBoxCinsiyet.Text);
            sqlCommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız gerçeklemiştir.Şifreniz:"+txtSifre.Text,
                "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);




        }

        private void FrmUyeOl_Load(object sender, EventArgs e)
        {

        }
    }
}
