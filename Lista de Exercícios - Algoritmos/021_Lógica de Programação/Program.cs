using System;

namespace AT21_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Ano: ");
            a = int.Parse(Console.ReadLine());

            if (a % 4 == 0 & a % 100 != 0)
            {
                Console.WriteLine(a + " é um ano bissexto");
            }
            else if (a % 4 == 0 & a % 100 == 0 & a % 400 == 0) 
            {
                Console.WriteLine(a + " é um ano bissexto");
            }
            else
            {
                Console.WriteLine(a + " é um ano não bissexto");
            }
        }
    }
}
