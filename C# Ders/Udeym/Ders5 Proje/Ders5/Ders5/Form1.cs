using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden:"+comboBox1.Text);
            listBox1.Items.Add("Nereye:"+comboBox2.Text);
            listBox1.Items.Add("Tarih:"+dateTimePicker1.Text);
            listBox1.Items.Add("Saat:"+maskedTextBox1.Text);
            listBox1.Items.Add("Koltuk Sayisi:"+comboBox3.Text);

            listBox1.Items.Add("Adi Soyad:"+textBox1.Text);
            listBox1.Items.Add("Tc:"+textBox2.Text);
            listBox1.Items.Add("Numarasi:"+maskedTextBox2.Text);

        }
    }
}
