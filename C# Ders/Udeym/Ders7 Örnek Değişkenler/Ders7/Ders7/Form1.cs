using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mısır_m, su_m, cay_m, bilet_m,toplam;
            

            mısır_m = Convert.ToInt32(textBox1.Text);
            su_m = Convert.ToInt32(textBox2.Text);
            cay_m = Convert.ToInt32(textBox3.Text);
            bilet_m = Convert.ToInt32(textBox4.Text);
            toplam = mısır_m * 4 + su_m * 1 + cay_m * 1 + bilet_m * 10;
            label9.Text = Convert.ToString(toplam);

            

        }
    }
}
