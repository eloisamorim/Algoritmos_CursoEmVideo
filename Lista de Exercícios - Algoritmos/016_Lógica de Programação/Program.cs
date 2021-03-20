using System;

namespace AT16_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntCig, tempo, tempoMorte, tempoAnos;

            Console.WriteLine("Quantos cigarros por dia você fuma?");
            qntCig = int.Parse(Console.ReadLine());
            Console.WriteLine("Há quanto tempo você fuma?");
            tempo = int.Parse(Console.ReadLine());

            tempoMorte = qntCig * tempo * 365;
            tempoAnos = tempoMorte / 365;

            Console.WriteLine("Sabia que você já perdeu " + tempoMorte + " dias de sua vida?");
            Console.WriteLine("Isso é equivalente a " + tempoAnos + " anos e você só fuma há " + tempo + " anos \n");
            Console.WriteLine("PARE DE FUMAR!");

        }
    }
}
