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
    public partial class DoktorKayit : Form
    {
        public DoktorKayit()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into DoktorBilgi(DoktorAd,DoktorSoyad,DoktorTc,DoktorBrans,DoktorSifre,DoktorTelefon)  VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p4", comboBox1.Text);
            komut.Parameters.AddWithValue("@p5", textBox1.Text);
            komut.Parameters.AddWithValue("@p6", maskedTextBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
