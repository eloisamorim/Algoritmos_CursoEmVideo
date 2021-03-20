using System;

namespace AT50_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();

            int i = 0, a = 0, b = 0;

            Console.Write("Números sorteados: [ ");
            while (i <= 20)
            {
                int n = numAleatorio.Next(1, 11);
                Console.Write(n + " ");

                if (n > 5)
                {
                    a++;
                }
                if (n % 3 == 0)
                {
                    b++;
                }
                i++;
            }
            Console.Write("]");
            Console.WriteLine("\nQuantidade de números acima de 5: " + a);
            Console.WriteLine("Quantidade de números divisíveis por 3: " + b);
        }
    }
}
