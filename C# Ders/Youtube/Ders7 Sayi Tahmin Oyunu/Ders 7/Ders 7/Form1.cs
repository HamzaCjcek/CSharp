using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int sayi = 0, tahminsayisi = 0, puan = 1000;

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin;
            tahminsayisi++;
            if (tahminsayisi<=10)//iki defa tap tuşuna bas
            {
                tahmin = int.Parse(textBox1.Text);//textbox nesnesine girilen ifadenin int değişkenine dönüştürülerek tahminde saklanmasını sağlar
                label6.Text = tahminsayisi.ToString();
                if (sayi<tahmin)
                {
                    label5.Text = "Tahmininizi Azaltınız";
                    puan = puan - 100;
                    label7.Text = Convert.ToString(puan);
                }
                else if (sayi>tahmin)
                {
                    label5.Text = "Tahmininizi Artırınız";
                    puan = puan - 100;
                    label7.Text = Convert.ToString(puan);
                }
                
                else 
                {
                    label5.Text = "Doğru Bildiniz";
                    label7.Text = Convert.ToString(puan);
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
                textBox1.Text = "";
               
                
            }
            else
            {
                textBox1.Enabled = false;
                MessageBox.Show("Hakkınız Kalmadı");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            button1.Enabled = true;
            button2.Enabled = false;
            Random rnd = new Random();
            sayi = rnd.Next(100);
            label8.Text= Convert.ToString(sayi);
            label5.Text = "";
            label6.Text = "0";
            label7.Text = "1000";
            
        }
    }
}
