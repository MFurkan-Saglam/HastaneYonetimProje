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
using System.Data.Common;

namespace Hastane_Yonetim_Proje
{
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar ", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource= dt;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int tiklanan = dataGridView1.SelectedCells[0].RowIndex;
            txtBransID.Text = dataGridView1.Rows[tiklanan].Cells[0].Value.ToString();
            txtBransAD.Text= dataGridView1.Rows[tiklanan].Cells[1].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1=new SqlCommand("insert into Tbl_Branslar (BransAd) values(@b2)",bgl.baglanti());
            
            komut1.Parameters.AddWithValue("@b2", txtBransAD.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi.....", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("delete from Tbl_Branslar where Bransid=@b1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@b1", txtBransID.Text);

            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi.....", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update  Tbl_Branslar set BransAd=@b1 where Bransid=@b2", bgl.baglanti());
            komut3.Parameters.AddWithValue("@b1", txtBransAD.Text);
            komut3.Parameters.AddWithValue("@b2", txtBransID.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi.....", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmBransPaneli frmBransPaneli = new FrmBransPaneli();
            frmBransPaneli.Show();

        }
    }
}
