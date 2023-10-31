using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace GraDetektywistyczna
{
    class Game
    {
        public static void Start()
        {
            Title = "MysteryOfGreenHill";
            CursorVisible = false;
            RunMainMenu();
        }
        private static void RunMainMenu()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = @"

___  ___          _                  _____  __ _____                     _   _ _ _ _ 
|  \/  |         | |                |  _  |/ _|  __ \                   | | | (_) | |
| .  . |_   _ ___| |_ ___ _ __ _   _| | | | |_| |  \/_ __ ___  ___ _ __ | |_| |_| | |
| |\/| | | | / __| __/ _ \ '__| | | | | | |  _| | __| '__/ _ \/ _ \ '_ \|  _  | | | |
| |  | | |_| \__ \ ||  __/ |  | |_| \ \_/ / | | |_\ \ | |  __/  __/ | | | | | | | | |
\_|  |_/\__, |___/\__\___|_|   \__, |\___/|_|  \____/_|  \___|\___|_| |_\_| |_/_|_|_|
         __/ |                  __/ |                                                
        |___/                  |___/                                                                                            
" + "\n" + "Witaj w Menu Głównym \n" + "Zalecana jest gra w trybie Pełny Ekran\n" + "Włączenie trybu Pełny Ekran jest dostępne w Opcjach Gry\n" + "Animację dialogów można pomijać klikając Enter\n";
            string[] options = { "Start", "Opcje Gry", "Wyjście" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); HistoricalBackgound.Introduction(); break;
                case 1: Clear(); RunOptionsMenu(); break;
                case 2: Environment.Exit(0); break;
            }
        }
        public static void RunEndMenu()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Witaj w Menu Końcowym \n";
            string[] options = { "Powrót do Menu Głównego", "Osiągnięcia", "Twórcy", "Wyjście" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); RunMainMenu(); break;
                case 1: Clear(); Archivments.ShowArchivments(); break;
                case 2: Clear(); Credits.ShowOff(); break;
                case 3: Environment.Exit(0); break;
            }
        }
        public static void RunOptionsMenu()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Witaj w Menu Opcji \n";
            string[] options = { "Tryb Pełnego Ekranu", "Powrót do Menu Głównego" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); FullScreen.FullScreenMode(); break;
                case 1: Clear(); RunMainMenu(); break;
            }
        }
    }
}
