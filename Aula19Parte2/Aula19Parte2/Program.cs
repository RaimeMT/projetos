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

        Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //Formatação composte e Formata F2 é para formatar o número com 2 casas decimais

        Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //Interpolação de string forma mais recomendada para formatação de string

        Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); 
        //Concatenação de string forma mais antiga e menos recomendada para formatação de string, além de ser mais verbosa e menos legível. O ToString("F2", CultureInfo.InvariantCulture) é para formatar o número com 2 casas decimais e usar o ponto como separador decimal, independente da cultura do sistema.
        Console.ReadKey();
    }
}