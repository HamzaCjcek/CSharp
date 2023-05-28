using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Class1
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=HAMZA;Initial Catalog=DbPersonel;Integrated Security=True");
    }
}
