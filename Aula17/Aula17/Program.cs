using System;

namespace Aula17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;



            Console.WriteLine($"Valor mínimo do tipo int: {n1}");
            Console.WriteLine($"Valor máximo do tipo int: {n2}");
            Console.WriteLine($"Valor mínimo do tipo sbyte: {n3}");
            Console.WriteLine($"Valor máximo do tipo decimal: {n4}");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}