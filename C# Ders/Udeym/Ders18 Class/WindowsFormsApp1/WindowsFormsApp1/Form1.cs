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
        class Araba: ArabaDetay
        {
            
            public string Renk;
            public int Hız;
            public double motor;
            public char durum;
            public int fiyat;
            private int yil;
            private string marka;
            public int Yıl
            {
                get { return yil; }
                set { yil = Math.Abs(value); }
            }
            public string markası
            {
                get { return marka; }
                set { marka = value.ToUpper(); }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba arb=new Araba();
            arb.Renk = "Mavi";
            arb.Hız = 160;
            arb.motor = 1245.56;
            arb.fiyat = 50000;
            arb.durum = 'S'; //sıfır
            arb.Yıl = -2016;
            arb.markası = "bmw";
            arb.plaka = "01D0780";
            arb.muayene = 2021;
            arb.sahibi = "Hamdi";

            label1.Text = arb.Renk;
            label2.Text=arb.Hız.ToString();
            label3.Text=arb.motor.ToString();
            label4.Text=arb.fiyat.ToString();
            label5.Text=arb.durum.ToString();
            label6.Text=arb.Yıl.ToString();
            label7.Text=arb.markası.ToString();
            label8.Text=arb.plaka.ToString();
            label9.Text=arb.muayene.ToString();
            label10.Text=arb.sahibi.ToString();
        }
    }
}
