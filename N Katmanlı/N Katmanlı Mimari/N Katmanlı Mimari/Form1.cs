using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace N_Katmanlı_Mimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<EntityPersonel> list = LogicPersonel.LLpersonellist();
            dataGridView1.DataSource= list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = textBox1.Text;
            ent.Soyad = textBox2.Text;
            ent.Sehir = textBox3.Text;
            ent.Gorev = textBox4.Text;
            ent.Maas = short.Parse(textBox5.Text);
            LogicPersonel.LLpersonelEkle(ent);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = int.Parse(textBox6.Text);
            LogicPersonel.LLpersonelSil(ent.Id);
        }
    }
}
