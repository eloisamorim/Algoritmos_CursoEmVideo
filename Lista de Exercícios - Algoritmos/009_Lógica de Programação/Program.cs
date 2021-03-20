using System;

namespace AT9_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            double real, dolar;

            Console.WriteLine("Quanto você tem?");
            real = double.Parse(Console.ReadLine());

            dolar = real / 5.46;      // Dolar hoje (31/01/2021) 

            Console.WriteLine("R$" + real + " equivale a US$" + Math.Round(dolar,2));
                       
        }
    }
}
