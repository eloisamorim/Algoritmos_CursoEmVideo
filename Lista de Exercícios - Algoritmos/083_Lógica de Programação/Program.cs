using System;

namespace AT83_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sorteia = new Random();

            int[] v = new int[20];
            int auxiliar = 0;

            for (int i = 0; i < 20; i++)
            {
                v[i] = sorteia.Next(0, 100);
                Console.Write("[" + v[i] + "] ");
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (v[i] < v[j]) 
                    {
                        auxiliar = v[i];
                        v[i] = v[j];
                        v[j] = auxiliar;
                    }   
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("[" + v[i] + "] ");
            }
        }
    }
}
