using System;

namespace AT80_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sorteia = new Random();

            int[] v = new int[30];
            int contChave = 0;

            for (int i = 0; i < 30; i++)
            {
                v[i] = sorteia.Next(1, 16);
                Console.Write("[" + v[i] + "] ");          //Conferir posições e números gerados.
            }

            Console.WriteLine("\nDigite uma chave: ");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("\nChave " + key + " encontrada nas posições: ");

            for (int i = 0; i < 30; i++)
            {
                if (key == v[i])
                {
                    contChave++;
                    Console.WriteLine(i + " ");
                }
            }
            Console.WriteLine("Sorteada " + contChave + " vezes.");
        }
    }
}
