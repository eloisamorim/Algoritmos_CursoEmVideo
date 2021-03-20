using System;

namespace AT6_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ant, suc;

            Console.WriteLine("Informe um número: ");
            n = int.Parse(Console.ReadLine());

            ant = n - 1;
            suc = n + 1;

            Console.WriteLine("Antecessor de " + n + ": " + ant);
            Console.WriteLine("Sucessor de " + n + ": " + suc);
        }
    }
}
