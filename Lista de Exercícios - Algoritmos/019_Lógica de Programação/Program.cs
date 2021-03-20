using System;

namespace AT19_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;

            Console.Write("Nota 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            n2 = double.Parse(Console.ReadLine());

            media = (n1 + n2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Média: " + Math.Round(media, 2) + "\nStatus: APROVADO! PARABÉNS!");
            }
            else
            {
                Console.WriteLine("Média: " + Math.Round(media, 2) + "\nStatus: REPROVADO");
            }
        }
    }
}
