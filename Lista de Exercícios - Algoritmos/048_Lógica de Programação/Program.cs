using System;

namespace AT48_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma = 0; //, n1, n2, n3, n4, n5, n6, n7;

            for (int i = 0; i < 7; i++ )
            {
                Console.Write("Digite um número inteiro: ");
                n = int.Parse(Console.ReadLine());

                soma = soma + n;
            }
            Console.WriteLine("Soma total: " + soma);
        }
    }
}
