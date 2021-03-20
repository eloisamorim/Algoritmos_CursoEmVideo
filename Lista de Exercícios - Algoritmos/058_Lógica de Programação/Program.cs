using System;

namespace AT58_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, somaIdade = 0, media, n = 0;

            do
            {
                Console.WriteLine("Para parar digite 999");
                Console.WriteLine("Idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade != 999)
                {
                    somaIdade = somaIdade + idade;
                    n++;
                }
                Console.Clear();

            } while (idade != 999);
            
            media = somaIdade / n;
            Console.WriteLine("Média de idade da turma: " + media + " anos");
            Console.WriteLine("Quantidade de alunos: " + n);
            //Console.WriteLine(somaIdade);
        }
    }
}
