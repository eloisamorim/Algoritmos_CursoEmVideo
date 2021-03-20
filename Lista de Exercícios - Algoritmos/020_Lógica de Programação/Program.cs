using System;

namespace AT20_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Digite um número inteiro: ");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine(n + ": Número PAR!");
            } 
            else
            {
                Console.WriteLine(n + ": Número ÍMPAR!");
            }
        }
    }
}
