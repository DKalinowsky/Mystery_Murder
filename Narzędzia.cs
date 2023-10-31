using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    public abstract class Narzędzia
    {
        public int dlugosc;
        public string nazwa;

        protected Narzędzia(int _dl, string _nz)
        {
            dlugosc = _dl;
            nazwa = _nz;

        }

        public abstract string Opis();

    }
}
