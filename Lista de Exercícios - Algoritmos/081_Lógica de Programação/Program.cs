 using System;

namespace AT81_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idade = new int[8];
            int somaIdade = 0, mediaIdade, maiorIdade = 0;

            for (int i = 0; i < 8; i++)
            {
                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());

                somaIdade = somaIdade + idade[i];
            }

            mediaIdade = somaIdade / 8;
            Console.WriteLine("Média idades: " + mediaIdade);

            Console.Write("Posição com idades maiores que 25 anos: ");
            for (int i = 0; i < 8; i++)       // Verificando as posições maiores que 25 anos.
            {
                if (idade[i] > 25)
                {
                    Console.Write(i + " ");
                }
                if (idade[i] > maiorIdade)    //verificando a maior idade
                {
                    maiorIdade = idade[i];
                }
            }
            Console.WriteLine("\nMaior idade digitada: " + maiorIdade);

            Console.Write("Posição com a maior idade: ");  
            for (int i = 0; i < 8; i++)
            {
                if (idade[i] == maiorIdade)    // Verificando as posições com a maior idade
                {
                    Console.Write(i + " ");
                }
            }            
        }
    }
}