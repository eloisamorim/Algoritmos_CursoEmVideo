using System;

namespace AT41_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 100;

            while (n >= 0)
            {
                Console.WriteLine(n);
                n = n - 5;
            }
            Console.Write("Acabou!\n");
        }
    }
}
