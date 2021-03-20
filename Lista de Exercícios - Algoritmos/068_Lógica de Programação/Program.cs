using System;

namespace AT68_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso, maiorPesoHomem = 0, media, pesoTotalF = 0;
            int sexo, qtdMulheres = 0, HomemMais100 = 0;

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("-  Cadastro " + i + "  -");
                Console.WriteLine("[1] - Feminino \n[2] - Masculino");
                sexo = int.Parse(Console.ReadLine());
                Console.WriteLine("Peso em kg: ");
                peso = float.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (sexo == 1)
                {
                    qtdMulheres++;
                    pesoTotalF = pesoTotalF + peso;
                }
                if (sexo == 2)
                {
                    if (peso > 100)
                    {
                        HomemMais100++;
                    }
                    if (peso > maiorPesoHomem)
                    {
                        maiorPesoHomem = peso;
                    }
                }
            }
            media = pesoTotalF / qtdMulheres;

            Console.WriteLine("Quantidade de mulheres cadastradas: " + qtdMulheres);
            Console.WriteLine("Quantidade de homens com mais de 100kg: " + HomemMais100);
            Console.WriteLine("Média de peso entre as mulheres: " + media + "kg");
            Console.WriteLine("Maior peso entre os homens: " + maiorPesoHomem + "kg");
        }
    }
}
