using System;

namespace AT29_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int tempo;
            double salario, salario2, reajuste;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Tempo na empresa em anos: ");
            tempo = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            salario = double.Parse(Console.ReadLine());


            if (tempo < 3)
            {
                reajuste = salario * 0.03;
            }
            else if (tempo >= 3 && tempo < 10)
            {
                reajuste = salario * 0.125;
            }
            else
            {
                reajuste = salario * 0.2;
            }

            salario2 = salario + reajuste;

            Console.WriteLine("Funcionário: " + nome + "\nSalário atual: R$" + salario + "\nNOVO SALÁRIO: R$" + salario2);
        }
    }
}
