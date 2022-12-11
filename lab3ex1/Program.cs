using System;

namespace lab3ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 1 Scrieti o functie care va calcula suma cifrelor unui numar. */

            Console.WriteLine("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Suma cifrelor este = ");
            Console.WriteLine(CalculeazaSumaCifrelor(n));

        }

        public static int CalculeazaSumaCifrelor(int x) 
        {
            int sumaCifrelor = 0;

            while (x > 0)
            {
                int ultimaCifra = x % 10;
                x = x / 10;
                sumaCifrelor = sumaCifrelor + ultimaCifra;
            }

            return sumaCifrelor;
        }


    }
}
