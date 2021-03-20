using System;

namespace AT53_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, sexo, idade, qtdHomens = 0, qtdMulheres = 0, soma = 0, mediaTotal, mediaHomens, idadeHomens = 0, mais20M = 0;

            while (i <= 5)
            {
                Console.WriteLine("--- Pessoa " + i + " ---");
                Console.WriteLine("Sexo: \n[1] - Feminino \n[2] - Masculino ");
                sexo = int.Parse(Console.ReadLine());
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                soma = soma + idade;

                switch (sexo)
                {
                    case 1:
                        qtdMulheres++;
                        if (idade > 20)
                        {
                            mais20M++;
                        }
                        break;
                    case 2:
                        idadeHomens = idadeHomens + idade;
                        qtdHomens++;
                       // mediaHomens = idadeHomens / qtdHomens;
                        break;
                    default:
                        Console.WriteLine("Digite [1] - Feminino ou [2] - Masculino e tente novamente! \n");
                        break;
                }
                i++;
            }
            mediaTotal = soma / 5;
            mediaHomens = idadeHomens / qtdHomens;

            Console.WriteLine("Quantidade de homens cadastrados: " + qtdHomens);
            Console.WriteLine("Quantidade de mulheres cadastradas: " + qtdMulheres);
            Console.WriteLine("Média de idade do grupo: " + mediaTotal + " anos");
            Console.WriteLine("Média de idade dos homens: " + mediaHomens + " anos");
            Console.WriteLine("Quantidade de mulheres maiores de 20 anos: " + mais20M);
        }
    }
}
