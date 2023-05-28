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
    public partial class HastaDetay : Form
    {
        public HastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglanti bgl = new SqlBaglanti();
        private void HastaDetay_Load(object sender, EventArgs e)
        {   
            //Ad soyad çekme
            label3.Text = tc;
            SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad from HastaBilgi where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label4.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close(); 
            
            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Randevu where HastaTc="+tc, bgl.baglanti());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
           
            //Branşlar
            SqlCommand komut2=new SqlCommand(("select BransAd from BransBilgi"), bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //Aktif Randevular
            DataTable dt2 = new DataTable();
            SqlDataAdapter komut3 = new SqlDataAdapter("select RandevuDoktor,RandevuBrans,Sikayet,HastaTc,RandevuTarih,RandevuSaat from Randevu where RandevuDurum=1 and HastaTc ="+tc, bgl.baglanti());
            komut3.Fill(dt2);
            dataGridView2.DataSource = dt2;
    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string veri = comboBox1.SelectedItem.ToString();
            SqlCommand komut3 = new SqlCommand(("select DoktorAd,DoktorSoyad from DoktorBilgi where DoktorBrans=@p1"), bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", veri);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add(dr3[0] +" " + dr3[1]);
            }
           
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BilgiDüzenle bilgiDüzenle=new BilgiDüzenle();
            bilgiDüzenle.TcNo=label3.Text;
            this.Hide();
            bilgiDüzenle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut =new SqlCommand("INSERT INTO Randevu(RandevuBrans, RandevuDoktor, RandevuDurum,Sikayet, RandevuSaat, RandevuTarih,HastaTc) VALUES (@p1,@p2,1,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            komut.Parameters.AddWithValue("@p2", comboBox2.Text);
            komut.Parameters.AddWithValue("@p3", richTextBox1.Text);
            komut.Parameters.AddWithValue("@p4", comboBox3.Text);
            komut.Parameters.AddWithValue("@p5", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@p6", label3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
