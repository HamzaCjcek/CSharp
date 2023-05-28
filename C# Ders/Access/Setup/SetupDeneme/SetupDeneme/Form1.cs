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

namespace SetupDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl=new BaglantiSinif();
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.adres);
            conn.Open();
            SqlDataAdapter da=new SqlDataAdapter("Select * from Table1",bgl.adres);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }
    }
}
