using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GraDetektywistyczna
{
    class EndGame
    {

        public void DeathEnd()
        {
            Archivments.A6();
            string text = System.IO.File.ReadAllText("GameOver.txt");
            Animations.TextAnimation(text, 20);
            JSON2 js = new JSON2();
            js.JSON("End.json");
            Game.RunEndMenu();
        }
        public void Tobby()
        {
            string text = System.IO.File.ReadAllText("Tobby.txt");
            Animations.TextAnimation(text, 20);
            JSON2 js = new JSON2();
            js.JSON("Tobby.json");
            Game.RunEndMenu();
        }
        public void Merry()
        {
            string text = System.IO.File.ReadAllText("Merry.txt");
            Animations.TextAnimation(text, 20);
            JSON2 js = new JSON2();
            js.JSON("Merry.json");
            Game.RunEndMenu();
        }
        public void Tommy()
        {
            string text = System.IO.File.ReadAllText("Tommy.txt");
            Animations.TextAnimation(text, 20);
            JSON2 js = new JSON2();
            js.JSON("Tommy.json");
            Game.RunEndMenu();
        }
        public void John()
        {
            Archivments.A5();
            string text = System.IO.File.ReadAllText("John.txt");
            Animations.TextAnimation(text, 20);
            JSON2 js = new JSON2();
            js.JSON("John.json");
            Game.RunEndMenu();
        }
    }
}
