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
            string[] vs = { "Engin","Derin","Mahmut"};

            int[] sayılar = new int[3];//{1,2,3} diyede yazılabilir
            sayılar[0] = 1;
            sayılar[1] = 2;
            sayılar[2]= 3;


            //Coklu Dizi

            string[,] regions = new string[5, 3]
             {
                 {"İstanbul","İzmit","Balıkesir"},
                 {"Ankara","Konya","Kırıkkale"},
                 {"Antalya","Adana","Mersin"},
                 {"Rize","Trabzon","Samsun"},
                 {"İzmir","Muğla","Manisa"},
             };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
            }
            //7 bölge 3 şehir

            Console.WriteLine();


            foreach (var v in vs)
            {
                Console.WriteLine(v);
            }
            foreach (var item in sayılar)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
