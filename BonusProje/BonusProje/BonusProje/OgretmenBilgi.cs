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
    public partial class OgretmenBilgi : Form
    {
        public OgretmenBilgi()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.OgretmenTableAdapter ds = new DataSet1TableAdapters.OgretmenTableAdapter();

        private void OgretmenBilgi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= ds.OgretmenGetir();
        }
    }
}
