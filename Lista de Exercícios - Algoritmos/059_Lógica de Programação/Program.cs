using System;

namespace AT59_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, s, maiorIdade = 0, qtdM = 0, somaIdM = 0, menorIdF = 100, mediaIdM;
            string continuar;

            do
            {
                Console.WriteLine("Idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Sexo: \n [1] - M \n [2] - F");
                s = int.Parse(Console.ReadLine());
                Console.WriteLine("Continuar? [S/N]");
                continuar = Console.ReadLine();

                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }
                if (s == 1)
                {
                    qtdM++;
                    somaIdM = somaIdM + idade;
                }
                if (s == 2)
                {
                    if (idade < menorIdF)
                    {
                        menorIdF = idade;
                    }
                }
                Console.Clear();
            } while (continuar == "s" || continuar == "S");

            mediaIdM = somaIdM / qtdM;

            Console.WriteLine("Maior idade registrada: " + maiorIdade + " anos");
            Console.WriteLine("Quantidade de homens cadastrados: " + qtdM);
            Console.WriteLine("Idade da mulher mais jovem: " + menorIdF + " anos");
            Console.WriteLine("Média de idade entre os homens: " + mediaIdM + " anos");
        }
    }
}
