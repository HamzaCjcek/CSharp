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
    public partial class Ogretmen : Form
    {
        public Ogretmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kulüpİslemleri kulüp=new Kulüpİslemleri();
            kulüp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dersler dersler = new Dersler();
            dersler.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ogrenciİsleri isleri=new Ogrenciİsleri();
            isleri.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgretmenBilgi ogretmenBilgi=new OgretmenBilgi();
            ogretmenBilgi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SinavNotlari sinavNotlari=new SinavNotlari();
            sinavNotlari.Show();
        }
    }
}
