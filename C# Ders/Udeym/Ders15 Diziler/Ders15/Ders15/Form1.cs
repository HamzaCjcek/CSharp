using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] xd = { "hz","oz","cv" };
            label1.Text = xd[2];
            int[] lo = { 1, 2, 3 };
            label2.Text = lo[1].ToString();
            string[] sehirler = { "malatya", "adıyaman", "ankara", "erzurum", "antep" };
            for (int i = 0; i <sehirler.Length; i++)
            {
                listBox1.Items.Add(sehirler[i]);
            }

            //foreach  1=değişken türü,2=değişken adı,3=in(içinde),4=Dizi Adı;

            string[] kisiler = { "Ahmet", "Mehmet", "Hasan", "Hüseyin" };
            foreach(string k in kisiler)
            {
                listBox2.Items.Add(k);
            }
            int toplam = 0;
            int[] sınav = { 10, 20, 30, 40, 50 };
            foreach(int x in sınav)
            {
                listBox3.Items.Add(x);
                toplam = toplam + x;
            }
            label3.Text = Convert.ToString(toplam);
            int ort = toplam / sınav.Length;
            label4.Text = Convert.ToString(ort);
        }
    }
}
