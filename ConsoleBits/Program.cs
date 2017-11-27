using System;

namespace ConsoleBits
{
    class Program
    {
        private static void ToBin(uint getal)
        {
            double[] machten = new double[getal];
            int som = 0;

            for (int i = 0; i < getal; i++)
            {
                machten[i] = Convert.ToInt32(Math.Pow(2, i));
            }

            foreach (int resultaat in machten)
            {
                som += resultaat;
            }

            Console.WriteLine(som);
        }

        private static void DecToHex(uint getal)
        {
            Console.WriteLine();
        }

        private static void BinToHex(uint getal)
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            uint dec = 10;
            ToBin(dec);
        }
    }
}