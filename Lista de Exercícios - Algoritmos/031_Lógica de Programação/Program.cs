using System;

namespace AT31_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int j1, j2;

            Console.Write("- Jogador 1 - \n [1] Pedra \n [2] Papel \n [3]Tesoura\n");
            j1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("- Jogador 2 - \n [1] Pedra \n [2] Papel \n [3]Tesoura\n");
            j2 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("[1] Pedra    [2] Papel     [3]Tesoura\n");
            Console.WriteLine("Jogador 1: [" + j1 + "]\nJogador 2: [" + j2 + "]\n");

            if (j1 == j2)
            {
                Console.WriteLine("EMPATE!!");
            }
            else
            {
                if ((j1 == 2 && j2 == 1) || (j1 == 1 && j2 == 2))
                {
                    if (j1 == 2)
                    {
                        Console.WriteLine("VENCEDOR: Jogador 1!");
                    }
                    else
                    {
                        Console.WriteLine("VENCEDOR: Jogador 2!");
                    }
                }
                if ((j1 == 1 && j2 == 3) || (j1 == 3 && j2 == 1))
                {
                    if (j1 == 1)
                    {
                        Console.WriteLine("VENCEDOR: Jogador 1!");
                    }
                    else
                    {
                        Console.WriteLine("VENCEDOR: Jogador 2!");
                    }
                }
                if ((j1 == 2 && j2 == 3) || (j1 == 3 && j2 == 2))
                {
                    if (j1 == 3)
                    {
                        Console.WriteLine("VENCEDOR: Jogador 1!");
                    }
                    else
                    {
                        Console.WriteLine("VENCEDOR: Jogador 2!");
                    }
                }
                else
                {
                    Console.WriteLine("ERRO! Inicie para jogar");
                }
            }
        }
    }
}
