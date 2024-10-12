using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite jedan cijeli broj i jedan decimalni broj, odvojene razmakom:");

            // Čitanje unosa
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            // Parsiranje cijelog broja i decimalnog broja
            int cijeliBroj = int.Parse(parts[0]);
            double decimalniBroj = double.Parse(parts[1]);

            // Dvostruke vrijednosti unešenih brojeva
            double x = cijeliBroj * 2;
            double y = decimalniBroj * 2;

            Console.WriteLine($"Dvostruka vrijednost cijelog broja je: {x}");
            Console.WriteLine($"Dvostruka vrijednost decimalnog broja je: {y}");
        }
    }
    }
}
