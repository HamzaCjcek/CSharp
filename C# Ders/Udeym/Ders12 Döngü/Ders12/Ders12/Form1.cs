using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 1; i < 6; i++)
            {
                int x = 5;
                listBox1.Items.Add((x - i)*x);
                
                toplam = toplam + i;
                
            }
            label1.Text = Convert.ToString(toplam);

            for (int y = 0; y < 10; y++)
            {
                if(y%3==0)
                {
                    listBox2.Items.Add(y);
                }
            }
            int sayi = Convert.ToInt32(textBox1.Text);
            double faktöriel = 1;
            for (int z=1; z<=sayi ;z++)
            {
                faktöriel = faktöriel * z;
                textBox2.Text = Convert.ToString(faktöriel);
            }
        }

    }
}
