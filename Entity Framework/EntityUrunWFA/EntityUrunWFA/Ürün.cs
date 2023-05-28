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
    public partial class Ürün : Form
    {
        public Ürün()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=(from x in db.Urunler
                                      select new
                                      {
                                          x.Urunİd,
                                          x.UrunAd,
                                          x.Marka,
                                          x.Stok,
                                          x.Fiyat,
                                          x.Kategoriler.KategoriAd,
                                          x.Durum

                                      }
                                      ).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urunler urunler=new Urunler();
            urunler.UrunAd = textBox2.Text;
            urunler.Marka = textBox3.Text;
            urunler.Stok =short.Parse(textBox4.Text);
            urunler.Fiyat =Convert.ToDecimal(textBox5.Text);
            urunler.Durum =Convert.ToBoolean(textBox6.Text);
            urunler.Kategori =Convert.ToInt16(comboBox1.SelectedValue.ToString());
            db.Urunler.Add(urunler);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Tamamlandı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var urunler=db.Urunler.Find(x);
            db.Urunler.Remove(urunler);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Tamamlandı");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var urunler = db.Urunler.Find(x);
            urunler.UrunAd = textBox2.Text;
            urunler.Marka = textBox3.Text;
            urunler.Stok = short.Parse(textBox4.Text);
            urunler.Fiyat = Convert.ToDecimal(textBox5.Text);
            urunler.Durum = Convert.ToBoolean(textBox6.Text);
            urunler.Kategori = Convert.ToInt16(comboBox1.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Urunler Güncellendi");
        }

        private void Ürün_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Kategoriler 
                               select new 
                               { x.Kategoriİd,
                                 x.KategoriAd 
                               }).ToList();
            comboBox1.ValueMember = "Kategoriİd";
            comboBox1.DisplayMember= "KategoriAd";
            comboBox1.DataSource= kategoriler;
        }
    }
}
