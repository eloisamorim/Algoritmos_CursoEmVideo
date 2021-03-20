using System;

namespace AT61_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                Console.Write(n + " ");
                n = n + 3;
     
            } while (n <= 30);

            Console.Write("Acabou!");
        }
    }
}
