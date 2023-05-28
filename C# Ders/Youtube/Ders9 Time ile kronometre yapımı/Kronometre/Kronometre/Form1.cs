using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        int dakika = 0,saniye=1,salise=1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            dakika++;
            label4.Text = dakika.ToString();
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye++;
            label5.Text = saniye.ToString();
            if (saniye==60)
            {
                saniye = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            salise++;
            label6.Text = salise.ToString();
            if (salise==60)
            {
                salise = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();timer2.Start();timer3.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer2.Interval = 1000;
            timer3.Interval = 10;
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
        }
    }
}
