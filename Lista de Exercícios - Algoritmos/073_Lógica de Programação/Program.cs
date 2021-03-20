using System;

namespace AT73_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];

            for (int i = 9; i >= 0; i--)
            {
                v[i] = i;
                Console.Write("[" + v[i] + "] ");
            }
        }
    }
}
