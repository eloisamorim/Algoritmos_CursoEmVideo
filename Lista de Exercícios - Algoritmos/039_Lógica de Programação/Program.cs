using System;

namespace AT39_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = 11;

            while (n > 3)
            {
                n--;
                Console.Write(n + " ");
            }
            Console.Write("Acabou!\n");                
        }
    }
}
