using System;

namespace AT11_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            double delta, potencia;

            Console.WriteLine("Digite o valor de A:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            c = float.Parse(Console.ReadLine());

            potencia = Math.Pow(b, 2.0);
            delta = potencia - (4 * a * c);

            Console.WriteLine("D = " + delta);

        }
    }
}
