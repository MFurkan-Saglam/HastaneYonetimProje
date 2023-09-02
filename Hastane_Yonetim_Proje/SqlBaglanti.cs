using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Hastane_Yonetim_Proje
{


    internal class SqlBaglanti
    {
        //bir metot tanımlayayım ve her çağırdığımda bana sql bağlantısı versin
        public SqlConnection baglanti()
        {
            SqlConnection conn = new SqlConnection("Data Source=--------------\\SQLEXPRESS;Initial Catalog=HastaneYonetimSistemi;Integrated Security=True");
            conn.Open();
            return conn;
        
        }
    }
}
