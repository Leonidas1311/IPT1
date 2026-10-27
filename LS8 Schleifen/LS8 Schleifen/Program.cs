using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS8_Schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Teil B · Eingabe wiederholen 
            int menge;

            do
            {
                Console.Write("Menge: ");

                menge = Convert.ToInt32(Console.ReadLine());

                if (menge <= 0)
                {

                    Console.WriteLine("Ungültige Menge.");

                }

            }

            while (menge <= 0);

            Console.WriteLine($"Menge übernommen: {menge}");



            //Bug-Auftrag 
            for (int i = 1; i <= menge; i++)
            {
                Console.WriteLine($"Etikett {i}");
            }



            Console.ReadLine();



        }
    }
}
