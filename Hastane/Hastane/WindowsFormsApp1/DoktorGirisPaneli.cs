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
    public partial class Doktor_Giriş : Form
    {
        public Doktor_Giriş()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoktorKayit doktorKayit = new DoktorKayit();
            this.Hide();
            doktorKayit.ShowDialog();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from DoktorBilgi where DoktorTc=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                DoktorDetay doktorDetay = new DoktorDetay();
                DoktorBilgiDüzenle dbd = new DoktorBilgiDüzenle();
                doktorDetay.DrTC = maskedTextBox1.Text;
                dbd.DrTC2 = maskedTextBox1.Text;
                this.Hide();
                doktorDetay.ShowDialog();
            }
            bgl.baglanti().Close();
        }

        private void Doktor_Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}
