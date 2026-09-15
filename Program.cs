using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmus_und_EVA_in_C__IPT1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Name des Artikels?");
            string Artikel = Console.ReadLine();

            Console.WriteLine("Preis des Artikel?");
            decimal Preis = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Wie viele?");
            int Menge = Convert.ToInt32(Console.ReadLine());

            decimal gesamtpreis = Preis * Menge;

            Console.WriteLine(Artikel + " kostet " + gesamtpreis.ToString("0.00") + " CHF. ");


            Console.ReadLine();

        }
    }
}
