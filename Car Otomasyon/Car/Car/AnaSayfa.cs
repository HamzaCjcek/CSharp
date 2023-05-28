using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void MusteriEkleme_Click(object sender, EventArgs e)
        {
            MusteriEkleme musteriekle = new MusteriEkleme();
            this.Hide();
            musteriekle.ShowDialog();
        }

        private void MusteriKayıt_Click(object sender, EventArgs e)
        {
            MusteriListeleme musteriListeleme =new MusteriListeleme();
            this.Hide();
            musteriListeleme.ShowDialog();
        }

        private void AracListele_Click(object sender, EventArgs e)
        {
            AracListele araclistele=new AracListele();
            this.Hide();
            araclistele.ShowDialog();
        }

        private void AracKayıt_Click(object sender, EventArgs e)
        {
            AracKayit aracKayit = new AracKayit();
            this.Hide();
            aracKayit.ShowDialog();
        }

        private void sözlesme_Click(object sender, EventArgs e)
        {
            Sözlesme söz = new Sözlesme();
            this.Hide();
            söz.ShowDialog();
        }

        private void satis_Click(object sender, EventArgs e)
        {
            Satislar satislar = new Satislar();
            this.Hide();
            satislar.ShowDialog();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
