using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox1.Text);
            switch (ay)
            {
                case 1:label2.Text = "Ocak";
                    break;
                case 2:label2.Text = "Şubat";
                    break;
                case 3:label2.Text = "Mart";
                    break;
            }

            string mevsim = textBox2.Text;
            switch (mevsim)
            {
                case "Yaz":label3.Text = "Haziran,Temmuz,Ağustos";
                    break;
                case "Kıs":label3.Text = "Aralık,Ocak,Şubat";
                    break;
                case "Sonbahar":label3.Text = "Eylül,Ekimi,Kasım";
                    break;
                case "İlkbahar":label3.Text = "Mart,Nisani,Mayıs";
                    break;

                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
