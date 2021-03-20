using System;

namespace AT42_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0;

            Console.WriteLine("Digite um número inteiro: ");
            n = int.Parse(Console.ReadLine());

            while (n > i)
            {
                i++;
                Console.Write(i + " ");
            }

            Console.Write("Acabou!\n");
        }
    }
}
