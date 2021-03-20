using System;

namespace AT100_Lógica_de_Programação
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

            float media = Media(nota1, nota2);

            Console.WriteLine("Média: " + media + "   Status: " + Situacao(media));
        }

        static float Media(float n1, float n2)
        {
            float m = (n1 + n2) / 2;
            return m;
        }
       
        static string Situacao(float med)
        {
            if (med >= 7)
            {
                return "APROVADO";
            }
            else if (med < 5)
            {
                return "REPROVADO!";
            }
            else
            {
                return "EM RECUPERAÇÃO";
            }
        }
    }
}
