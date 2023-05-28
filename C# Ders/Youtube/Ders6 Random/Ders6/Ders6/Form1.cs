using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rndsayi = rnd.Next(100);//1,49 yazılırsa 1 ile 49 arası sayıları seçer
            label1.Text = Convert.ToString(rndsayi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color[] renk = new Color[4] { Color.Red, Color.Green, Color.Blue, Color.Black };
            Random sec = new Random();
            int renklerden = sec.Next(0, 3);
            this.BackColor = renk[renklerden];

        }
    }
}
