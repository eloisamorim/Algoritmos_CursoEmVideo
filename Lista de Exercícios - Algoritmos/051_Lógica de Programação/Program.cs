using System;

namespace AT51_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            float preco, maior = 0, menor = 110; 
            // Utilizado um número grande na variável menor para comparar o preço e receber o menor valor.
            int n = 1;

            while (n <= 8)
            {
                Console.Write("Preço " + n + ": R$");
                preco = float.Parse(Console.ReadLine());

                if (preco > maior) 
                {
                    maior = preco;
                }
                if (preco < menor)
                {
                    menor = preco;
                }
                n++;
            }
            Console.WriteLine("Maior preço: R$" + maior);
            Console.WriteLine("Menor preço: R$" + menor);
        }
    }
}
