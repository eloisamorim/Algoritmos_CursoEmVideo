using System;

namespace AT91_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite um valor para n1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para n2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            maior(n1, n2);
        }
        static void maior(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a + " maior que " + b);
            }
            else if (a < b)
            {
                Console.WriteLine(a + " menor que " + b);
            }
            else
            {
                Console.WriteLine("Valores iguais");
            }
        }
    }
}
