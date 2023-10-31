using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraDetektywistyczna
{
    public abstract class Opcje
    {
        protected Random random;
        protected Opcje()
        {
            random = new Random();
        }
        public abstract Narzędzia Uzyte(DzienTygodnia dzien);
        protected string[] NarzedziaSpecjalne()
        {
            return new string[] { "Kij bejsbolowy", "Pałka teleskopowa", "Kastet" };
        }

        protected string[] NarzedziaDomowe()
        {
            return new string[] {"Lampka nocna", "Miedziany posążek"};
        }

        public string Losowanie(string[] doLosowania)
        {
            int index = random.Next(doLosowania.Count());
            return doLosowania[index];
        }
    }
}
