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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };

            Random rand = new Random();
            int s1,s2, s3;
            s1=rand.Next(0,sembol1.Length);
            s2=rand.Next(0,sembol2.Length);
            s3 = rand.Next(0, 10);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString();
        }
    }
}
