using System;

namespace AT15_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias;
            double salario;

            Console.WriteLine("Quantidade de dias trabalhados:");
            dias = int.Parse(Console.ReadLine());

            salario = dias * 8 * 25;

            Console.WriteLine("TOTAL A RECEBER: R$" + salario);
        }
    }
}
