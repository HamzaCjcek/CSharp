using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            

            int sum1 = 100 + 50;     // 150 (100 + 50)
            int sum2 = sum1 + 250;   // 400 (150 + 250)
            int sum3 = sum2 + sum2;  // 800 (400 + 400)
            int sum4 = -100;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            Console.WriteLine(Math.Min(sum1,sum2));
            Console.WriteLine(Math.Max(sum1,sum2));
            Console.WriteLine(Math.Abs(sum4));
            Console.WriteLine(Math.Sqrt(sum2));
            

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);
            

            string txt2 = "Hello World";
            Console.WriteLine(txt2.ToUpper()); 
            Console.WriteLine(txt2.ToLower());
            

            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);
            

            string firstName2 = "John ";
            string lastName2 = "Doe";
            string name2 = string.Concat(firstName2, lastName2);
            Console.WriteLine(name);
            

            string firstName3 = "John";
            string lastName3 = "Doe";
            string name3 = $"My full name is: {firstName3} {lastName3}";
            Console.WriteLine(name);
            

            string kelime = "Dabbe", kelime2 = "Dabbe2", kelime3 = "Dabbe3", kelime4 = "Dabbe4";

            Console.Write(kelime);
            Console.Write(kelime2);
            Console.WriteLine(kelime3);
            Console.WriteLine(kelime4);




            string name4 = "John Doe";

            // Location of the letter D
            int charPos = name4.IndexOf("D");

            // Get last name
            string lastName4 = name4.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName4);

                                                                   //
            string txt3 = "Hello\nWorld!";
            Console.WriteLine(txt3);

            string txt4 = "Hello\tWorld!";
            Console.WriteLine(txt4);

            string txt5 = "Hel\blo World!";
            Console.WriteLine(txt5);

            Console.ReadLine();

        }
    }
}
