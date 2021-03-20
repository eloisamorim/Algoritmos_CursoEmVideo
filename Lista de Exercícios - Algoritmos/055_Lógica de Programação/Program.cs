using System;

namespace AT55_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();

            int i = 1;
            int n = numAleatorio.Next(1, 11);

            Console.WriteLine("Qual o número sorteado? ");
            int s = int.Parse(Console.ReadLine());

            if (n == s)
            {
                Console.WriteLine("Parabéns! Você acertou");
            }
            else
            {
                while (i < 4)
                {
                    Console.WriteLine("Você errou! Tente novamente");
                    Console.WriteLine("Qual o número sorteado? ");
                    s = int.Parse(Console.ReadLine());

                    if (n == s)
                    {
                        Console.WriteLine("Parabéns! Você acertou");
                        break;
                    }
                    if (i == 3 && n != s)
                    {
                        Console.WriteLine("Opss... Você perdeu o jogo!");
                        Console.WriteLine("O número sorteado foi " + n);
                    }
                    i++;
                }
            }
        }
    }
}
