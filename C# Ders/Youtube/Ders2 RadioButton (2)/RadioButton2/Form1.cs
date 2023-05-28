using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] diller = { "Türkçe","İngilizce","Arapça","Farsça","İbranice" };//dizi
            checkedListBox1.Items.AddRange(diller);//dizinin elemanlarını checkedlistbox a ekleme
            checkedListBox1.MultiColumn = true;//ikinci sütun ekleme
            checkedListBox1.CheckOnClick = true;// tek tıklama tek seçim
             button1.Enabled = false;//button nun aktifliği
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                button1.Enabled = false;
            }
            else 
            { 
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!="")
            {
                if (checkedListBox1.Items.Contains(textBox2.Text) == false)//checked ın içindeki eleman textboxa yazılmadıysa
                    checkedListBox1.Items.Add(textBox2.Text);//checked a yeni item ekle
                else
                    MessageBox.Show("Yazıla Dil Zaten Ekli");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedIndices.Count > 0) //topluca kaldırmak için while döngüsü kullanılır
            
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0],false); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
            string diller=" ",Mezuniyet =" ";
            for(int i=0; i<checkedListBox1.CheckedItems.Count; i++)
            {
                diller += "," + checkedListBox1.CheckedItems[i];

            }
            diller = diller.Substring(2);
            label6.Text = diller;
            if (radioButton1.Checked)
                Mezuniyet = radioButton1.Text;
            else if (radioButton2.Checked)
                Mezuniyet = radioButton2.Text;
            else if (radioButton3.Checked)
                Mezuniyet = radioButton3.Text;
            else if (radioButton4.Checked)
                Mezuniyet = radioButton4.Text;
            label8.Text = Mezuniyet;
        }
    }
}
