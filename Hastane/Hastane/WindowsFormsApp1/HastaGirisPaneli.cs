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
    public partial class HastaGirisPaneli : Form
    {
        public HastaGirisPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayit hastaKayit = new HastaKayit();
            this.Hide();
            hastaKayit.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from HastaBilgi where HastaTc=@p1 and HastaSifresi=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader reader=komut.ExecuteReader();
            if (reader.Read())
            {
                HastaDetay detay = new HastaDetay();
                detay.tc=maskedTextBox1.Text;
                this.Hide();
                detay.ShowDialog();
                
            }
            else 
            {
                MessageBox.Show("Girilen Bilgiler Yanlış");
            }
            bgl.baglanti().Close();

        }
            
    }
}
