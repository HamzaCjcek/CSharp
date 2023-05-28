using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje
{
    public partial class Ogrenciİsleri : Form
    {
        public Ogrenciİsleri()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.OgrenciTableAdapter ds=new DataSet1TableAdapters.OgrenciTableAdapter();

        private void Ogrenciİsleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Ogrenci();
            SqlConnection baglanti = new SqlConnection(@"Data Source=Hamza;Initial Catalog=BonusOkul;Integrated Security=True");
            SqlCommand komut = new SqlCommand("Select * from Kulüp",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember= "DersAd";
            comboBox1.ValueMember= "İd";
            comboBox1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string c="";
            if(radioButton1.Checked==true)
            {
                c = "Kız";
            }
            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }
            ds.OgrenciEkle(textBox2.Text, textBox3.Text, int.Parse(comboBox1.Text), c);   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text=comboBox1.SelectedValue.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ds.OgrenciDelete(int.Parse(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string c = "";
            if (radioButton1.Checked == true)
            {
                c = "Kız";
            }
            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }
            ds.OgrenciUpdate(textBox2.Text, textBox3.Text,int.Parse(comboBox1.SelectedValue.ToString()), c,int.Parse(textBox1.Text));
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          dataGridView1.DataSource=ds.OgrenciGetir(textBox2.Text);
        }
    }
}
