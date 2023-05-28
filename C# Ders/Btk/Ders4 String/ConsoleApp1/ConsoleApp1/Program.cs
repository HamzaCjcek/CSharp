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
            string sentence = "My name is Engin Demiroğ";//Boşluklarla beraber
            var result2=sentence.Clone();
            var result = sentence.Length;
            bool result3=sentence.EndsWith("ğ");//sentence ğ ile bitiyor mu
            var result4=sentence.IndexOf("is");//aramaya önden başlar
            var result5 = sentence.LastIndexOf("is");//tersten başlar ama cümlenin başından sayar
            var result6 = sentence.Insert(0, "Hello ,");//Cümlenin 0ıncı yerine hello ekle
            var result7 = sentence.Substring(3,4);//Kesmek demek 3 üncü karakterden itibaren
            var result8 = sentence.Replace(" ", "-");//Değiştirmek
            var result9 = sentence.Remove(2,5);//2 den sonrasını sil //2 den sonra 5 karakter
            Console.WriteLine(result9);
            Console.ReadLine();
        }
        
    }
}
