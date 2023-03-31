using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número de dados: ");
            int numdados = Convert.ToInt32(Console.ReadLine());

            int somadados = 0;

            Random numrandom = new Random();

            for(int i=0; i < numdados; i++)
            {                
                somadados += numrandom.Next(1,6);
            }

            Console.WriteLine($"A soma dos dados lançados é igual a {somadados}");
        }
    }
}
