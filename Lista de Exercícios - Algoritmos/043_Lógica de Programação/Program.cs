using System;

namespace AT43_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 31;

            while (n > 1)
            {
                n--;
                Console.Write(n + " ");

                if (n % 4 == 0)
                {
                    Console.Write("[" + n + "] ");
                }
            }
        }
    }
}
