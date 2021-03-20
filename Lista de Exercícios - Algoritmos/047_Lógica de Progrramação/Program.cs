using System;

namespace AT47_Lógica_de_Progrramação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 550, soma = 0;

            while (n > 0)
            {
                n = n - 50;
                Console.Write(n);

                if (n > 0)
                {
                    Console.Write(" + ");
                }
                soma = soma + n;
            }
            Console.WriteLine("\nSoma total = " + soma + "\n");
        }
    }
}
