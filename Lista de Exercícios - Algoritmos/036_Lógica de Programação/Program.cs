using System;

namespace AT36_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            float tempo, pontos, saldo;

            Console.Write("Quantas horas por MÊS você pratica atividades físicas? ");
            tempo = float.Parse(Console.ReadLine());

            if (tempo > 0)
            {
                if (tempo < 10)
                {
                    pontos = 2 * tempo;
                }
                else if (tempo >= 10 && tempo < 20)
                {
                    pontos = 5 * tempo;
                }
                else
                {
                    pontos = 10 * tempo;
                }
                saldo = (float)(pontos * 0.05);

                Console.WriteLine("Parabéns!!     Valor a receber: R$" + Math.Round(saldo, 2));
            } 
            else
            {
                Console.WriteLine("Infelizmente você não ganhou nada. Se exercite!");
            }
        }
    }
}
