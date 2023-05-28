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
namespace BonusProje
{
    public partial class OgrenciNotlar : Form
    {
        public OgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Hamza;Initial Catalog=BonusOkul;Integrated Security=True");
        public string numara;
        private void OgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select DersAD,Sınav1,Sınav2,Proje,Ortalama,Durum from Notlar INNER JOIN Dersler on Notlar.Dersİd=Dersler.İd Where Ogrİd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
           // this.Text = numara.ToString();
           SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }
    }
}
