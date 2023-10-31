using System;
using System.Collections.Generic;
using System.Text;

namespace GraDetektywistyczna
{
    class Bedroom : Room
    {
        public Bedroom(int _pow, int _okna, string _roomname) : base(_pow, _okna, _roomname)
        {

        }
        public override string RoomInfo()
        {
            Console.WriteLine("Informacje o Twojej aktualnej pozycji: ");
            return "Aktualnie przebywasz w: " + roomname + "\nPomieszczenie to liczy dokładnie: " + pow + " m^2" + "\nW pomiesczeniu jest: " + okna + " okna i jedne drzwi balkonowe.";
        }
    }
}
