using System;

namespace AT52_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, idade, maior = 0, mais18 = 0, menos5 = 0, soma = 0, media;

            while (i <= 10)
            {
                Console.Write("Idade " + i + ": ");
                idade = int.Parse(Console.ReadLine());

                soma = soma + idade;

                if (idade > maior)
                {
                    maior = idade;
                }
                if (idade > 18)
                {
                    mais18++;
                }
                if (idade < 5)
                {
                    menos5++;
                }
                i++;
            }
            media = soma / 10;
            Console.WriteLine("- Média de idade do grupo: " + media + " anos");
            Console.WriteLine("- Pessoas maiores de 18 anos: " + mais18);
            Console.WriteLine("- Pessoas menores de 5 anos: " + menos5);
            Console.WriteLine("- Maior idade: " + maior + " anos");
        }
    }
}
