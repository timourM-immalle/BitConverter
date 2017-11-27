using System;

namespace ConsoleBits
{
    class Program
    {
        private static void DecToBin(int getal)
        {
            double[] machten = new double[getal];
            int som = 0;
            string bin = "";
            

            for (int i = getal; i <= 0; i--)
            {
                machten[i] = Convert.ToInt32(Math.Pow(2, i));
            }

            foreach (int resultaat in machten)
            {
                //bin += resultaat.ToString(); //maak zo'n virtuele tbl met het binair getallensysteem en zet zo op de juiste plaatsen een 0 of 1
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
            int dec = 10;
            DecToBin(dec);
        }
    }
}