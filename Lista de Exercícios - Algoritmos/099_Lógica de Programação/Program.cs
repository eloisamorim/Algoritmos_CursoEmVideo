using System;

namespace AT99_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Base: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Expoente: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(Potencia(a, b));
        }
        static int Potencia(int c, int e)
        {
            int r = (int)Math.Pow(c, e);
            return r;
        }
    }
}
