using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YURT_KAYIT_SİSTEMLERİ
{
   public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
          SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FA25T5V\\SQLEXPRESS03;Initial Catalog=YURT KAYIT;Integrated Security=True");
          baglanti.Open();
          return baglanti;
        }

    }
}
