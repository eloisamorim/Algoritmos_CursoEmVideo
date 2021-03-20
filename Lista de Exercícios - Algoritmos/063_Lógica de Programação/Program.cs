using System;

namespace AT63_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma = 0, contador = 0, menorValor = 1000, par = 0;  
            float media;
            string continuar;
                     
            do
            {
                Console.Write("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Deseja continuar? [S/N]");
                continuar = Console.ReadLine();

                soma = soma + n;
                contador++;
                
                if (n < menorValor)
                {
                    menorValor = n;
                }
                if (n % 2 == 0)
                {
                    par++;
                }

            } while (continuar == "s" || continuar == "S");

            media = soma / contador;

            Console.WriteLine("");
            Console.WriteLine("Somatório entre todos os valores: " + soma);
            Console.WriteLine("Menor valor digitado: " + menorValor);
            Console.WriteLine("Média entre todos os valores: " + media);
            Console.WriteLine("Quantidade de números pares: " + par);
        }
    }
}
