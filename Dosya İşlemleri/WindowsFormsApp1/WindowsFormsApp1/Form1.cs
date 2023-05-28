using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string dosyaadi, dosyayolu;
        StreamWriter sw;

        private void button7_Click(object sender, EventArgs e)
        {
            dosyaadi = textBox2.Text;
            sw = File.CreateText(dosyayolu + "\\" + dosyaadi+".txt");
            sw.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr=new StreamReader(openFileDialog.FileName);
                string satir= sr.ReadLine();
                while(satir != null)
                {
                    listBox1.Items.Add(satir);
                    satir=sr.ReadLine();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Metin Dosyalar|*.txt";
            saveFileDialog.Title = "Metin Belgesi";
            saveFileDialog.ShowDialog();
            StreamWriter sw=new StreamWriter(saveFileDialog.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            MessageBox.Show("Kayıt Oluşturuldu");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                dosyayolu=folderBrowserDialog.SelectedPath;
                textBox1.Text = dosyayolu;
            }
        }
    }
}
