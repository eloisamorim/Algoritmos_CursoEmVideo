using System;

namespace AT98_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Último número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            for (int i = n1; i <= n2; i++)
            {
                Console.Write(i);
                if (i < n2)
                {
                    Console.Write(" + ");
                }
            }
            Console.Write(" = " + SuperSomador(n1, n2) + "\n");
        }
        static int SuperSomador(int a, int b)
        {
            int soma = 0;
            for (int i = a; i <= b; i++)
            {
                soma = soma + i;
            }
            return soma;
        }
    }
}
