using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    class Specjalne : Narzędzia
    {
        private string rodzaj;
        public Specjalne(int _dl, string _nz, string _rdz): base(_dl, _nz)
        {
            rodzaj = _rdz;
        }
        public override string Opis()
        {
            return ("Narzędzie o nazwie: " + nazwa + "\nO długości: " + dlugosc + " cm.\nRodzaj narzędzia: " + rodzaj);
        }
    }
}
