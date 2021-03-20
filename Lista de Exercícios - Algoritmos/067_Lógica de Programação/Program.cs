using System;

namespace AT67_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um valor: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.Write("Fim!");
        }
    }
}
