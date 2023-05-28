using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDersleri

{
    internal class Temel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string x = "hamza";
            Console.WriteLine(x);
            Console.ReadLine();
            //
            int a, b, toplam;

            Console.WriteLine("Toplama İşlemi");
            Console.Write("İlk sayıyı giriniz ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz ");
            b=Convert.ToInt32(Console.ReadLine());
            toplam = a + b;
            Console.WriteLine("Toplam " + toplam);
            Console.ReadLine();
            //
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Gün 1");
                    break;
                case 2:
                    Console.WriteLine("Gün 2");
                    break;
                case 3:
                    Console.WriteLine("Gün 3");
                    break;
                case 4:
                    Console.WriteLine("Gün 4");
                    break;
                default: Console.WriteLine("Gün bilinmiyor");
                    break;
            }
            Console.Read();
        }
    }
}
