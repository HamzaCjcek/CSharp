using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DoktorBilgiDüzenle : Form
    {
        public DoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string DrTC2;
        SqlBaglanti bgl = new SqlBaglanti();
        private void DoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
           txt_tc.Text=DrTC2;
            SqlCommand komut= new SqlCommand("select * from DoktorBilgi where DoktorTc="+DrTC2, bgl.baglanti());
            SqlDataReader reader=komut.ExecuteReader();
            while(reader.Read())
            {
                textBox2.Text = reader[1].ToString();
                textBox3.Text = reader[2].ToString();
                comboBox1.Text=reader[4].ToString();
                textBox1.Text=reader[5].ToString();

            }
           
          bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("update DoktorBilgi set DoktorAd =@p1 ,DoktorSoyad=@p2 ,DoktorBrans=@p3,DoktorSifre=@p4,DoktorTelefon=@p5 where DoktorTc= " + DrTC2, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut.Parameters.AddWithValue("@p4", textBox1.Text);
            komut.Parameters.AddWithValue("@p5", maskedTextBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

    }
}
