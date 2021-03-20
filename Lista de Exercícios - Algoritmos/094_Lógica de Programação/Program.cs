using System;

namespace AT94_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Quantidade de termos que deseja visualizar: ");
            n = int.Parse(Console.ReadLine());

            Fibonacci(n);
        }

        static void Fibonacci(int n)
        {
            int a = 0, b = 1, c = 0;

            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.Write(c + " >> ");
            }
            Console.Write("FIM! \n");
        }
    }
}
