using System;

namespace AT38_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = 5;

            while(n < 11)
            {
                n++;
                Console.Write(n + " ");
            }
            Console.Write("Acabou!\n");
        }
    }
}
