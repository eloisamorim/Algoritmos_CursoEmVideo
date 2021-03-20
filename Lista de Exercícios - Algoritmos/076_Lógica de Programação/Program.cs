using System;

namespace AT76_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sorteia = new Random();

            int[] v = new int[6];

            for (int i = 0; i < 6; i++)
            {
                v[i] = sorteia.Next(1, 100);

                Console.Write("[" + v[i] + "] ");
            }                    
        }
    }
}
