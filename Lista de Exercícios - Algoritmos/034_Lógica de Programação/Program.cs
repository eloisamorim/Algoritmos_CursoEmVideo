using System;

namespace AT34_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            float diaria, total, distancia;
            int tempo, tipo;

            Console.WriteLine("Informe o tipo de carro: \n [1] - Carro popular \n [2] - Carro de luxo");
            tipo = int.Parse(Console.ReadLine());
            Console.WriteLine("Tempo de aluguel em dias: ");
            tempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Distância total percorrida em Km: ");
            distancia = float.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                if (distancia < 100)
                {
                    total = (float)((90 * tempo) + (0.2 * distancia));
                }
                else
                {
                    total = (float)((90 * tempo) + (0.1 * distancia));
                }
                Console.WriteLine("Total a pagar: R$" + Math.Round(total, 2));
            }
            else if (tipo == 2)
            {
                if (distancia < 200)
                {
                    total = (float)((150 * tempo) + (0.3 * distancia));
                }
                else
                {
                    total = (float)((150 * tempo) + (0.25 * distancia));
                }
                Console.WriteLine("Total a pagar: R$" + Math.Round(total, 2));
            }
            else
            {
                Console.WriteLine("Digite uma entrada válida!");
            }               
        }
    }
}