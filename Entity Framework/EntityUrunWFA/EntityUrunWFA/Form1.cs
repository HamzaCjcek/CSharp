using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EntityUrunWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db =new DbEntityUrunEntities();

        private void buttonListele_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource=db.Kategoriler.ToList();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Kategoriler kategoriler = new Kategoriler();
            kategoriler.KategoriAd = textBox2.Text;
            db.Kategoriler.Add(kategoriler);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Tamamlandı");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            int x =Convert.ToInt32(textBox1.Text);
            var ktgr=db.Kategoriler.Find(x); // kategori tablosunda x satırın karşılığını hafızaya al
            db.Kategoriler.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.Kategoriler.Find(x);
            ktgr.KategoriAd=textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");
        }
    }
}
