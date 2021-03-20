using System;

namespace AT12_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, desconto, precoFinal;

            Console.WriteLine("Informe o valor do produto:");
            preco = double.Parse(Console.ReadLine());

            desconto = preco * 0.05;
            precoFinal = preco - desconto;

            Console.WriteLine("Valor do produto: R$" + preco);
            Console.WriteLine("VALOR PROMOCIONAL : R$" + precoFinal);
        }
    }
}
