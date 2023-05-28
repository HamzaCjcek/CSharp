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
    public partial class Dersler : Form
    {
        public Dersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.DerslerTableAdapter ds = new DataSet1TableAdapters.DerslerTableAdapter();
        private void Dersler_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = ds.DersListesi(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.DersEkle(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ds.DersSil(int.Parse(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.DersUpdate(textBox2.Text,int.Parse(textBox1.Text));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
