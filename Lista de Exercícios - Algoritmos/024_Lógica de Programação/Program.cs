using System;

namespace AT24_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia, valor;

            Console.Write("Distância a percorrer em Km: ");
            distancia = double.Parse(Console.ReadLine());
           
            if (distancia < 200)
            {
                valor = distancia * 0.5;
            }
            else
            {
                valor = distancia * 0.45;
            }

            Console.WriteLine("Distância: " + distancia + "Km \nValor a pagar = R$" + Math.Round(valor, 2));

        }
    }
}
