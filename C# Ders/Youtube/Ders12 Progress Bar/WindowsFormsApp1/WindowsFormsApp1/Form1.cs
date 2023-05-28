using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar2.Step = 25; //Sürekli Artış
            progressBar1.Maximum = 11;
            textBox1.MaxLength = 11;

            progressBar3.Style = ProgressBarStyle.Marquee;
            progressBar3.MarqueeAnimationSpeed = 10;
            timer1.Interval = 5000;//5 saniye
            timer1.Start();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Value = textBox1.Text.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar2.PerformStep();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i==1)
            {
                timer1.Stop();
                this.Hide();
                //Form2 frm2 = new Form2;
                //frm2.Show();
            }
        }
    }
}
