using System;

namespace AT90_Lógica_de_Programação
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

            soma(n1, n2);
        }
        static void soma(int a, int b)
        {
            Console.WriteLine("Total = " + (a + b));
        }
    }
}
