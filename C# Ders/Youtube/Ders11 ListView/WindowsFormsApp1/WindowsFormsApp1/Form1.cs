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

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Tc", 150);
            listView1.Columns.Add("AdSoyad", 200);
            listView1.Columns.Add("Yas", 50);
            listView1.Columns.Add("Mezuniyet", 150);
            listView1.Columns.Add("Cinsiyet", 50);
            listView1.Columns.Add("DoğumYeri", 100);
            listView1.Columns.Add("Telefon", 150);
            listView1.Width =851;
            string[] mezuniyet = { "İlköğretim", "Ortaöğretim", "Önlisans", "Lisans" };
            comboBox1.Items.AddRange(mezuniyet);
            kayitsayisiniyaz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*string tc, adsoyad, yas, mezuniyet , doğumyeri, tel;
            tc = textBox1.Text;
            adsoyad = textBox2.Text;
            yas = textBox3.Text;
            mezuniyet = comboBox1.Text;
            doğumyeri = textBox4.Text;
            tel = maskedTextBox1.Text;
            string[] bilgi = { "Tc", "AdSoyad", "Mezuniyet",  "DoğumYeri", "Tel" };
            ListViewItem ekle = new ListViewItem(bilgi);
            listView1.Items.Add(ekle);*/

            string tc = "", adsoyad = "", yas = "", mezuniyet = "", cinsiyet = "", doğumyeri = "", tel = "";
            tc = textBox1.Text;
            adsoyad = textBox2.Text;
            yas = textBox3.Text;
            mezuniyet = comboBox1.Text;
            doğumyeri = textBox4.Text;
            tel = maskedTextBox1.Text;
            if (radioButton1.Checked==true)
            {
                cinsiyet = radioButton1.Text;

            }
            else if (radioButton2.Checked==true)
            {
                cinsiyet = radioButton2.Text;
            }

            string[] bilgi = {tc,adsoyad,yas,mezuniyet,cinsiyet,doğumyeri,tel };
            bool aranankayıt = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text==textBox1.Text)//listview ın 0 ncı satırının 0 ncı sütunu
                {
                    aranankayıt = true;
                    MessageBox.Show(textBox1.Text + "Tc Kimlik Numarası Zaten Kayıtlı");
                }
            }
            if (aranankayıt==false)
            {
                ListViewItem lvt = new ListViewItem(bilgi);
                if (tc != "" && adsoyad != "" && yas != "" && mezuniyet != "" && doğumyeri != "" && tel != "" && cinsiyet != "")
                {
                    listView1.Items.Add(lvt);
                }
                else
                    MessageBox.Show("Kayıt Bilgilerinde Eksiklik Var");
            }
            /*ListViewItem ekle = new ListViewItem(bilgi);
            listView1.Items.Add(ekle);*/
            kayitsayisiniyaz();

        }
        private void kayitsayisiniyaz()
        {
            int kayitsayisi = listView1.Items.Count;
            label8.Text = kayitsayisi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int secilensayisi = listView1.CheckedItems.Count;
            foreach (ListViewItem kayıtbilgisi in listView1.CheckedItems)
            {
                kayıtbilgisi.Remove();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int secilensayisi = listView1.SelectedItems.Count;
            foreach (ListViewItem kayıtbilgisi in listView1.SelectedItems)
            {
                kayıtbilgisi.Remove();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox4.Text = "";
            maskedTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool aranankayitkontrol = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text==textBox1.Text)
                {
                    aranankayitkontrol = true;
                    textBox2.Text = listView1.Items[i].SubItems[1].Text;
                    textBox3.Text = listView1.Items[i].SubItems[2].Text;
                    comboBox1.Text = listView1.Items[i].SubItems[3].Text;
                    if (listView1.Items[i].SubItems[4].Text=="Erkek")
                    {
                        radioButton1.Checked = true;
                    }
                    else if (listView1.Items[i].SubItems[4].Text=="Kadın")
                    {
                        radioButton2.Checked = true;
                    }
                    textBox4.Text = listView1.Items[i].SubItems[5].Text;
                    maskedTextBox1.Text = listView1.Items[i].SubItems[6].Text;
                    textBox2.Enabled = false;textBox3.Enabled = false;comboBox1.Enabled = false;
                    groupBox1.Enabled = false;textBox4.Enabled = false;maskedTextBox1.Enabled = false;
                }
            }

        }
    }
}
