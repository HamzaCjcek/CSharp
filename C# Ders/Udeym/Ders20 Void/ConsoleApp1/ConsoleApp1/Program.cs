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
            Mesaj msj=new Mesaj();
            msj.metin();
            

            Kisiler kisiler2=new Kisiler();
            kisiler2.kisilistesi("Mehmet");
            kisiler2.kisilistesi("Salih");
            kisiler2.kisilistesi("Yalçın");


            islem isl=new islem();
            isl.topla(1,3);
            isl.topla(2,3);
            Console.ReadLine();

        }
    }
}
