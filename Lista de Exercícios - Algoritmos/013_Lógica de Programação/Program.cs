using System;

namespace AT13_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario;

            Console.WriteLine("Digite o salário atual: ");
            salario = double.Parse(Console.ReadLine());

            novoSalario = 1.15 * salario;

            Console.WriteLine("Novo salário com aumento de 15%: R$" + Math.Round(novoSalario,2));
        }
    }
}
