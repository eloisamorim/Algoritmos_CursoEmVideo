using System;

namespace AT78_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[15];

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Digite um número: ");
                v[i] = int.Parse(Console.ReadLine());
            } 

            Console.Clear();

            for (int i = 0; i < 15; i++)
            {
                Console.Write("[" + v[i] + "] ");
            }

            Console.WriteLine("\nPosições dos números múltiplos de 10: ");
            for (int i = 0; i < 15; i++)
            {
                if (v[i] % 10 == 0)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
