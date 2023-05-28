using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin;
            metin = "afdsfa";
            metin = textBox1.Text;
            label1.Text = metin;
            int sayi;
            sayi = 14;
            sayi =Convert.ToInt32(textBox2.Text);//sayiiyi yazdırmak istedğimiz
            label2.Text = sayi.ToString();// labela yazdırmak istediğimiz değer

            int kenar, alan, cevre;
            kenar =Convert.ToInt32(textBox3.Text);
            alan = kenar * kenar;
            cevre = kenar * 4;
            label3.Text = "Alan =" + alan + " Çevre =" + cevre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, carpım, fark, bolum;
            sayi1 = Convert.ToInt32(textBox4.Text);
            sayi2 = Convert.ToInt32(textBox5.Text);
            toplam = sayi1 + sayi2;
            carpım = sayi1 * sayi2;
            fark = sayi1 - sayi2;
            bolum = sayi1 / sayi2;

            MessageBox.Show(" Toplam =" + toplam + " Çarpım =" + carpım + " Fark =" + fark + " Bölüm =" + bolum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char ders;
            ders = Convert.ToChar(textBox6.Text);
            label6.Text = Convert.ToString(ders);

        }
    }
}
