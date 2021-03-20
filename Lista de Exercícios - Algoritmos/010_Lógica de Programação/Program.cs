using System;

namespace AT10_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            float largura, altura, area, volumeTotal;

            Console.WriteLine("Altura da parede: ");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Largura da parede: ");
            largura = float.Parse(Console.ReadLine());

            area = largura * altura;
            volumeTotal = area / 2;

            Console.WriteLine("Você precisará de " + Math.Round(volumeTotal,2) + "l de tinta");

        }
    }
}
