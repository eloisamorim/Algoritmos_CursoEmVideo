using System;

namespace AT4_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Digite o valor de n1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de n2: ");
            n2 = int.Parse(Console.ReadLine());

            n3 = n1 + n2;

            Console.WriteLine(n1 + " + " + n2 + " = " + n3);
        }
    }
}
