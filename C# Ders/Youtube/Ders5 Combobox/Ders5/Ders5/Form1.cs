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

        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] markalar= { "Opel", "Bwm", "Mercedes", "Passat" };
            //comboBox1.Items.AddRange(markalar);
            comboBox1.Items.Add("Audi");
            comboBox1.Items.Add("Suzuki");

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Audi")
            {
                comboBox2.Items.Add("A1");
                comboBox2.Items.Add("A2");
                comboBox2.Items.Add("A3");
                comboBox3.Items.Add("2018");
                comboBox3.Items.Add("2019");
                comboBox3.Items.Add("2020");
            }
            else if(comboBox1.Text=="Suzuki")
            {
                comboBox2.Items.Add("Vitara");
                comboBox2.Items.Add("Swift");
                comboBox2.Items.Add("Jimny");
                comboBox3.Items.Add("2018");
                comboBox3.Items.Add("2019");
                comboBox3.Items.Add("2020");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(comboBox2.Text);
            listBox1.Items.Add(comboBox3.Text);

        }
    }
}
