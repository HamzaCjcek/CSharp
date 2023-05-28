using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XSX x=new XSX();
            x.Add();
            x.Update();
            x.Id = 1;
            x.Name = "hamza";
            Console.WriteLine(x.Id) ;
            Console.WriteLine(x.Name);
            Console.WriteLine();
            Product product = new Product();
            product.ekle();
            product.cıkar();
            Console.ReadLine();
        }
    }
    class Product
    {
        public void ekle()
        {
            Console.WriteLine("Eklendi");
        }
        public void cıkar()
        {
            Console.WriteLine("Çıkartıldı");
        }
    }
 

}
