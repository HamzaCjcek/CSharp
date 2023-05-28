namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*  Form2 newform=new Form2();
              newform.ShowDialog();//Show da olur */

            int kitapadet = 0;
            double kitapfiyatý = 8;
            double indirim = 0;
            double fatura = 0;
            double fatura2 = 0;
            kitapadet = int.Parse(textBox1.Text);
            if (kitapadet<=20)
            {
                
                fatura = kitapadet * kitapfiyatý;
                indirim = fatura * 0.2;
                fatura2 = fatura - indirim;
                textBox2.Text=fatura2.ToString();
            }
            else if(kitapadet>=21 && kitapadet<=40)
            {
                fatura = kitapadet * kitapfiyatý;
                indirim = fatura * 0.5;
                fatura2=(fatura - indirim);
                textBox2.Text = fatura2.ToString();
            }
            else 
            {
                fatura = kitapadet * kitapfiyatý;
                indirim = fatura * 0.8;
                fatura2 = (fatura - indirim);
                textBox2.Text = fatura2.ToString();
            }
        }
    }
}