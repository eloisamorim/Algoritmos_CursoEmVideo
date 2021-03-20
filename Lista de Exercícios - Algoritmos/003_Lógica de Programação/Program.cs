using System;

namespace AT3_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            string funcionario;
            float salario;

            Console.WriteLine("Nome do funcionário: ");
            funcionario = Console.ReadLine();

            Console.WriteLine("Salário: ");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("O funcionário " + funcionario + " tem um salário de R$" + salario + " em Junho.");
        }
    }
}
