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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public string Doktortc;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            maskedDoktorBilgiTC.Text = Doktortc;

            SqlCommand komut = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Doktortc);
            SqlDataReader sqlDataReader=komut.ExecuteReader();
            while(sqlDataReader.Read())
            {
                txtDoktorBilgiAd.Text = sqlDataReader[1].ToString();
                txtDoktorBilgiSoyad.Text= sqlDataReader[2].ToString();
                comboDoktorBilgiBrans.Text=sqlDataReader[3].ToString();
                txtDoktorBilgiSifre.Text=sqlDataReader[5].ToString();
            }
            bgl.baglanti().Close();


            //Branş isimleri çekme
            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboDoktorBilgiBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnDoktorBilgi_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update Tbl_Doktorlar set " +
                "DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorParola=@p4 where DoktorTC=@p5", bgl.baglanti());

            guncelle.Parameters.AddWithValue("@p1", txtDoktorBilgiAd.Text);
            guncelle.Parameters.AddWithValue("@p2", txtDoktorBilgiSoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", comboDoktorBilgiBrans.Text);
            guncelle.Parameters.AddWithValue("@p4", txtDoktorBilgiSifre.Text);
            guncelle.Parameters.AddWithValue("@p5", maskedDoktorBilgiTC.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
