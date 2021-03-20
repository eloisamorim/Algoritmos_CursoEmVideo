using System;

namespace AT28_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, area;
            string classificacao;

            Console.Write("Largura do terreno: ");
            largura = double.Parse(Console.ReadLine());
            Console.Write("Comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine());

            area = largura * comprimento;

            if (area < 100)
            {
                classificacao = "TERRENO POPULAR";
            }
            else if (area >= 500)
            {
                classificacao = "TERRENO VIP";
            }
            else
            {
                classificacao = "TERRENO MASTER";
            }

            Console.WriteLine("Área total: " + area + "m² = " + classificacao);
        }
    }
}
