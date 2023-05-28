using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using System.Web.UI.WebControls;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Connection
        SqlConnection connection = new SqlConnection("Data Source=Hamza;Initial Catalog=Pizza;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            //DatagridView 'e yazdırma
            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Sipariş", connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt; 
            connection.Close();
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            //Veritabanına Verileri Ekleme
            connection.Open();
            SqlCommand komut = new SqlCommand("insert into Sipariş(Ad,Soyad,Telefon,Açıklama,Adres,Pizza,Boyut,PizzaMiktar,İçecek,İçecekMiktar,[Ek Ürün],[EkMiktar],[Toplam Fiyat]) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)", connection);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p4", textBox3.Text);
            komut.Parameters.AddWithValue("@p5", textBox4.Text);
            komut.Parameters.AddWithValue("@p6", comboBox1.Text);
            komut.Parameters.AddWithValue("@p7", comboBox5.Text);
            komut.Parameters.AddWithValue("@p8", comboBox6.Text);
            komut.Parameters.AddWithValue("@p9", comboBox3.Text);
            komut.Parameters.AddWithValue("@p10", comboBox8.Text);
            komut.Parameters.AddWithValue("@p11", comboBox4.Text);
            komut.Parameters.AddWithValue("@p12", comboBox9.Text);
            komut.Parameters.AddWithValue("@p13", label3.Text);

            komut.ExecuteNonQuery();
            connection.Close();
        }
        int selectedIndex;
        private void button2_Click(object sender, EventArgs e)
        {
            //Seçili olan hücrenin id'sine göre
            selectedIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells["İd"].Value);

            if (selectedIndex > -1)
            {
                connection.Open();
                SqlCommand komut = new SqlCommand("Delete from Sipariş where İd=@p1", connection);
                komut.Parameters.AddWithValue("@p1", selectedIndex);
                komut.ExecuteNonQuery();
                connection.Close();

            }
            int selectedIndex2 = dataGridView1.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
               
                dataGridView1.Rows.RemoveAt(selectedIndex2);
                dataGridView1.Refresh();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Pizza
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (comboBox5.SelectedIndex == 0)
                    {
                        if(comboBox6.SelectedIndex==0)
                        {
                            label12.Text = "15";
                        }
                        else if (comboBox6.SelectedIndex == 1) 
                        {
                            label12.Text = "30";
                        }
                        else if (comboBox6.SelectedIndex==2)
                        {
                            label12.Text = "45";
                        }
                    }
                    else if (comboBox5.SelectedIndex == 1)
                    {
                        if (comboBox6.SelectedIndex == 0)
                        {
                            label12.Text = "10";
                        }
                        else if (comboBox6.SelectedIndex == 1)
                        {
                            label12.Text = "20";
                        }
                        else if (comboBox6.SelectedIndex == 2)
                        {
                            label12.Text = "30";
                        }
                    }
                    else if (comboBox5.SelectedIndex == 2)
                    {
                        if (comboBox6.SelectedIndex == 0)
                        {
                            label12.Text = "5";
                        }
                        else if (comboBox6.SelectedIndex == 1)
                        {
                            label12.Text = "10";
                        }
                        else if (comboBox6.SelectedIndex == 2)
                        {
                            label12.Text = "20";
                        }
                    }
                    break;
                case 1:
                    if (comboBox5.SelectedIndex == 0)
                    {
                        if (comboBox6.SelectedIndex == 0)
                        {
                            label12.Text = "30";
                        }
                        else if (comboBox6.SelectedIndex == 1)
                        {
                            label12.Text = "60";
                        }
                        else if (comboBox6.SelectedIndex == 2)
                        {
                            label12.Text = "90";
                        }
                    }
                    else if (comboBox5.SelectedIndex == 1)
                    {
                        if (comboBox6.SelectedIndex == 0)
                        {
                            label12.Text = "25";
                        }
                        else if (comboBox6.SelectedIndex == 1)
                        {
                            label12.Text = "50";
                        }
                        else if (comboBox6.SelectedIndex == 2)
                        {
                            label12.Text = "75";
                        }
                    }
                    else if (comboBox5.SelectedIndex == 2)
                    {
                        if (comboBox6.SelectedIndex == 0)
                        {
                            label12.Text = "20";
                        }
                        else if (comboBox6.SelectedIndex == 1)
                        {
                            label12.Text = "40";
                        }
                        else if (comboBox6.SelectedIndex == 2)
                        {
                            label12.Text = "60";
                        }
                    }
                    break;
                case 2:
                    if (comboBox5.SelectedIndex == 0)
                    {
                        if (comboBox6.SelectedIndex == 0)
                        {
                            label12.Text = "25";
                        }
                        else if (comboBox6.SelectedIndex == 1)
                        {
                            label12.Text = "50";
                        }
                        else if (comboBox6.SelectedIndex == 2)
                        {
                            label12.Text = "75";
                        }
                    }
                    else if (comboBox5.SelectedIndex == 1)
                    {
                        if (comboBox6.SelectedIndex == 0)
                        {
                            label12.Text = "20";
                        }
                        else if (comboBox6.SelectedIndex == 1)
                        {
                            label12.Text = "40";
                        }
                        else if (comboBox6.SelectedIndex == 2)
                        {
                            label12.Text = "60";
                        }
                    }
                    else if (comboBox5.SelectedIndex == 2)
                    {
                        if (comboBox6.SelectedIndex == 0)
                        {
                            label12.Text = "15";
                        }
                        else if (comboBox6.SelectedIndex == 1)
                        {
                            label12.Text = "30";
                        }
                        else if (comboBox6.SelectedIndex == 2)
                        {
                            label12.Text = "45";
                        }
                    }
                    break;
                case 3:
                    if (comboBox5.SelectedIndex == 0)
                    {
                        if (comboBox6.SelectedIndex == 0)
                        {
                            label12.Text = "20";
                        }
                        else if (comboBox6.SelectedIndex == 1)
                        {
                            label12.Text = "40";
                        }
                        else if (comboBox6.SelectedIndex == 2)
                        {
                            label12.Text = "60";
                        }
                    }
                    else if (comboBox5.SelectedIndex == 1)
                    {
                        if (comboBox6.SelectedIndex == 0)
                        {
                            label12.Text = "15";
                        }
                        else if (comboBox6.SelectedIndex == 1)
                        {
                            label12.Text = "30";
                        }
                        else if (comboBox6.SelectedIndex == 2)
                        {
                            label12.Text = "45";
                        }
                    }
                    else if (comboBox5.SelectedIndex == 2)
                    {
                        if (comboBox6.SelectedIndex == 0)
                        {
                            label12.Text = "10";
                        }
                        else if (comboBox6.SelectedIndex == 1)
                        {
                            label12.Text = "20";
                        }
                        else if (comboBox6.SelectedIndex == 2)
                        {
                            label12.Text = "30";
                        }
                    }
                    break;

            }
            // İçecek
            switch (comboBox3.SelectedIndex) 
            {
                case 0: 
                    if(comboBox8.SelectedIndex == 0)
                    {
                        label14.Text = "5";
                    }
                    else if (comboBox8.SelectedIndex==1)
                    {
                        label14.Text = "10";
                    }
                    else if(comboBox8.SelectedIndex==2) 
                    {
                        label14.Text= "15";
                    }
                    break;
                case 1:
                    if (comboBox8.SelectedIndex == 0)
                    {
                        label14.Text = "5";
                    }
                    else if (comboBox8.SelectedIndex == 1)
                    {
                        label14.Text = "10";
                    }
                    else if (comboBox8.SelectedIndex == 2)
                    {
                        label14.Text = "15";
                    }
                    break;
                case 2:
                    if (comboBox8.SelectedIndex == 0)
                    {
                        label14.Text = "4";
                    }
                    else if (comboBox8.SelectedIndex == 1)
                    {
                        label14.Text = "8";
                    }
                    else if (comboBox8.SelectedIndex == 2)
                    {
                        label14.Text = "12";
                    }
                    break;
                case 3:
                    if (comboBox8.SelectedIndex == 0)
                    {
                        label14.Text = "4";
                    }
                    else if (comboBox8.SelectedIndex == 1)
                    {
                        label14.Text = "8";
                    }
                    else if (comboBox8.SelectedIndex == 2)
                    {
                        label14.Text = "12";
                    }
                    break;
            }
            // Ek Ürün
            switch(comboBox4.SelectedIndex) 
            {
                case 0:
                    if (comboBox9.SelectedIndex==0)
                    {
                        label15.Text = "2";
                    }
                    else if (comboBox9.SelectedIndex==1)
                    {
                        label15.Text = "4";
                    }
                    else if (comboBox9.SelectedIndex == 2)
                    {
                        label15.Text = "6";
                    }
                    break;
                case 1:
                    if (comboBox9.SelectedIndex == 0)
                    {
                        label15.Text = "1";
                    }
                    else if (comboBox9.SelectedIndex == 1)
                    {
                        label15.Text = "2";
                    }
                    else if (comboBox9.SelectedIndex == 2)
                    {
                        label15.Text = "3";
                    }
                    break;
                case 2:
                    if (comboBox9.SelectedIndex == 0)
                    {
                        label15.Text = "1";
                    }
                    else if (comboBox9.SelectedIndex == 1)
                    {
                        label15.Text = "2";
                    }
                    else if (comboBox9.SelectedIndex == 2)
                    {
                        label15.Text = "3";
                    }
                    break;

            }
            // Toplam Tutar
            int x, y, z;
            x=int.Parse(label12.Text);
            y=int.Parse(label14.Text);
            z=int.Parse(label15.Text);
            label3.Text = (x + y + z).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tüm Verileri Silme
            connection.Open();
            SqlCommand komut = new SqlCommand("Delete from Sipariş", connection);
            komut.ExecuteNonQuery();
            connection.Close();

            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = dataGridView1.SelectedCells.Count;
            label8.Text = selectedIndex.ToString();

            if (selectedIndex > -1)
            {
                connection.Open();
                SqlCommand komut = new SqlCommand("Delete from Sipariş where İd=@p1", connection);
                komut.Parameters.AddWithValue("@p1", selectedIndex);
                komut.ExecuteNonQuery();
                connection.Close();
                dataGridView1.Rows.RemoveAt(selectedIndex);
                dataGridView1.Refresh();
            }
        }
    }
}
