using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        char genero = 'F';
        int idade = 32;
        double saldo = 10.35784;
        string nome = "Maria";


        Console.Write("Bom dia!"); // Write() não quebra a linha, então a próxima mensagem aparecerá na mesma linha
        Console.WriteLine("Boa tarde!");
        Console.WriteLine("Boa noite!"); // WriteLine() quebra a linha, então a próxima mensagem aparecerá na linha seguinte
        Console.WriteLine("----------------------");
        Console.WriteLine(genero);
        Console.WriteLine(idade);
        Console.WriteLine(saldo);
        Console.WriteLine(nome);
        Console.WriteLine(saldo.ToString("F2"));
        Console.WriteLine(saldo.ToString("F4"));
        Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
        //O ToString("F2", CultureInfo.InvariantCulture) é para formatar o número com 2 casas decimais e usar o ponto como separador decimal, independente da cultura do sistema.
        
        Console.ReadKey();
    }
}