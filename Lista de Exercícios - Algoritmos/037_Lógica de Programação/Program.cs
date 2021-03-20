using System;

namespace AT37_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            string genero;
            int tempo;
            float salario, novoSalario;

            Console.WriteLine("Há quanto tempo você está na empresa? (Em anos) ");
            tempo = int.Parse(Console.ReadLine());
            Console.Write("Qual o seu salário atual? R$");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual gênero você se identifica? [M/F] ");
            genero = Console.ReadLine();

            if (genero == "f" || genero == "F")
            {
                if (tempo < 15)
                {
                    novoSalario = (float)(salario * 1.05);
                }
                else if (tempo >= 15 && tempo <= 20)
                {
                    novoSalario = (float)(salario * 1.12);
                }
                else
                {
                    novoSalario = (float)(salario * 1.23);
                }
                Console.WriteLine("Novo salário: R$" + Math.Round(novoSalario, 2));
            }
            else if (genero == "m" || genero == "M")
            {
                if (tempo < 20)
                {
                    novoSalario = (float)(salario * 1.03);
                }
                else if (tempo >= 20 && tempo <= 30)
                {
                    novoSalario = (float)(salario * 1.13);
                }
                else
                {
                    novoSalario = (float)(salario * 1.25);
                }
                Console.WriteLine("Novo salário: R$" + Math.Round(novoSalario, 2));
            }
            else
            {
                Console.WriteLine("Por favor, digite um gênero válido! [M/F]");
            }
        }
    }
}
