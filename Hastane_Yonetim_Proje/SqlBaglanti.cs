using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Hastane_Yonetim_Proje
{

    //bu sınıfı oluşturduk çünkü her formun arkasında veri tabanı var ve ben sürekli aynı şeyi yapmak istemiyorum...

    internal class SqlBaglanti
    {
        //bir metot tanımlayayım ve her çağırdığımda bana sql bağlantısı yapsın bence mantıklı
        public SqlConnection baglanti()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FELGMAP\\SQLEXPRESS;Initial Catalog=HastaneYonetimSistemi;Integrated Security=True");
            conn.Open();
            return conn;
        
        }
    }
}
