using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    abstract class SpaceCreator
    {
        public abstract House DisplayInfo(int houseNR);
        public abstract Shop DisplayInfo1(int shopNR);
        public abstract Room DisplayInfo3(string roomType);
    }
}
