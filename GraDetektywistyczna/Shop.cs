using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    class Shop
    {
        public int hsnr;
        public string ownernm;


        public Shop(int _hsnr, string _ownernm)
        {
            hsnr = _hsnr;
            ownernm = _ownernm;
        }
        public override string ToString()
        {
            return "Znajdujesz się obok sklepu, który należy do: " + ownernm + ". \nBudynek ma numer: " + hsnr;
        }
    }
}
