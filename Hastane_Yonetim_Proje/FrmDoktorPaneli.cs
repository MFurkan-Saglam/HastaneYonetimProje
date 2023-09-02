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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Combobaxa Branşları Çekme İşlemi

            SqlCommand komut3 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                cmbDoktorBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorParola) " +
                "values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtDoktorAd.Text);
            komut.Parameters.AddWithValue("@d2", txtDoktorSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbDoktorBrans.Text);
            komut.Parameters.AddWithValue("@d4", mskTC.Text);
            komut.Parameters.AddWithValue("@d5", txtParola.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi.....","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtDoktorAd.Text = "";
            txtDoktorSoyad.Text = "";
            cmbDoktorBrans.Text = "";
            mskTC.Text = "";
            txtParola.Text = "";

        }


        //event kısmında bulabilirsin. Daha önce CellDoubleClick yapmıştık bu sefer herhangi bir 
        //hücreye tek tık olduğu zmaan o bilgileri forma aktarsın istiyoruz.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int tiklananyer = dataGridView1.SelectedCells[0].RowIndex;
            txtDoktorAd.Text = dataGridView1.Rows[tiklananyer].Cells[1].Value.ToString();
            txtDoktorSoyad.Text = dataGridView1.Rows[tiklananyer].Cells[2].Value.ToString();
            cmbDoktorBrans.Text = dataGridView1.Rows[tiklananyer].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[tiklananyer].Cells[4].Value.ToString();
            txtParola.Text = dataGridView1.Rows[tiklananyer].Cells[5].Value.ToString();
        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("delete from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", mskTC.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Silindi.....", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorParola=@p5 where DoktorTC=@p4", bgl.baglanti());
            komut2.Parameters.AddWithValue("p1", txtDoktorAd.Text);
            komut2.Parameters.AddWithValue("p2", txtDoktorSoyad.Text);
            komut2.Parameters.AddWithValue("p3", cmbDoktorBrans.Text);
            komut2.Parameters.AddWithValue("p4", mskTC.Text);
            komut2.Parameters.AddWithValue("p5", txtParola.Text);

            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi.....", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmDoktorPaneli frmDoktorPaneli = new FrmDoktorPaneli();
            frmDoktorPaneli.Show();
        }
    }
}
