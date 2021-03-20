using System;

namespace AT62_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, contadorPessoas = 0, mais21 = 0, somaIdade = 0, media;
            string continuar;

            do
            {
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Deseja continuar? [S/N] ");
                continuar = Console.ReadLine();

                contadorPessoas++;
                somaIdade = somaIdade + idade;

                if (idade >= 21)
                {
                    mais21++;
                }

            } while (continuar == "s" || continuar == "S");

            media = somaIdade / contadorPessoas;

            Console.WriteLine("Quantidade de idades informadas: " + contadorPessoas);
            Console.WriteLine("Média entre as idades informadas: " + media);
            Console.WriteLine("Quantidade de pessoas com 21 anos ou mais: " + mais21);
        }
    }
}
