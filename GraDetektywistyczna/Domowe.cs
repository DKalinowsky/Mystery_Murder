using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    public class Domowe : Narzędzia
    {
        private string zastosowanie;
        public Domowe(int _dl, string _nz, string _zas) : base(_dl, _nz)
        {
            zastosowanie = _zas;
        }
        public override string Opis()
        {
            return ("Narzędzie o nazwie: " + nazwa + "\nO długości: " + dlugosc + " cm.\nCodzienne zastosowanie narzędzia: " + zastosowanie);
        }
    }
}
