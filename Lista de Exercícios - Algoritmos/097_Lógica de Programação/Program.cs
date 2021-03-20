using System;

namespace AT97_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.Write("1º número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("2º número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("3º número: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Maior número dgitado: " + Maior(n1, n2, n3));
        }
        static int Maior(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
