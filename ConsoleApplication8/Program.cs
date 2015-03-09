using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int[] a = { 1, 3, 5, 4, 7, 11 };
           

            for (int i = 0; i < 6; i++)
                Console.Write(a[i] + ", "); */

            /* string[] b = { "word", "phrase", "sentence", "text" };

            for (int i = 0; i < b.Length; i++)
                Console.WriteLine(b[i]); */

           /* string c = "tea";
            Console.WriteLine(c[2]); */

            Class1[] d = new Class1[3];

            d[0] = new Class1();

            d[0].age = 25;
            d[0].name = "Vasya";

            d[1] = new Class1();

            d[1].age = 30;
            d[1].name = "Petya";

            d[2] = new Class1();

            Console.WriteLine(d[2].name + " " + d[2].age);


        }
    }
}
