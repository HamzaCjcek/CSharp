using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //const double Pİ = 3.14;
            //const string x = "hamza";
            /*sabit olmak zorunda */ //const int[] notlar = { 1, 2, 3, 4 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double kdv = 0.18,otv=0.45;
            int fiyat;
            
            fiyat = Convert.ToInt32(textBox1.Text);
            textBox2.Text =Convert.ToString(kdv);
            textBox3.Text = Convert.ToString(otv);

            double toplam = fiyat +kdv + otv;
            textBox4.Text = Convert.ToString(toplam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
