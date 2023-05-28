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
    public partial class SinavNotlari : Form
    {
        public SinavNotlari()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Hamza;Initial Catalog=BonusOkul;Integrated Security=True");
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void SinavNotlari_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Notlar INNER JOIN Ogrenci on Notlar.İd=Ogrenci.İd", baglanti);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            //Combox içine veritabanından veri getirme
            SqlCommand komut = new SqlCommand("Select * from Kulüp", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            comboBox1.DisplayMember = "DersAd";
            comboBox1.ValueMember = "İd";
            comboBox1.DataSource = dt2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sınav1 = double.Parse(textBox2.Text);
            double sınav2 = double.Parse(textBox3.Text);
            double proje = double.Parse(textBox5.Text);
            textBox6.Text=((sınav1+sınav2+proje)/3).ToString();
            int x = int.Parse(textBox6.Text);
            if (x>50)
            {
                textBox7.Text = "True";
            }
            else
            {
                textBox7.Text = "False";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource=ds.SinavNotlariAra(int.Parse(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.SinavNotlariUpdate2(int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox5.Text), Convert.ToDecimal(textBox6.Text),Convert.ToBoolean(textBox7.Text), int.Parse(textBox1.Text));

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = ds.SinavNotlariDelete();
        }
    }
}
