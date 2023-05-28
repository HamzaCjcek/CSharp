using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection oledb = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HamzaCicek\Downloads\Database1.mdb");

        void Listele()
        {
            DataTable dataTable= new DataTable();
            OleDbDataAdapter adapter= new OleDbDataAdapter("Select * from Kitaplar",oledb);
            adapter.Fill(dataTable);
            dataGridView1.DataSource= dataTable;
        }

        private void Btn_Listele_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
