using System;

namespace AT18_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int nascimento, idade;
            bool v;

            Console.Write("Ano de nascimento: ");
            nascimento = int.Parse(Console.ReadLine());

            idade = 2021 - nascimento;

            if (idade >= 16)
            {
                v = true;
                Console.WriteLine("Idade: " + idade + "\nVota? " + v);
            } 
            else
            {
                v = false;
                Console.WriteLine("Idade: " + idade + "\nVota? " + v);
            }

        }
    }
}
