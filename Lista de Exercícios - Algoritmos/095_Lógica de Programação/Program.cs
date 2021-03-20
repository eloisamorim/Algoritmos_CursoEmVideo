using System;

namespace Passo_10___Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite o 1º valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º valor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Total = " + Somador(n1, n2));           
        }
        static int Somador(int a, int b)
        {
            int c;
            c = a + b;

            return c;
        }
    }
}
