using System;

namespace AT17_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocidade, multa;

            Console.Write("Velocidade: ");
            velocidade = double.Parse(Console.ReadLine());

            if (velocidade > 80)
            {
                multa = (velocidade - 80) * 5;
                Console.WriteLine("Você ultrapassou o limite permitido na via! Multa = R$" + multa);
            } else
            {
                Console.WriteLine("Velocidade permitida na via!");
            }
        }
    }
}
