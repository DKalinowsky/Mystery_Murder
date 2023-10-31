using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace GraDetektywistyczna
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            HistoricalBackgound hb = new HistoricalBackgound();
            Game.Start();
            mcm.FirstChoice();
            hb.GameStart();
            string text = System.IO.File.ReadAllText("PierwszaDecyzja.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("Naciśnij dowolny klawisz, aby kontynuować");
            ReadKey();
            Clear();
            mcm.Miasteczko();            

        }
    }
}
