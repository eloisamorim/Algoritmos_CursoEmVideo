using System;

namespace AT84_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idade = new int[9];
            string[] nome = new string[9];

            for (int i = 0; i < 9; i++)
            {
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            Console.Clear();
            Console.WriteLine("Listagem menores de idade: ");
            for (int i = 0; i < 9; i++)
            {
                if (idade[i] < 18)
                {
                    Console.WriteLine("Nome: " + nome[i] + "\nIdade: " + idade[i] + " anos");
                    Console.WriteLine("");
                }
            }
        }
    }
}
