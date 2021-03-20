using System;

namespace AT8_Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            float m, dm, cm, mm, dam, hm, km;

            Console.WriteLine("Digite uma distância em metros: ");
            m = float.Parse(Console.ReadLine());

            dm = m * 10;
            cm = m * 100;
            mm = m * 1000;
            dam = m / 10;
            hm = m / 100;
            km = m / 1000;

            Console.WriteLine("A distância de " + m + "m é equivalente a: ");
            Console.WriteLine(km + "km    " + hm + "hm    " + dam + "dam " );
            Console.WriteLine(dm + "dm    " + cm + "cm    " + mm + "mm ");
        }
    }
}
