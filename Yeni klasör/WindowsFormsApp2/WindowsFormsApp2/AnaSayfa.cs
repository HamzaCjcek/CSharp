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

namespace WindowsFormsApp2
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=HAMZA;Initial Catalog=Btk;Integrated Security=True");
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut1 = new SqlCommand("select * from Soru where İd =1", conn);
            SqlDataReader dr1 = komut1.ExecuteReader();//Select İçin Kullanılır
            while (dr1.Read())
            {

                textBox1.Text = dr1[0].ToString();
                textBox2.Text = dr1[2].ToString();
                textBox3.Text = dr1[3].ToString();
                textBox4.Text = dr1[4].ToString();
                textBox5.Text = dr1[5].ToString();
            }
            conn.Close();
        }
    }
}
