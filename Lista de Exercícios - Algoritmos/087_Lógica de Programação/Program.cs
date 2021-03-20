using System;

namespace AT8
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagem;
            Console.WriteLine("Qual a mensagem deseja exibir?");
            mensagem = Console.ReadLine();

            Console.Clear();

            gerador(mensagem);
        }

        static void gerador(string mensagem)
        {
            Console.WriteLine("+-----======-----+");
            Console.WriteLine(mensagem);
            Console.WriteLine("+-----======-----+");
        }
    }
}
