using System;

namespace AT27_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;

            Console.Write("1ª nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("2ª nota: ");
            n2 = double.Parse(Console.ReadLine());

            media = (n1 + n2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Média: " + media + " = APROVADO!");
            }
            else if (media >= 5 && media < 7)
            {
                Console.WriteLine("Média: " + media + " = EM RECUPERAÇÃO!");
            }
            else
            {
                Console.WriteLine("Média: " + media + " = REPROVADO!");
            }
        }
    }
}
