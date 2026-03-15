using System;

namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 10;

            Console.WriteLine(a);

            a +=2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);


            string s = "ABC";
            Console.WriteLine(s);
            // o operador += é utilizado para concatenar strings
            s += "DEF"; 
            Console.WriteLine(s);
            */
            int a = 10;
            int b = ++a;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}