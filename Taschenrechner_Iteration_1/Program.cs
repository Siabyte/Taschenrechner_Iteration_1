using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            /* User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
             */

            /* 
            string ersterText = "Zehn";
            string zweiterText = "10";
            string summe = ersterText + " + " + zweiterText; // Ausgabe: Zehn + 10
            Console.WriteLine("Ausgangswerte: " + ersterText + " + " + zweiterText);
            Console.WriteLine("Das Resultat: {0}", summe);   // Was ist {0} ?
            Console.ReadLine();

            int ersteZahl = 10;
            int zweiteZahl = 10;
            int zahlenSumme = ersteZahl + zweiteZahl;

            Console.WriteLine("Ausgangswerte: " + ersteZahl + " + " + zweiteZahl);
            Console.WriteLine("Das Resultat für Ganzzahlen: {0}", zahlenSumme);
            Console.ReadLine();
            */

            Console.Write("Bitte den ersten Summanden eingeben: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte den zweiten Summanden eingeben: ");
            string zweiterSummand = Console.ReadLine();

            // Wandel Text in Ganzahlen = Wandel vom Datentyp string zum Datentyp int:
            int ersterSummandAlsZahl = Convert.ToInt32(ersterSummand);
            int zweiterSummandAlsZahl = Convert.ToInt32(zweiterSummand);
            Console.WriteLine("Erster gewandelter Summand: {0}", ersterSummandAlsZahl);
            Console.WriteLine("Zweiter gewandelter Summand: {0}", zweiterSummandAlsZahl);
            Console.ReadLine();

            // Berechnung ausführen:
            int summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            // Ausgabe:
            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.ReadLine();
        }
    }
}
