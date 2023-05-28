using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Ders11
{
    public partial class Form1 : Form
    {
        SoundPlayer soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\Hamza\Desktop\C# Form\Udeym\Ders11\m2.wav");
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dopru = 0, yanlış = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = button1.Text;
            label10.Text = button1.Text;
            label12.Text = button1.Text;
            label14.Text = button1.Text;
            if (label7.Text == label8.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;

            }
            else if (label9.Text == label10.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;
            }
            else if (label11.Text == label12.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;
            }
            else if (label13.Text == label14.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
            button6.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = button2.Text;
           label10.Text = button2.Text;
            label12.Text = button2.Text;
            label14.Text = button2.Text;
            if (label7.Text == label8.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;

            }
            else if (label9.Text == label10.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;
            }
            else if (label11.Text == label12.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;
            }
            else if (label13.Text == label14.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;
            }

            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
            button6.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = button3.Text;
            label10.Text = button3.Text;
            label12.Text = button3.Text;
            label14.Text = button3.Text;
            if (label7.Text == label8.Text )
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;

            }
            else if (label9.Text==label10.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;
            }
            else if (label11.Text == label12.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;
            }
            else if (label13.Text == label14.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;
            }

            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
            button6.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = button4.Text;
            label10.Text = button4.Text;
            label12.Text = button4.Text;
            label14.Text = button4.Text;
            if (label7.Text == label8.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;

            }
            else if (label9.Text == label10.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;
            }
            else if (label11.Text == label12.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;
            }
            else if (label13.Text == label14.Text)
            {
                dopru++;
                label4.Text = dopru.ToString();
                pictureBox1.Visible = true;
            }

            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
            button6.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            label2.Text = soruno.ToString();
            
            
            if (soruno==1)
            {
                richTextBox1.Text = "Erdem Kurt Kaç Yılında Doğdu?";
                button1.Text = "1071";
                button2.Text = "2003";
                button3.Text = "1980";
                button4.Text = "1453";
                
                label7.Text = "2003";
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Son Samuray Kimdir?";
                button1.Text = "Miyamoto Musaşi";
                button2.Text = "Minamoto Yoritomo";
                button3.Text = "Fatih Uğur(Başkan)";
                button4.Text = "Onna-bugeisha";
                
                label9.Text = "Fatih Uğur(Başkan)";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Kaanın en sevdiği ayak rengi ve numarası? ";
                button1.Text = "36.5 siyah ojeli";
                button2.Text = "37 kırmızı ojeli";
                button3.Text = "37.5 pembe ojeli";
                button4.Text = "36 beyaz ojeli";

                label11.Text = "36.5 siyah ojeli";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Enes Kaç Saniye de bir ossurur? ";
                button1.Text = "31 Saniye";
                button2.Text = "52 Saniye";
                button3.Text = "63 Saaniye";
                button4.Text = "Her an her saniye";

                label13.Text = "Her an her saniye";
            }




        }
    }
}
