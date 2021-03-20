using System;

namespace Passo_5___Faça_Enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma = 0;

            do
            {
                Console.WriteLine("Para parar digite 1111");
                Console.WriteLine("Digite um número: ");
                n = int.Parse(Console.ReadLine());

                if (n != 1111)
                {
                    soma = soma + n;
                }
                Console.Clear();
            } while (n != 1111);

            Console.WriteLine("Soma total: " + soma);
        }
    }
}
