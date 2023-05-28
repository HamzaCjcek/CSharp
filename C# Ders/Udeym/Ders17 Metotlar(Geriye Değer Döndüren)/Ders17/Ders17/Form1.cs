using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam(int s1,int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        int küp(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = toplam(5, 7).ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBox1.Text);
            label2.Text = küp(s).ToString();
        }
    }
}
