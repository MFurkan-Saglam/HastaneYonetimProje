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
    public partial class FrmDoktorDuyuru : Form
    {
        public FrmDoktorDuyuru()
        {
            InitializeComponent();
        }


        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmDoktorDuyuru_Load(object sender, EventArgs e)
        {
            DataTable dataTable=new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Tbl_Duyuru ", bgl.baglanti());
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource=dataTable;
        }
    }
}
