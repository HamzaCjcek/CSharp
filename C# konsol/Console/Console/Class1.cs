using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    internal class Class1
    {

        public void baglanti()
        {
            SqlConnection conn = new SqlConnection("Data Source=Hamza;Initial Catalog=Hastane;Integrated Security=True");
            conn.Open();
            
        }
    }
}
