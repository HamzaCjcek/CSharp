using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OgrenciNotlar notlar = new OgrenciNotlar();
            notlar.numara = textBox1.Text;
            notlar.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Show();
        }
    }
}
