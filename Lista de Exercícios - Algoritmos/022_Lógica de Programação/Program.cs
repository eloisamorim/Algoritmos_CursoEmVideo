using System;

namespace AT22_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, idade, anoAlist;

            Console.Write("Ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());

            idade = 2021 - ano;    

            if (idade >= 18)
            {
                anoAlist = idade - 18;
                Console.WriteLine("Há " + anoAlist + " anos de alistamento");
            }
            else
            {
                anoAlist = 18 - idade;
                Console.WriteLine("Faltam " + anoAlist + " anos para o alistamento");
            }
        }
    }
}
