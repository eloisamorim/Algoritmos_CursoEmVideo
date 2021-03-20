using System;

namespace AT74_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    v[i] = 5;
                }
                else
                {
                    v[i] = 3;
                }
                Console.Write("[" + v[i] + "] ");
            }
        }
    }
}
