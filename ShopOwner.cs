using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    class ShopOwner : Human
    {
        private string zawod;
        public ShopOwner(int _wiek, string _plec, string _rola, string _char, string _imie, string _nazwis, string _zaw) : base(_wiek, _plec, _rola, _char, _imie, _nazwis)
        {
            zawod = _zaw;
        }
        public override string PersonInfo()
        {
            Console.WriteLine("Informacje dotyczące osoby którą spotkałeś: ");
            return "Imie: " + imie + "\nNazwisko: " + nazwis + "\nWiek: " + wiek + "\nPłeć: " + plec + "\nCharakter w sprawie: " + charakter + "\nZawód: " + zawod + "\n";
        }
    }
}
