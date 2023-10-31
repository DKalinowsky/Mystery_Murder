using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    abstract class Room
    {
        public int pow;
        public int okna;
        public string roomname;


        public Room(int _pow, int _okna, string _roomname)
        {
            pow = _pow;
            okna = _okna;
            roomname = _roomname;
        }
        public virtual string RoomInfo()
        {
            return "";

        }
        public override string ToString()
        {
            return RoomInfo();
        }
    }
}
