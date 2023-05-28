using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet=0;
            double kitapfiyatı = 8;
            double indirim=0;
            double fatura=0;
            double fatura2 = 0;

            if (kitapadet<=20)
            {
                
                kitapadet = Convert.ToInt32(textBox1.Text);
                fatura = kitapadet * kitapfiyatı;
                indirim = fatura * 0.2;
                fatura2 = fatura - indirim;
               
                textBox2.Text = Convert.ToString(fatura2);

            }
            else if (kitapadet>=21 && kitapadet<40)
            {
                kitapadet = Convert.ToInt32(textBox1.Text);
                fatura = kitapadet * kitapfiyatı;
                indirim = fatura * 0.4;
                fatura2 = fatura - indirim;

                textBox2.Text = Convert.ToString(fatura2);

            }
            else
            {
                kitapadet = Convert.ToInt32(textBox1.Text);
                fatura = kitapadet * kitapfiyatı;
                indirim = fatura * 0.5;
                fatura2 = fatura - indirim;

                textBox2.Text = Convert.ToString(fatura2);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
