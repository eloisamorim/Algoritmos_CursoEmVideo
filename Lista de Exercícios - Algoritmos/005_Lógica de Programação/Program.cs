using System;

namespace AT5_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, media;

            Console.WriteLine("Nota 1: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            nota2 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.WriteLine("A média entre " + nota1 + " e " + nota2 + " é igual a " + media);
        }
    }
}
