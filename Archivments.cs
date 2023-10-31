using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GraDetektywistyczna
{
    class Archivments
    {
        static List<string> names = new List<string> { };
        public static void A1()
        {
            names.Add("Odwiedzenie warsztatu.");
        }
        public static void A2()
        {
            names.Add("Przeszukanie salonu.");
        }
        public static void A3()
        {
            names.Add("Znalezienie narzędzia zbrodni.");
        }
        public static void A4()
        {
            names.Add("Włamanie się do budki ochroniarza.");
        }
        public static void A5()
        {
            names.Add("Oskarżenie winnej osoby.");
        }
        public static void A6()
        {
            names.Add("Śmierć poprzez postrzelenie.");
        }
        public static void A7()
        {
            names.Add("Odszyfrowanie wiadomości.");
        }

        public static void YourArchivments()
        {
            foreach (var name in names)
            {
                WriteLine("> " + name);
            }
        }

        public static void ShowArchivments()
        {
            WriteLine(">>>> Wszystkie możliwe osiągnięcia do zdobycia: ");
            WriteLine(">Odwiedzenie warsztatu.");
            WriteLine(">Przeszukanie salonu.");
            WriteLine(">Znalezienie narzędzia zbrodni.");
            WriteLine(">Włamanie się do budki ochroniarza.");
            WriteLine(">Oskarżenie winnej osoby.");
            WriteLine(">Śmierć poprzez postrzelenie.");
            WriteLine(">Odszyfrowanie wiadomości.");
            WriteLine(">>>> Wszystkie zdobyte przez Ciebie osiągnięcia:");
            YourArchivments();
            WriteLine("Naciśnij dowolny klawisz, aby wrócić do Menu Końcowego.");
            ReadKey();
            Game.RunEndMenu();

        }
    }
}
