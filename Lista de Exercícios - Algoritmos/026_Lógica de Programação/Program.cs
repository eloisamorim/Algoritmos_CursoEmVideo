using System;

namespace AT26_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Digite um valor inteiro: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número número inteiro: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O primeiro valor é maior!");
            }
            if (n1 < n2)
            {
                Console.WriteLine("O segundo valor é o maior!");
            }
            else
            {
                Console.WriteLine("Não existe valor maior, os dois são iguais!");
            }



        }
    }
}
