using System;

namespace AT77_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[7];

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
            }
            Console.Clear();
            for (int i = 6; i >= 0; i--)
            {
                Console.Write("[" + nome[i] + "] ");
            }
        }
    }
}
