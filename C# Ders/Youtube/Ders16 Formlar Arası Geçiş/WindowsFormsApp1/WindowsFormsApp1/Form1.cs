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
            Form2 frm = new Form2();
            frm.label4.Text = textBox1.Text;
            double y1=Convert.ToDouble(textBox2.Text);
            double y2=Convert.ToDouble(textBox3.Text);
            double x1=Convert.ToDouble(textBox4.Text);
            double z=(y1+y2+x1)/3;
            frm.label5.Text = z.ToString();

            if (z<50)
            {
                frm.label6.Text = "Başarısız";
            }
            else if (z<=80)
            {
                frm.label6.Text = "Ort";
            }
            else if(z<=100)
            {
                frm.label6.Text = "Başarılı";
            }
            frm.ShowDialog();
        }
    }
}
