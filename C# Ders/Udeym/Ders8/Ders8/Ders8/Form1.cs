using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox5.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if (textBox1.Text=="Ali")
             {
                 label1.Text = "Doğru";
             }
             else
             {
                 label1.Text = "Yanlış";
             }*/

            int sayi = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox1.Text);
            if (sayi%2== 1 && sayi2==3)
            {
                label1.Text = "Doğru";

            }
            else
            {
                label1.Text = "Yanlış";
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            double vize=0, final=0, proje=0, ort=0;
            textBox5.Enabled = false;
            vize = Convert.ToDouble(textBox2.Text);
            final = Convert.ToDouble(textBox3.Text);
            proje = Convert.ToDouble(textBox4.Text);
            ort = vize * 0.3 + final * 0.7 + proje * 0.1;
            textBox5.Text = Convert.ToString(ort);
            if (ort<60)
            {
                MessageBox.Show("Kaldınız");
            }
            else
            {
                MessageBox.Show("Geçtiniz");
            }

        }
    }
}
