using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=HAMZA;Initial Catalog=Btk;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'btkDataSet.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //Data Source=HAMZA;Initial Catalog=Btk;Integrated Security=True
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.personelTableAdapter.Fill(this.btkDataSet.Personel);//Verilerin Görüntülenmesini Sağlar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            //SqlCommand komut = new SqlCommand("insert into Personel (PerAd, PerSoyad, PerSehir, PerMaas, PerDurum, PerMeslek) values ('Hamza', 'Çiçek', 'Adıyaman', 8000, 'true', 'Yazılımcı')",conn);
            SqlCommand komut = new SqlCommand("insert into Personel (PerAd, PerSoyad,PerSehir,PerMaas,PerDurum,PerMeslek) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", textBox6.Text);
            komut.Parameters.AddWithValue("@p4", textBox4.Text);
            komut.Parameters.AddWithValue("@p6", textBox5.Text);
            if(radioButton1.Checked==true)
            {
                label8.Text = "True";
                komut.Parameters.AddWithValue("@p5", label8.Text);
            }
            else if(radioButton2.Checked==true)
            {
                label8.Text = "False";
                komut.Parameters.AddWithValue("@p5", label8.Text);
            }
           
            komut.ExecuteNonQuery();//Sorguyu Çalıştır
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sil = new SqlCommand("delete from Personel where Perid =@p7",conn);
            sil.Parameters.AddWithValue("@p7", textBox1.Text);
            sil.ExecuteNonQuery();
            conn.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen=dataGridView1.SelectedCells[0]/*seçilen hücreleri içerisinde=SelectedCells*/.RowIndex; //Satır İndexi
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text=="True")
            {
                radioButton1.Checked= true;
            }
            else if(label8.Text=="False")
            {
                radioButton2.Checked= true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand güncelle=new SqlCommand("update Personel set PerAd=@a1 where Perid=@a7",conn);
            güncelle.Parameters.AddWithValue("@a1", textBox2.Text);
            güncelle.Parameters.AddWithValue("@a7", textBox1.Text);
            güncelle.ExecuteNonQuery();
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
