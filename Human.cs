using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    abstract class Human
    {
        public int wiek;
        public string plec;
        public string rola;
        public string charakter;
        public string imie;
        public string nazwis;


        public Human(int _wiek, string _plec, string _rola, string _char, string _imie, string _nazwis)
        {
            wiek = _wiek;
            plec = _plec;
            rola = _rola;
            charakter = _char;
            imie = _imie;
            nazwis = _nazwis;
        }
        public virtual string PersonInfo()
        {
            return "";
        }
        public override string ToString()
        {
            return PersonInfo();

        }
    }
}
