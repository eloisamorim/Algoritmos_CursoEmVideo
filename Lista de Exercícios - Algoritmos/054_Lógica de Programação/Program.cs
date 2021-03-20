using System;

namespace AT54_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, mediaH, somaH = 0;
            int i = 1, mais1 = 0, menos2 = 0, mais3 = 0;

            while (i <= 2)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("-      " + i + "      -");
                Console.WriteLine("---------------");
                Console.Write("Peso (kg): ");
                peso = float.Parse(Console.ReadLine());
                Console.Write("Altura (m): ");
                altura = float.Parse(Console.ReadLine());
                Console.WriteLine("");

                somaH = somaH + altura;

                if (peso > 90)
                {
                    mais1++;
                }
                if (peso < 50 && altura < 1.6)
                {
                    menos2++;
                }
                if (peso > 100 && altura > 1.9)
                {
                    mais3++;
                }
                i++;
            }
            mediaH = somaH / 7;

            Console.WriteLine("Média de altura do grupo: " + Math.Round(mediaH, 2) + "m");
            Console.WriteLine("Quantidade de pessoas acima de 90kg: " + mais1);
            Console.WriteLine("Quantidade de pessoas que pesam menos de 50kg e altura menor que 1,60m: " + menos2);
            Console.WriteLine("Quantidade de pessoas que medem mais de 1,90m e pesam mais de 100kg: " + mais3);
        }
    }
}
