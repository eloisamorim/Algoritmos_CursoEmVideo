using System;

namespace AT23_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            char sexo;
            double valor, desconto, valorTotal;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Sexo [F/M]: ");
            sexo = char.Parse(Console.ReadLine());
            Console.Write("Valor da compra: R$");
            valor = double.Parse(Console.ReadLine());

            
            if (sexo == 'F' || sexo == 'f')
            {
                desconto = valor * 0.13;
                valorTotal = valor - desconto;
                Console.WriteLine("Nome: " + nome + "\nValor a pagar: R$" + valorTotal);
            }
            if (sexo == 'M' || sexo == 'm')
            {
                desconto = valor * 0.05;
                valorTotal = valor - desconto;
                Console.WriteLine("Nome: " + nome + "\nValor a pagar: R$" + valorTotal);
            }
        }
    }
}
