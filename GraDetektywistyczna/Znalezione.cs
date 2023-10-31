using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    public class Znalezione
    {
        private Opcje opcje;
        public string Uzyte(DzienTygodnia dzien)
        {
            return opcje.Uzyte(dzien).Opis();
        }
        public Znalezione(Opcje _opcje)
        {
            opcje = _opcje;
        }

    }
}
