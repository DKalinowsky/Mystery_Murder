using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    class Opcja1 : Opcje
    {
        public override Narzędzia Uzyte(DzienTygodnia dzien)
        {
            switch (dzien)
            {
                case DzienTygodnia.Poniedziałek:
                    {
                        return new Domowe(15, Losowanie(NarzedziaDomowe()), "idk");
                    }
                case DzienTygodnia.Wtorek:
                    {
                        return new Specjalne(15, Losowanie(NarzedziaSpecjalne()), "idk");
                    }
                case DzienTygodnia.Środa:
                    {
                        return new Domowe(15, Losowanie(NarzedziaDomowe()), "idk");
                    }
                case DzienTygodnia.Czwartek:
                    {
                        return new Specjalne(15, Losowanie(NarzedziaSpecjalne()), "idk");
                    }
                case DzienTygodnia.Piątek:
                    {
                        return new Domowe(15, Losowanie(NarzedziaDomowe()), "idk");
                    }
                case DzienTygodnia.Sobota:
                    {
                        return new Specjalne(15, Losowanie(NarzedziaSpecjalne()), "idk");
                    }
                case DzienTygodnia.Niedziela:
                    {
                        return new Domowe(15, Losowanie(NarzedziaDomowe()), "idk");
                    }
            }
            throw new System.SystemException("Error 404!");
        }
    }
}
