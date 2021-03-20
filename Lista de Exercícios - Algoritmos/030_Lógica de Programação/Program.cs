using System;

namespace AT30_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string tipo;

            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            if (a < (b + c) && b < (a + c) && c < (b + a))
            {
                if (a == b && b == c)
                {
                    tipo = "Equilátero";
                }
                else if (a == b && b != c)
                {
                    tipo = "Isósceles";
                }
                else
                {
                    tipo = "Escaleno";
                }
                Console.WriteLine("Possível para formar um triângulo. Classificação: " + tipo);
            }
            else
            {
                Console.WriteLine("Não possível para formar um triângulo.");
            }
        }
    }
}
