using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace GraDetektywistyczna
{
    class HistoricalBackgound
    {
        public static void Introduction()
        {
            string a = "Nciśnij dwolony klawisz, aby kontynuować";
            string text = System.IO.File.ReadAllText("Instrukcja.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            string text1 = System.IO.File.ReadAllText("HistoryczneWprowadzenie.txt");
            Animations.TextAnimation(text1, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            string text2 = System.IO.File.ReadAllText("Początek.txt");
            Animations.TextAnimation(text2, 20);
            ReadKey();
            Clear();

        }
        public void GameStart()
        {
            string a = "Nciśnij dwolony klawisz, aby kontynuować";
            string text = System.IO.File.ReadAllText("Start.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            string text1 = System.IO.File.ReadAllText("Miasteczko.txt");
            Animations.TextAnimation(text1, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
        }
    }
}
