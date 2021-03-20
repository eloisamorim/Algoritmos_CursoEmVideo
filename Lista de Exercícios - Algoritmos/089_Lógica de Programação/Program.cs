using System;

namespace AT89_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string texto, borda = "";

            Console.WriteLine("-  Escolha o tipo de borda:");
            Console.WriteLine("[1] +-------========-------+");
            Console.WriteLine("[2] ~~~~~~~~::::::::~~~~~~~~");
            Console.WriteLine("[3] <<<---->>>----<<<---->>>");
            a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                borda = "+-------========-------+";
            }
            if (a == 2)
            {
                borda = "~~~~~~~~::::::::~~~~~~~~";
            }
            if (a == 3)
            {
                borda = "<<<---->>>----<<<---->>>";
            }

            Console.WriteLine("\nQual a mensagem deseja exibir?");
            texto = Console.ReadLine();

            Console.Clear();

            gerador(texto, borda);
        }
        static void gerador(string texto, string borda)
        {
            Console.WriteLine(borda);
            Console.WriteLine(texto);
            Console.WriteLine(borda);
        }
    }
}
