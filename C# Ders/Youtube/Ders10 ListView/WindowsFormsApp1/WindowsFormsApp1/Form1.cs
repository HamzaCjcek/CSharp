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
            /*int no;
            string ad, soyad;
            no = Convert.ToInt32(textBox1.Text);
            ad = textBox2.Text;
            soyad = textBox3.Text;
            listView1.Items.Add(ad);
            listView1.Items.Add(soyad);
            listView1.Items.Add(no.ToString());*/

            String no, ad, soyad;
            no = textBox1.Text;
            ad = textBox2.Text;
            soyad = textBox3.Text;
            string[] kişi = { no, ad, soyad };
            ListViewItem ekle = new ListViewItem(kişi);
            listView1.Items.Add(ekle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            listView1.Columns.Add("NO", 50);//colums sütun demek
            listView1.Columns.Add("ad", 200);
            listView1.Columns.Add("soyad", 200);
            listView1.Width = 455;//genişlik ayarlığı
        }
    }
}
