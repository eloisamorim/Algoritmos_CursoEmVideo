using System;

namespace AT44_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, inc;

            Console.Write("Digite o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o último valor: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o incremento: ");
            inc = int.Parse(Console.ReadLine());

            while (n2 > n1)
            {
                Console.Write(n1 + " ");
                n1 = n1 + inc;
            }
            Console.Write("Acabou! \n");
        }
    }
}
