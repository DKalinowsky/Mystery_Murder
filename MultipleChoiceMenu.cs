using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GraDetektywistyczna
{
    class MultipleChoiceMenu
    {
        public void FirstChoice()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Musisz zapoznać się z aktami sprawy, wybierz jeden przedmiot, którego chcesz użyć ze swojego ekwipunku: \n";
            string[] options = { "Telefon", "Aparat", "Akta sprawy" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); pm.Phone(); break;
                case 1: Clear(); pm.Camera(); break;
                case 2: Clear(); pm.Files(); break;
            }
        }
        public void Miasteczko()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Wybierz miejsce które chcesz sprawdzić: \n";
            string[] options = {"Dom ofiary (nr 22)", "Budka ochroniarza", "Sklep", "Pusty plac ", "Dom nr 23", "Dom nr 21", "Wnieś akt oskarżenia"};
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); pm.VicitmHouse(); break;
                case 1: Clear(); pm.Security(); break;
                case 2: Clear(); pm.Shop(); break;
                case 3: Clear(); pm.Outside(); break;
                case 4: Clear(); pm.House1(); break;
                case 5: Clear(); pm.House2(); break;
                case 6: Clear(); AktOskarzenia(); break;
            }

        }
        public void AktOskarzenia()
        {
            EndGame eg = new EndGame();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Jesteś pewny, że chcesz zakończyć śledztwo i wnieść akt oskarżenia ?\n";
            string[] options = { "Tak, zakończ śledztwo", "Nie, kontynuuj śledztwo" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); WniesAkt(); break;
                case 1: Clear(); Miasteczko(); break;
            }
        }
        public void WniesAkt()
        {
            EndGame eg = new EndGame();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Wbierz osobę którą chcesz aresztować i oskarżyć\n";
            string[] options = { "John Lawrence", "Tommy VanMag", "Merry O'Brian", "Tobby Ross" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); eg.John(); break;
                case 1: Clear(); eg.Tommy(); break;
                case 2: Clear(); eg.Merry(); break;
                case 3: Clear(); eg.Tobby(); break;
            }
        }
        public void LockPick()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Podniesłeś z ziemi prowizoryczny wytrych. Co robisz ? \n";
            string[] options = { "Wracam pod parking, żeby sprawdzić inne miejsce", "Próbuję otworzyć kłódkę" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); Miasteczko(); break;
                case 1: Clear(); pm.LockPicking(); break;
            }
        }
        public void VHouse()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Nie masz kluczy do drzwi, Wybierz co chcesz zrobić w tej sytuacji: \n";
            string[] options = { "Opuść posesję, żeby zacząć śledztwo w innym miejscu", "Prezjdź na tyły domu" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); Miasteczko(); break;
                case 1: Clear(); pm.Behind(); break;
            }
        }
        public void Wooden()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "To pomieszczenie nie ma żadnego zamka, a drzwi są lekko uchylone, co robisz ? \n";
            string[] options = { "Wchodzę do środka", "Kontynuuje obchód w okół domu" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); pm.Inside(); break;
                case 1: Clear(); pm.Continue(); break;
            }
        }
        public void Salon()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Stoisz na środku salonu. Co robisz ?\n";
            string[] options = {"Fotografuję całe pomieszczenie zanim zaczne coś robić", "Zaczynam się rozglądać po salonie i go przeszukiwać w celu znalezienia dowodów", "Salon raczej nie ma znaczenia, ponieważ zwłoki znalezione zostały w sypialni"};
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); Salonv2(); break;
                case 1: Clear(); pm.Searching(); break;
                case 2: Clear(); GoNext(); break;
            }
        }
        public void Salonv2()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Pstryk.... Pstryk... Sfotografowałeś już całe pomieszczenie, co dalej ?\n";
            string[] options = {"Zaczynam się rozglądać po salonie i go przeszukiwać w celu znalezienia dowodów", "Salon raczej nie ma znaczenia, ponieważ zwłoki znalezione zostały w sypialni" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();
            switch (seletedIndex)
            {
                case 0: Clear(); pm.Searching(); break;
                case 1: Clear(); GoNext(); break;
            }
        }
        public void GoNext()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Salon połączony jest z kuchnią, schodami na górę oraz z przedpokojem. Gdzie idziesz ?\n";
            string[] options = {"Idę do kuchni", "Idę po schodach na górę", "Idę do przed pokoju"};
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); Kuchnia(); break;
                case 1: Clear(); Schody(); break;
                case 2: Clear(); Przedpokoj(); break;
            }
        }
        public void Przedpokoj()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();            
            Building bil = new Building();
            Hall hl1 = (Hall)bil.DisplayInfo3("Przedpokój");
            WriteLine(hl1);
            ReadKey();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Mały, ale przestronny przedpokój, na stojaku na buty widać buty do chodzenia po domu o na oko numerze 43.\nPotężne drzwi wejściowe, które są jednak zamknięte na klucz.\nNic więcej tu nie ma.\n";
            string[] options = { "Wracam do salonu"};
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); GoNext(); break;
            }
        }
        public void Kuchnia()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Building bil = new Building();
            Kitchen lr1 = (Kitchen)bil.DisplayInfo3("Kuchnia");
            WriteLine(lr1 + "\n" + "Naciśnij dowolny klawisz, aby kontynuować" + "\n");
            ReadKey();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Jesteś w kuchni\n";
            string[] options = { "Fotografuję całe pomieszczenie zanim zaczne coś robić", "Zaczynam się rozglądać po kuchni i ją przeszukiwać w celu znalezienia dowodów", "Kuchnia raczej nie ma znaczenia, ponieważ zwłoki znalezione zostały w sypialni" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); Kuchniav2(); break;
                case 1: Clear(); pm.SearchingKuchnia(); break;
                case 2: Clear(); KuchniaOut(); break;
            }
        }
        public void Kuchniav2()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Pstryk.... Pstryk... Sfotografowałeś już całe pomieszczenie, co dalej ?\n";
            string[] options = {"Zaczynam się rozglądać po kuchni i ją przeszukiwać w celu znalezienia dowodów", "Kuchnia raczej nie ma znaczenia, ponieważ zwłoki znalezione zostały w sypialni" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); pm.SearchingKuchnia(); break;
                case 1: Clear(); KuchniaOut(); break;
            }
        }
        public void KuchniaOut()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Jako, że kuchnia, nie ma znaczenia, a połączona jest tylko z salonem. Masz tylko jedną opcję: \n";
            string[] options = {"Wracam do salonu"};
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); GoNext(); break;
            }
        }
        public void Schody()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Jesteś już na piętrze. Możesz wejść albo do łazienki, albo do sypialni.\n";
            string[] options = {"Wchodzę do łazienki", "Wchodzę do sypialni"};
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); pm.Łazienka(); break;
                case 1: Clear(); pm.Sypialnia(); break;
            }
        }
        public void Łazienka()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "\n";
            string[] options = { "Wchodzę do łazienki", "Wchodzę do sypialni" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); Łazienka(); break;
                case 1: Clear(); Sypialnia(); break;
            }
        }
        public void Sypialnia()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "\n";
            string[] options = { "Wchodzę do łazienki", "Wchodzę do sypialni" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); Łazienka(); break;
                case 1: Clear(); Sypialnia(); break;
            }
        }
        public void Sypialniav2()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Stoisz przy drzwiach do sypialni. Co robisz ?\n";
            string[] options = { "Fotografuję całe pomieszczenie zanim zaczne coś robić", "Zaczynam się rozglądać po sypialni i ją przeszukiwać w celu znalezienia dowodów"};
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); Sypialniav3(); break;
                case 1: Clear(); pm.SearchingBedroom(); break;
            }
        }
        public void Sypialniav3()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Pstryk.... Pstryk... Sfotografowałeś już całe pomieszczenie, co dalej ?\n";
            string[] options = {"Zaczynam się rozglądać po sypialni i ją przeszukiwać w celu znalezienia dowodów" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); pm.SearchingBedroom(); break;
            }
        }
        public void VHOut()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Sprawdziłeś już cały dom. Opusczczasz teren Jamesa Stone'a i wracasz na miejsce obok parkingu z którego zacząłeś:\n";
            string[] options = { "Wychodzę z domu i wracam na parking. " };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); Miasteczko(); break;
            }
        }
        public void Death1()
        {
            PlotMeyhod pm = new PlotMeyhod();
            EndGame eg = new EndGame();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Znalazłeś się w sytuacji bezpośredniego zagrożenia swojego życia. Co robisz w tej sytuacji:\n";
            string[] options = { "Jestem wystarczająco blisko, żeby obezwładnić ochroniaża i odebrać mu pistolet, zanim zdąży wystrzelić", "Powoli podnoszę obie ręce do góry i delikatnie się wycofuje" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); eg.DeathEnd(); break;
                case 1: Clear(); pm.Guard(); break;
            }
        }
        public void PlacWybor()
        {
            PlotMeyhod pm = new PlotMeyhod();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Właśnie się rozłączyłeś... Co robisz ?\n";
            string[] options = {"Odkładam telefon i zaczynam się rozglądać po placu", "Używam programu do deszyfrowania, aby odczytać listę od oficera"};
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Clear(); pm.PlacSearch(); break;
                case 1: Clear(); pm.Szyfrowanie(); break;
            }
        }
    }
}
