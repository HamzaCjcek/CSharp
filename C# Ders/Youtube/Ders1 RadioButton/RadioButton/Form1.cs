using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;//metni sola hizala
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;//metni ortaya hizala
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;//metni sağa hizala
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton4.Checked==true)
            {
                label2.Text = "Erkek";
            }
            else if(radioButton5.Checked==true)
            {
                label2.Text = "Kadın";
            }
            else if(radioButton6.Checked==true)
            {
                label4.Text = "Bekar";
            }
            else if(radioButton7.Checked==true)
            {
                this.BackColor = Color.Red;
                label4.Text = "Evli";
            }
        }
    }
}
