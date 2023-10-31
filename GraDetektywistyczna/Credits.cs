using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace GraDetektywistyczna
{
    class Credits
    {
        public static void ShowOff()
        {
            WriteLine("Tak właściwie to tylko jeden twórca, pomysłodawca i wykonawca ;P");
            Thread.Sleep(1000);
            WriteLine("Dawid Kalinowski");
            Thread.Sleep(1000);
            WriteLine("Naciśnij dowolny klawisz, aby wrócić do Menu Końcowego");
            ReadKey();
            Game.RunEndMenu();
        }
    }
}
