using System;

namespace AT33_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorTotal, salario, parcela;
            int anos;

            Console.Write("Informe o valor do imóvel: R$");
            valorTotal = float.Parse(Console.ReadLine());

            Console.Write("Digite seu salário mensal: R$");
            salario = float.Parse(Console.ReadLine());

            Console.Write("Tempo em anos a pagar: ");
            anos = int.Parse(Console.ReadLine());

            parcela = valorTotal / (anos * 12);

            if (parcela >= 0.3 * salario)
            {
                Console.WriteLine("\n    'Empréstimo negado!' \n    Parcela mensal R$" + Math.Round(parcela,2) + " excede 30% da renda mensal");
            }
            else
            {
                Console.WriteLine("\n    'Empréstimo aprovado!' \n    Parcela mensal R$" + Math.Round(parcela, 2));
            }
        }
    }
}
