using System;

namespace AT96_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2;

            Console.Write("Nota 1: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Média: " + Math.Round(Media(nota1, nota2),2));
        }
        static float Media(float a, float b)
        {
            float c;
            c = (a + b) / 2;
            return c;
        }
    }
}
