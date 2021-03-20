using System;

namespace AT79_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Posição " + i + ": ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n-  Números pares do vetor  -");

            for (int i = 0; i < 10; i++)
            {
                if (v[i] % 2 == 0)
                {
                    Console.WriteLine("[" + v[i] + "] Na posição " + i);
                }
            }
        }
    }
}
