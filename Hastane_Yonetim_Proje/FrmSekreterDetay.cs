using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Common;

namespace Hastane_Yonetim_Proje
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        public string SktrTC;

    
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblSekreterDetatTC.Text = SktrTC;

      

            //Ad Soyad Çekme İşlemi

            SqlCommand komut2 = new SqlCommand("select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1 ", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", SktrTC);
            
            
            SqlDataReader dr = komut2.ExecuteReader();
            while(dr.Read())
            {
                lblSekreterADSOYAD.Text = dr[0].ToString();

            }
            bgl.baglanti().Close();

            //Branşları Çekme
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar", bgl.baglanti());
            
            da.Fill(dt);

            dataGridBranslar.DataSource = dt;
            //gridView da içeriğin tamamının kaplanmasın istersek AutoSizeColumnMode=Fill yaparsak olur


            //Doktorları Çekme İşlemi

            DataTable dt1 = new DataTable();

            SqlDataAdapter da2 = new SqlDataAdapter("select (DoktorAd+' '+DoktorSoyad) as Doktorlar,DoktorBrans" +
                ",DoktorTC from Tbl_Doktorlar", bgl.baglanti());

            da2.Fill(dt1);
            dataGridViewDoktorlar.DataSource = dt1;

            //Combobaxa Branşları Çekme İşlemi

            SqlCommand komut4 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2=komut4.ExecuteReader();
            while( dr2.Read())
            {
                cmbRandevuBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();


        


        }

        private void RandevuKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("insert into Tbl_Randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTC) values (@r1,@r2,@r3,@r4,@r5)", bgl.baglanti());

            komut3.Parameters.AddWithValue("@r1", mskRandevuTrih.Text);
            komut3.Parameters.AddWithValue("@r2", mskRandevuSaat.Text);
            komut3.Parameters.AddWithValue("@r3", cmbRandevuBrans.Text);
            komut3.Parameters.AddWithValue("@r4", cmbRandevuDoktor.Text);
            komut3.Parameters.AddWithValue("@r5", mskRandevuTC.Text);

            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ranedvu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            mskRandevuTrih.Text = "";
            mskRandevuSaat.Text = "";
            mskRandevuTC.Text = "";
            cmbRandevuBrans.Text = "";
            cmbRandevuDoktor.Text = "";
        }

        private void cmbRandevuBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //yani benim branş seçtiğimde sadece o branşa ait doktorlar listelenmeli
            cmbRandevuDoktor.Items.Clear();
            SqlCommand komut5 = new SqlCommand("select (DoktorAd+' '+DoktorSoyad) from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut5.Parameters.AddWithValue("@p1", cmbRandevuBrans.Text);
            
            SqlDataReader dr3 = komut5.ExecuteReader();
            while (dr3.Read())
            {
                cmbRandevuDoktor.Items.Add(dr3[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void DuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut6 = new SqlCommand("insert into Tbl_Duyuru (Duyuru) values (@d1)", bgl.baglanti());

            komut6.Parameters.AddWithValue("@d1", richtxtDuyuru.Text);
            komut6.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Eklendi","Duyuru",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frmDoktorPaneli = new FrmDoktorPaneli();
            frmDoktorPaneli.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBransPaneli frmBransPaneli = new FrmBransPaneli();
            frmBransPaneli.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmRandevuListe frmRandevuListe = new FrmRandevuListe();
            frmRandevuListe.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorDuyuru frmDoktorDuyuru = new FrmDoktorDuyuru();
            frmDoktorDuyuru.Show();
        }

        private void mskRandevuSaat_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
