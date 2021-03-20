using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float somaNota = 0, mediaTurma, maiorNota = 0;
            int qtdAcimaMedia = 0;

            Console.WriteLine("Quantidade de alunos da turma: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int[] alunos = new int[n];
            float[] nota = new float[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nota aluno " + i + ": ");
                nota[i] = float.Parse(Console.ReadLine());

                if (nota[i] > maiorNota)
                {
                    maiorNota = nota[i];
                }
                somaNota = somaNota + nota[i];
            }
            mediaTurma = somaNota / n;
            Console.WriteLine("\nMédia da turma: " + Math.Round(mediaTurma,2));
            Console.WriteLine("Maior nota da turma: " + maiorNota);
            Console.Write("Posição da maior nota no vetor: ");

            for (int i = 0; i < n; i++)
            {
                if (nota[i] > mediaTurma)
                {
                    qtdAcimaMedia++;
                }
               if (maiorNota == nota[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\nQuantidade de alunos acima da média da turma: " + qtdAcimaMedia);
        }
    }
}
