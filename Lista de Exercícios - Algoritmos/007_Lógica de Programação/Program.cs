using System;

namespace AT7_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            float n, d, t;

            Console.WriteLine("Digite um número: ");
            n = float.Parse(Console.ReadLine());

            d = n * 2;
            t = n / 3;

            Console.WriteLine("Dobro de " + n + ": " + d);
            Console.WriteLine("Terça parte de " + n + ": " + t);

        }
    }
}
