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

namespace Hastane_Yonetim_Proje
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public string DoktorTC;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblDoktorDetayTC.Text = DoktorTC;

            //Adı Soyadı Çekme İşlemi

            SqlCommand pullCommand=new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTC=@p1 ",bgl.baglanti());
            pullCommand.Parameters.AddWithValue("@p1", lblDoktorDetayTC.Text);
            SqlDataReader sqlDataReader = pullCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lblDoktorDetayAdSoyad.Text = sqlDataReader[0].ToString() +" "+ sqlDataReader[1].ToString();
 
            }
            bgl.baglanti().Close();


            //Doktora ait randevuların listelenmesi
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Tbl_Randevu where RandevuDoktor='" +lblDoktorDetayAdSoyad.Text+ "'", bgl.baglanti());
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void btnDoktorDetayBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frmDoktorBilgiDuzenle = new FrmDoktorBilgiDuzenle();
            frmDoktorBilgiDuzenle.Doktortc = DoktorTC;
            frmDoktorBilgiDuzenle.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDoktorDuyuru frmDoktorDuyuru = new FrmDoktorDuyuru();
            frmDoktorDuyuru.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
