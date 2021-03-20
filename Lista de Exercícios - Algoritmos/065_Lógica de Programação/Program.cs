using System;

namespace AT65_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 0; i = i - 10)
            {
                Console.Write(i + " ");
            }
            Console.Write("Acabou!");
        }
    }
}
