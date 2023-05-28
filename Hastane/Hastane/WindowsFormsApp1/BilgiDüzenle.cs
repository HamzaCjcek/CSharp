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
    public partial class BilgiDüzenle : Form
    {
        public BilgiDüzenle()
        {
            InitializeComponent();
        }
        public string TcNo;
        SqlBaglanti bgl = new SqlBaglanti();
        private void BilgiDüzenle_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = TcNo;
            SqlCommand komut = new SqlCommand("select * from HastaBilgi where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            SqlDataReader dr =komut.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                maskedTextBox2.Text = dr[4].ToString();
                textBox1.Text=dr[5].ToString();
                comboBox1.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("UPDATE HastaBilgi SET HastaAd = @p2, HastaSoyad= @p3,HastaTelefon=@p4,HastaSifresi=@p5,HastaCinsiyet=@p6 WHERE HastaTc = @p1",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut2.Parameters.AddWithValue("@p2", textBox2.Text);
            komut2.Parameters.AddWithValue("@p3", textBox3.Text);
            komut2.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
            komut2.Parameters.AddWithValue("@p5", textBox1.Text);
            komut2.Parameters.AddWithValue("@p6", comboBox1.Text);
            komut2.ExecuteNonQuery();

            bgl.baglanti().Close();
        }
    }
}
