using System;

namespace AT25_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            if (a < (b + c) && b < (a + c) && c < (b + a))
            {
                Console.WriteLine("Possível para formar um triângulo.");
            }
            else
            {
                Console.WriteLine("Não possível para formar um triângulo.");
            }
        }
    }
}
