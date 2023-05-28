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

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proje Hc tarafından","bilgi",MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.udemy.com/course/sifirdan-ileri-seviye-csharp-programlama/learn/lecture/8384768#overview");
        }

    }
}
