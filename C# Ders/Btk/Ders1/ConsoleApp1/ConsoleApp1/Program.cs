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
            var number = 11;
            // if elsenin diğer kullanımı single line
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
            

            switch (number) //number için
            {
                case 12://eğer number 12 ise
                    Console.WriteLine("number is " + number);
                    break;

                    default://yukarıdaki şartlar olmuyor ise
                    Console.WriteLine(number);
                    break;//işlemi bitir
            }

            var number2 = 95;
            if (number2<100)
            {
                Console.WriteLine("number 100 den kuçuktur");

                if (number2>=90 && number<100)
                {
                    Console.WriteLine(number2);
                }
            }
            hesapla();
            var result  = hesapla2(1, 2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static void hesapla()
        {
            Console.WriteLine("Added");
        }
        static int hesapla2(int x,int y)//int yazdıgımızdan resulte int olmalı
        {
            var result = x + y;
            return result;
        }
    }
}
