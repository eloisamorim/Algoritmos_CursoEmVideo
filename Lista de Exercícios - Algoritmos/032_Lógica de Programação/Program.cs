using System;

namespace AT32_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Qual o valor sorteado entre 1 e 5? ");
            n1 = int.Parse(Console.ReadLine());

            Random random = new Random();

            n2 = random.Next(1, 5);

            if (n1 == n2)
            {
                Console.WriteLine("\nParabéns!!!  n1 = " + n1 + " e n2 = " + n2);
            }
            else
            {
                Console.WriteLine("\nErrado! TENTE NOVAMENTE! \n n1 = " + n1 + " e n2 = " + n2);
            }
        }
    }
}
