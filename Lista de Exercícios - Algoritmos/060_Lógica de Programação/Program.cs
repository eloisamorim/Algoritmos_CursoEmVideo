using System;

namespace AT60_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, continuar, nomeMaisVelho = "", nomeMulherJovem = "";
            int idade, media, sexo, contadorPessoas = 0;
            int pessoaMaisVelha = 0, mulherMaisJovem = 100, somaIdade = 0, homemMais30 = 0, mulherMenos18 = 0;

            do
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Sexo [1 - F / 2 - M]: ");
                sexo = int.Parse(Console.ReadLine());
                Console.WriteLine("Deseja continuar? [S/N]");
                continuar = Console.ReadLine();

                somaIdade = somaIdade + idade;
                contadorPessoas++;

                if (idade > pessoaMaisVelha)
                {
                    pessoaMaisVelha = idade;
                    nomeMaisVelho = nome; 
                }
                if (sexo == 1 && idade < mulherMaisJovem)
                {
                    mulherMaisJovem = idade;
                    nomeMulherJovem = nome;
                }
                if (sexo == 2 && idade > 30)
                {
                    homemMais30++;
                }
                if (sexo == 1 && idade < 18)
                {
                    mulherMenos18++;
                }
            } while (continuar == "s" || continuar == "S");

            media = somaIdade / contadorPessoas;

            Console.WriteLine("Pessoa mais velha: " + nomeMaisVelho);
            Console.WriteLine("Mulher mais jovem: " + nomeMulherJovem);
            Console.WriteLine("Média de idade do grupo: " + media);
            Console.WriteLine("Quantidade de homens com mais de 30 anos: " + homemMais30);
            Console.WriteLine("Quantidade de mulheres com menos de 18 anos: " + mulherMenos18);
        }
    }
}
