using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dopru = 0, yanlış = 0;
        SqlConnection conn = new SqlConnection("Data Source=HAMZA;Initial Catalog=Btk;Integrated Security=SSP");
        private void button2_Click(object sender, EventArgs e)
        {
            if (label7.Text == label2.Text)
            {
                dopru++;
                label5.Text = "Doğru Sayisi :" + dopru.ToString();
                button2.BackColor = Color.Green;

            }
            else
            {
                yanlış++;
                label6.Text = "Yanlış Sayisi :" + yanlış.ToString();
                button2.BackColor = Color.Red;
            }
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label7.Text == label3.Text)
            {
                dopru++;
                label5.Text = "Doğru Sayisi :" + dopru.ToString();
                button3.BackColor = Color.Green;

            }
            else
            {
                yanlış++;
                label6.Text = "Yanlış Sayisi :" + yanlış.ToString();
                button3.BackColor = Color.Red;
            }
            button2.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label7.Text == label4.Text)
            {
                dopru++;
                label5.Text = "Doğru Sayisi :" + dopru.ToString();
                button4.BackColor = Color.Green;

            }
            else
            {
                yanlış++;
                label6.Text = "Yanlış Sayisi :" + yanlış.ToString();
                button4.BackColor = Color.Red;
            }
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
            button5.Enabled = true;
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
     
            soruno++;
            label9.Text = soruno.ToString();
            Random rnd = new Random();
            int rastgelesayi = rnd.Next(1, 3);
           

                conn.Open();
                SqlCommand komut1 = new SqlCommand("select * from KMOister where İd ="+rastgelesayi, conn);
                SqlDataReader dr1 = komut1.ExecuteReader();//Select İçin Kullanılır
                while (dr1.Read())
                {
                   
                richTextBox1.Text = dr1[1].ToString();
                    label1.Text= dr1[2].ToString();
                    label2.Text= dr1[3].ToString();
                    label3.Text= dr1[4].ToString();
                    label4.Text= dr1[5].ToString();
                }
                conn.Close();
                label5.Text = rastgelesayi.ToString();
                label7.Text = "Bu fight clubda ilk gecense, düvüşmek zorunda değilsin";
                button5.Text = "Diğer Soru";
            
 
        }
        private void button6_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label7.Text == label1.Text)
            {
                dopru++;
                label5.Text = "Doğru Sayisi :" + dopru.ToString();
                button1.BackColor = Color.Green;

            }
            else
            {
                yanlış++;
                label6.Text = "Yanlış Sayisi :" + yanlış.ToString();
                button1.BackColor = Color.Red;

            }
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }
    }
}
