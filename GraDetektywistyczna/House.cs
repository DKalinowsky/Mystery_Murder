using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    class House
    {
        public int hsnr;
        public int nrpom;
        public string ownernm;
        public int flrnr;


        public House(int _hsnr, int _nrpom, string _ownernm, int _flrnr)
        {
            hsnr = _hsnr;
            nrpom = _nrpom;
            ownernm = _ownernm;
            flrnr = _flrnr;
        }
        public override string ToString()
        {
            return "Znajdujesz się obok domu, który należy do: " + ownernm + ". \nBudynek ma numer: " + hsnr + ". \nDom ten posiada " + flrnr + " piętro. \nOraz " + nrpom + " pomieszczeń. ";

        }
       
    }
}
