using System;

namespace AT49_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contImpar = 0, contPar = 0;

            for (int i =0; i < 6; i++)
            {
                Console.Write("Digite um número: ");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0) 
                {
                    contPar = contPar + 1;
                }
                else
                {
                    contImpar = contImpar + 1;
                }
            }
            Console.WriteLine("Total PARES: " + contPar);
            Console.WriteLine("Total ÍMPARES: " + contImpar);     
        }
    }
}
