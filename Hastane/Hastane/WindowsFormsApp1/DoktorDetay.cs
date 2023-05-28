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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class DoktorDetay : Form
    {
        public DoktorDetay()
        {
            InitializeComponent();
        }
        public string DrTC;
        SqlBaglanti bgl = new SqlBaglanti();
        private void DoktorDetay_Load(object sender, EventArgs e)
        {
            label3.Text = DrTC;
            
            SqlCommand komut =new SqlCommand("select DoktorAd,DoktorSoyad from DoktorBilgi where DoktorTc=@p1", bgl.baglanti());
         
            komut.Parameters.AddWithValue("@p1", label3.Text);
            SqlDataReader dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                 label4.Text = dr[0] + " " + dr[1];
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select Randevuid,HastaTc,RandevuBrans,RandevuDoktor,RandevuTarih,RandevuSaat,RandevuDurum,Sikayet from Randevu where RandevuDoktorTc=" + DrTC, bgl.baglanti());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            DoktorBilgiDüzenle dbd = new DoktorBilgiDüzenle();
            dbd.DrTC2 = label3.Text;
            this.Hide();
            dbd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Duyurular duyurular = new Duyurular();
            this.Hide();
            duyurular.ShowDialog();
        }
    }
}
