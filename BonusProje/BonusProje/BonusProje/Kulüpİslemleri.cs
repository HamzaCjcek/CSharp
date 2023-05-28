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

namespace BonusProje
{
    public partial class Kulüpİslemleri : Form
    {
        public Kulüpİslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Hamza;Initial Catalog=BonusOkul;Integrated Security=True");
        void listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Kulüp", baglanti);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Kulüpİslemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kulüp (DersAd) values(@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Kulüp where İd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Kulüp set DersAd=@p1 where İd=@p2", baglanti);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
