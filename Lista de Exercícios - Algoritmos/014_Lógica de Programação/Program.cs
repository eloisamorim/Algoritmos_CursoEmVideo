using System;

namespace AT14_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo;
            double distancia, precoTotal;

            Console.WriteLine("Tempo em dias: ");
            tempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Distância percorrida: ");
            distancia = double.Parse(Console.ReadLine());

            precoTotal = (tempo * 90) + (distancia * 0.2);

            Console.WriteLine("Total a pagar = R$" + precoTotal);

        }
    }
}
