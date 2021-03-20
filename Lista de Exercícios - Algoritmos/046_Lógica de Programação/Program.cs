using System;

namespace AT46_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
         {
            int n = 4, soma = 0;

            while (n < 100)
            {
                n = n + 2;
                Console.Write(n);             
                if (n < 100)
                {
                    Console.Write(" + ");
                }
                soma = soma + n;
            }
            Console.WriteLine("\nSoma dos números pares = " + soma);
        }
    }
}
