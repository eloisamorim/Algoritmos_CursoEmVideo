using System;

namespace AT72_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];

            for (int i = 0; i < 10; i++)
            {
                v[i] = i * 5 + 5;

                Console.Write("[" + v[i] + "] ");
            }
        }
    }
}
