using System;

namespace AT40_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 0;

            while (n < 19)
            {
                Console.Write(n + " ");
                n = n + 3;
            }
            Console.Write("Acabou!\n");
        }
    }
}
