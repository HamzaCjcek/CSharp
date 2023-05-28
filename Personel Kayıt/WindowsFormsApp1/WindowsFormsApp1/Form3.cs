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
namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=HAMZA;Initial Catalog=Btk;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Select PerSehir,Count(*) from Personel group by PerSehir",conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
             while (reader.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(reader[0], reader[1]);
            }
            conn.Close();
            conn.Open();
            SqlCommand sqlCommand2 = new SqlCommand("Select PerMeslek,AVG(PerMaas) from Personel group by PerMeslek", conn);

            SqlDataReader reader2 = sqlCommand2.ExecuteReader();
            while (reader2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(reader2[0], reader2[1]);
            }
            conn.Close();
        }
    }
}
