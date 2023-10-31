using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Text.Json;

namespace GraDetektywistyczna
{
    public class JSON1
    {
        public string Wynik { get; set; }
        /*public string Nazwisko { get; set; }
        public string Płeć { get; set; }
        public string Wiek { get; set; }
        public string Wzrost { get; set; }
        public string Zawód { get; set; }
        public string PowódZatrzymania { get; set; }
        public string AktOskarżenia { get; set; }
        public string Osoba { get; set; }
        public string Podstawa { get; set; }*/
        public JSON1()
        {
            Wynik = "";
            /*Imie = "";
            Nazwisko = "";
            Płeć = "";
            Wiek = "";
            Wzrost = "";
            Zawód = "";
            PowódZatrzymania = "";
            AktOskarżenia = "";
            Osoba = "";
            Podstawa = "";*/
        }
        public void ShowElements()
        {
            Animations.TextAnimation($"{Wynik}", 20);
            ReadKey();
        }

    }
}
