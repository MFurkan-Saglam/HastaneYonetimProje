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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tcno;
        SqlBaglanti bgl = new SqlBaglanti();
        private void lnkBilgiDuzen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiGuncelle frmBilgiGuncelle = new FrmBilgiGuncelle();
            frmBilgiGuncelle.TCNO=tcno;
            frmBilgiGuncelle.Show();
        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text= tcno;

            //AD SOYAD çekme
            SqlCommand komut = new SqlCommand("select HastaAdı,HastaSoyad from Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();


            //Randevu Geçmişi Çekme İşlemi 
            DataTable dt = new DataTable();
            //SqlDataAdapter verilerimi dataGridViewe aktarmak için kullanılır.
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevu where HastaTC="+tcno,bgl.baglanti());
            da.Fill(dt); //yani da daki bilgileri sanal veritabanım olan dtnin içine doldurdum
            dataGridViewRandevuGecmis.DataSource = dt;


            //Branş isimleri çekme
            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2=komut2.ExecuteReader();
            while(dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //şöyle bir sıkıntı vardı mesela branş seçtim a kişisi çıktı 
            //sonra başka branş seçtim sadece b kişisi çıkacakken a da çıktı o yüzden temizlesin her seçimde
            comboBoxDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",comboBoxBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while( dr3.Read())
            {
                comboBoxDoktor.Items.Add(dr3[0]+" " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

     

        private void dataGridViewAktifRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int tiklanan = dataGridViewAktifRandevu.SelectedCells[0].RowIndex;
            txtID.Text = dataGridViewAktifRandevu.Rows[tiklanan].Cells[0].Value.ToString();
        }

        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //doktoru seçtiğimde randevlar gelsin......
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(
                "select * from Tbl_Randevu where RandevuBrans='" + comboBoxBrans.Text + "'" + "and RandevuDoktor='" + comboBoxDoktor.Text + "'and RandevuDurum=0", bgl.baglanti());//bu kullanım güzel dikkat et.
            da.Fill(dt);
            dataGridViewAktifRandevu.DataSource = dt;
          
        }

        private void btnRasndevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand randevual = new SqlCommand("update Tbl_Randevu set RandevuDurum=1,HastaTC=@p1 where Randevuid=@p2", bgl.baglanti());
            randevual.Parameters.AddWithValue("@p1", lblTc.Text);
            randevual.Parameters.AddWithValue("@p2", txtID.Text);

            randevual.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı.....");
        }
    }
}
