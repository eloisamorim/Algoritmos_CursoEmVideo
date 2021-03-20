using System;

namespace AT66_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Informe um número para visualizar sua tabuada: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + n * i);
            }
        }
    }
}
