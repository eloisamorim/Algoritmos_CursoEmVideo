using System;

namespace AT93_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, incremento;

            Console.WriteLine("Digite um valor para iniciar a contagem: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para a final da contagem: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o incremento: ");
            incremento = int.Parse(Console.ReadLine());

            contador(n1, n2, incremento);
        }

        static void contador(int a, int b, int c)
        {
            Console.WriteLine("");
            Console.Write(a + " >> ");
            if (a < b)
            {
                while (a < b)
                {
                    a = a + c;
                    Console.Write(a + " >> ");
                }
            }
            else
            {
                while (a > b)
                {
                    a = a - c;
                    Console.Write(a + " >> ");
                }
            }
            Console.Write(" FIM!");
        }
    }
}
