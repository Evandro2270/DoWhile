using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                int cont = 10;

                do {
                    Console.WriteLine("Tioze");
                    cont++; 
                }
                while (cont < 5);
                Console.WriteLine(cont);

            }
        }
    }
}