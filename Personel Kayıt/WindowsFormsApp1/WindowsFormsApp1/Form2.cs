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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=HAMZA;Initial Catalog=Btk;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut1 = new SqlCommand("select COUNT(*) from Personel", conn);
            SqlDataReader dr1=komut1.ExecuteReader();//Select İçin Kullanılır
            while (dr1.Read())
            {
                label7.Text = dr1[0].ToString();
            }
            conn.Close();
            conn.Open();
            SqlCommand komut2 = new SqlCommand("select COUNT(*) from Personel where  PerDurum=1", conn);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                label8.Text = dr2[0].ToString();

            }
            conn.Close();
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select COUNT(*) from Personel where  PerDurum=0", conn);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label9.Text = dr3[0].ToString();

            }
            conn.Close();
            conn.Open();
            SqlCommand komut4 = new SqlCommand("select COUNT(PerSehir) from Personel", conn);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                label10.Text = dr4[0].ToString();

            }
            conn.Close();
            conn.Open();
            SqlCommand komut5 = new SqlCommand("select SUM(PerMaas) from Personel", conn);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                label11.Text = dr5[0].ToString();

            }
            conn.Close();
            conn.Open();
            SqlCommand komut6 = new SqlCommand("select AVG(PerMaas) from Personel", conn);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                label12.Text = dr6[0].ToString();

            }
            conn.Close();
        }
    }
}
