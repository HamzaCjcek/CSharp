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
    public partial class İstatik : Form
    {
        public İstatik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void İstatik_Load(object sender, EventArgs e)
        {
            label2.Text=db.Kategoriler.Count().ToString();
            label3.Text=db.Urunler.Count().ToString();
            label5.Text=db.Musteriler.Count(x => x.Durum == true).ToString();
            label7.Text=db.Musteriler.Count(x=>x.Durum==false).ToString();
            label13.Text=db.Urunler.Sum(x=>x.Stok).ToString();
            //label11.Text=db.Urunler.Max(x=>x.Fiyat).ToString();
            label11.Text=(from x in db.Urunler orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();
            // label9.Text = db.Urunler.Min(x => x.Fiyat).ToString();
            label9.Text = (from x in db.Urunler orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();
            label15.Text=db.Urunler.Count(x=>x.Kategori==5).ToString();
            label17.Text=db.Urunler.Count(x=>x.UrunAd=="Bilgisayar").ToString();
            label21.Text = db.Satislar.Sum(x => x.Fiyat).ToString();
            label23.Text = (from x in db.Musteriler select x.Sehir).Distinct().Count().ToString();
            label19.Text=(from x in db.Urunler orderby x.Stok descending select x.Marka).FirstOrDefault();
        }
    }
}
