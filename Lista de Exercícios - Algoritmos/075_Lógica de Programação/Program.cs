using System;

namespace AT75_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[16];

            for (int i = 0; i < 16; i++)
            {
                v[0] = 1;
                v[1] = 1;

                if (i > 1)
                {
                    v[i] = v[i - 2] + v[i - 1];
                }
                Console.Write("[" + v[i] + "] ");
            }
        }
    }
}
