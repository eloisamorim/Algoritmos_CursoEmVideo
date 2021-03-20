using System;

namespace AT88_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            
            Console.WriteLine("Qual a mensagem deseja exibir?");
            texto = Console.ReadLine();

            Console.Clear();

            gerador(texto, 4);
        }
        static void gerador(string mensagem, int n)
        {
            Console.WriteLine("+-----======-----+");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mensagem);
            }
            Console.WriteLine("+-----======-----+");
        }
    }
}
