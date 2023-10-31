using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    class SecurityGuard : Human
    {
        private string stopien;
        public SecurityGuard(int _wiek, string _plec, string _rola, string _char, string _imie, string _nazwis, string _stop) : base(_wiek, _plec, _rola, _char, _imie, _nazwis)
        {
            stopien = _stop;
        }
        public override string PersonInfo()
        {
            Console.WriteLine("Informacje dotyczące osoby którą spotkałeś: ");
            return "Imie: " + imie + "\nNazwisko: " + nazwis + "\nWiek: " + wiek + "\nPłeć: " + plec + "\nCharakter w sprawie: " + charakter + "\nStopień: " + stopien + "\n";
        }
    }
}
