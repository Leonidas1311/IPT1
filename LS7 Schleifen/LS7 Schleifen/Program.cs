using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS7_Schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //1 · Wiederholung ohne Kopieren  ·

            for (int platz = 1; platz <= 3; platz++)
            {
                Console.WriteLine("Platz " + platz);
            }


            //3	· Eigene Zahlenreihe  ·

            for (int Regalnummern = 2; Regalnummern <= 10; Regalnummern += 2) //Regalnummern <= 10 / Reagalnummern <= 14 | Variante 14
            {
                Console.WriteLine(Regalnummern);
            }

            //4	· Akku-Anzeige untersuchen  ·

            int akku = 3; while (akku > 0)
            {
                Console.WriteLine("Noch " + akku + " Einheiten"); akku--;
            }

            //5	· Countdown am Schalter  ·

            int Countdown = 1; while (Countdown > 0)
            {
                Console.WriteLine("Countdown " + Countdown); Countdown--;
            }

            Console.WriteLine("Start ");

            //6	· Fehlerdetektiv  ·  

            //Code Fehler:

            int tickets = 1; while (tickets <= 4)
            {
                Console.WriteLine("Ticket " + tickets);
            }

            //Lösung:

            int Tickets = 1; while (Tickets <= 4)
            {
                Console.WriteLine(" Ticket " + Tickets); ++Tickets;
            }

            //7	· Eingabe wiederholen  ·  

            int auswahl; do
            {
                Console.Write("Wähle 1 oder 2: ");
                auswahl = Convert.ToInt32(Console.ReadLine());
            }
            while (auswahl != 1 && auswahl != 2); Console.WriteLine("Auswahl gespeichert.");

            //9	· Mini-Änderung  ·  

            int Auswahl; do
            {
                Console.Write("Wähle 1 oder 2: ");
                Auswahl = Convert.ToInt32(Console.ReadLine());
            }
            while (Auswahl != 1 && Auswahl != 2 && Auswahl != 3); Console.WriteLine("Auswahl gespeichert.");

            //10	· Bibliothek: Ausleihstation  ·  

            int anzahl; do
            {
                Console.Write("Wie viele Bücher? 1 bis 5: ");

                anzahl = Convert.ToInt32(Console.ReadLine());
            }
            while (anzahl != 1 && anzahl != 2 && anzahl != 3 && anzahl != 4 && anzahl != 5);

            for (int i = 1; i <= anzahl; i++)
            {
                Console.WriteLine("Buch " + i + " registriert");
            }

            int offen = anzahl;

            while (offen > 0)
            {
                Console.WriteLine("Noch " + offen + " offen"); offen--;
            }

            Console.WriteLine("Alle Bücher verarbeitet");


            Console.ReadLine();



        }
    }
}
