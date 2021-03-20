using System;

namespace AT57_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, TotalF = 0, TotalM = 0;
            int s;
            string escolha;

            do
            {
                Console.Write("Salário: R$");
                salario = float.Parse(Console.ReadLine());
                Console.WriteLine("Sexo: \n[1] - Masculino \n[2] - Feminino");
                s = int.Parse(Console.ReadLine());
                Console.WriteLine("Continuar? [S/N]");
                escolha = Console.ReadLine();

                if (s == 1)
                {
                    TotalM = TotalM + salario;
                }
                else
                {
                    TotalF = TotalF + salario;
                }
                Console.Clear();
            } while (escolha == "S" || escolha == "s");

            Console.WriteLine("Salário total - Homens: \n R$" + TotalM);
            Console.WriteLine("Salário total - Mulheres: \n R$" + TotalF);
        }
    }
}
