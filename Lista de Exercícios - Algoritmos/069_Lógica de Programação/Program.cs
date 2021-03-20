using System;

namespace AT69_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, r, n;

            Console.WriteLine("- PROGRESSÃO ARITMÉTICA - ");
            Console.Write("Digite o primeiro termo: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a razão da PA: ");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 1; i < 11; i++)
            {
                n = n1 + (i - 1) * r;

                Console.Write(n + " ");
            }
        }
    }
}
