using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection conn = new SqlConnection("Data Source=Hamza;Initial Catalog=Hastane;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
