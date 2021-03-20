using System;

namespace AT85_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("- CADASTRO DE FUNCIONÁRIOS - ");
            Console.Write("Quantidade de funcionários: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            string[] nome = new string[n];
            float[] salario = new float[n];
            string[] genero = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("CADASTRO FUNCIONÁRIO " + (i + 1));
                Console.WriteLine("-----------------------");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Gênero [M/F]: ");
                genero[i] = Console.ReadLine();
                Console.Write("Salário: R$");
                salario[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                if ((genero[i] == "f" || genero[i] == "F") && salario[i] >= 5000)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine(" ~ " + nome[i] + " - R$" + salario[i]);
                }
            }
            Console.WriteLine("-----------------------");
        }
    }
}
