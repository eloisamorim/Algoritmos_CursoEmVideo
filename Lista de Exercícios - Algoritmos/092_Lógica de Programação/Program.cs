using System;

namespace AT92_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Digite um valor: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            parOuImpar(n);
        }
        static void parOuImpar(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " é um número PAR!");
            }
            else
            {
                Console.WriteLine(n + " é um número ÍMPAR!");
            }
        }
    }
}
