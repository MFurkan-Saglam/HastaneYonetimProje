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
    public partial class FrmBilgiGuncelle : Form
    {
        public FrmBilgiGuncelle()
        {
            InitializeComponent();
        }

        //ben BilgiDüzenleye tıkladığım zaman BilgiGüncelle formunda hazır şekilde bilgilerim gelsin ki düzenleme yapayım


        public string TCNO;

        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmBilgiGuncelle_Load(object sender, EventArgs e)
        {
            maskedTextTC.Text = TCNO;
            SqlCommand komut = new SqlCommand(
                "select * from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextTC.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                maskedTextTel.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                comboBoxCinsiyet.Text= dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand updateKomut = new SqlCommand(
                "update Tbl_Hastalar set HastaAdı=@p1,HastaSoyad=@p2," +
                "HastaTelefon=@p3,HastaParola=@p4,HastaCinsiyet=@p5 where HastaTC=@p6"  , bgl.baglanti());
           //tc yi güncellemesin dedik o yüzden onu almadık.
            updateKomut.Parameters.AddWithValue("@p1", txtAd.Text);
            updateKomut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            updateKomut.Parameters.AddWithValue("@p3", maskedTextTel.Text);
            updateKomut.Parameters.AddWithValue("@p4", txtSifre.Text);
            updateKomut.Parameters.AddWithValue("@p5", comboBoxCinsiyet.Text);
            updateKomut.Parameters.AddWithValue("@p6", maskedTextTC.Text);

            updateKomut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); ;



        }
    }
}
