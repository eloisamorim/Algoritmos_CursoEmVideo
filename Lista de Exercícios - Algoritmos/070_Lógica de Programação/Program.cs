using System;

namespace AT70_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;

            for (int i = 0; i < 11; i++)
            {
                a = b;
                b = c;
                c = a + b;

                Console.Write(c + " ");
            }
        }
    }
}
