using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // Access Veritabanı
using System.Windows.Forms.VisualStyles;
using System.Web.UI.WebControls;

namespace Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HamzaCicek\Downloads\Database1.mdb
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HamzaCicek\Downloads\Database2.accdb");

        void listele()
        { 
            baglanti.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Kimlik", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kimlik (ID,İsim,Soyad,Yas,Dogum) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_id.Text);
            komut.Parameters.AddWithValue("@p2", txt_ad.Text);
            komut.Parameters.AddWithValue("@p3", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p4", txt_yas.Text);
            komut.Parameters.AddWithValue("@p5", txt_dogum.Text);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            MessageBox.Show("Yeni İsim Eklendi");
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Delete * from Kimlik",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int x =int.Parse(txt_id.Text);
            int y=int.Parse(txt_yas.Text);
            OleDbCommand komut2 = new OleDbCommand("Update Kimlik Set İsim=@p1,Soyad=@p2,Yas=@p3,Dogum=@p4 where ID=@p5", baglanti);
            komut2.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut2.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut2.Parameters.AddWithValue("@p3", y);
            komut2.Parameters.AddWithValue("@p4", txt_dogum.Text);
            komut2.Parameters.AddWithValue("@p5", x);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veri Güncellendi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tıklandığında seçili olan hücrenin verisini aktarır
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_yas.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_dogum.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Kelime
          baglanti.Open();
            OleDbCommand dbCommand = new OleDbCommand("Select * from Kimlik where İsim=@p1", baglanti);
            dbCommand.Parameters.AddWithValue("@p1", guna2TextBox1.Text);
            DataTable dt=new DataTable();
            OleDbDataAdapter da=new OleDbDataAdapter(dbCommand);
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            baglanti.Close();
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //İçinde geçen harfe göre getirme
            baglanti.Open();
            OleDbCommand dbCommand = new OleDbCommand("Select * from Kimlik where İsim like '%"+guna2TextBox1.Text+"%'", baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(dbCommand);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
    }
}
