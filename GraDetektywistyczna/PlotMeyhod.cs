using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GraDetektywistyczna
{
    class PlotMeyhod
    {
        private string a = "Nciśnij dwolony klawisz, aby kontynuować";
        public void Phone()
        {
            Animations.TextAnimation("Posiadasz najnowszy telefon marki Zamzung Galactis M20 Ultra Pro, ale telefon nie zapozna się z aktami sprawy za ciebie... Weź się do roboty.\n", 20);
            WriteLine("\n" + a);
            ReadKey();
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            mcm.FirstChoice();
        }
        public void Camera()
        {
            Animations.TextAnimation("Posiadasz najnowszy aparat Mikon Z3500, ale aparat nie pomożę Ci zapoznać się z aktami sprawy... Weź się do roboty.\n", 20);
            WriteLine("\n" + a);
            ReadKey();
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            mcm.FirstChoice();
        }
        public void Files()
        {
            string text = System.IO.File.ReadAllText("Akta strona 1.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\nNaciśnij dowolny klawisz, aby przejść na kolejną stronę akt");
            ReadKey();
            Clear();
            string text1 = System.IO.File.ReadAllText("Akta strona 2.txt");
            Animations.TextAnimation(text1, 20);
            WriteLine("\nNaciśnij dowolny klawisz, aby przejść na kolejną stronę akt");
            ReadKey();
            Clear();
            string text2 = System.IO.File.ReadAllText("Szkic.txt");
            WriteLine(text2);
            WriteLine("\nNaciśnij dowolny klawisz, aby zamknąć akta");
            ReadKey();
            Clear();
        }
        public void Shop()
        {
            Building bil = new Building();
            Shop sh1 = bil.DisplayInfo1(20);
            WriteLine(sh1 + "\n");
            string text = System.IO.File.ReadAllText("Sklep.txt");
            Animations.TextAnimation(text, 20);
            ShopOwner so1 = new ShopOwner(34, "Mężczyzna", "idk", "Podejrzany", "Tommy", "VanMag", "Właściciel sklepu");
            WriteLine(so1 + "\n");
            string text2 = System.IO.File.ReadAllText("Sklep2.txt");
            Animations.TextAnimation(text2, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            mcm.Miasteczko();

        }
        public void Outside()
        {
            string text = System.IO.File.ReadAllText("Plac.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            PoliceOfficer po = new PoliceOfficer(32, "Mężczyzna", "idk", "Oficer policji prowadzący sprawę", "Tom", "Smith", "Oficer");
            WriteLine(po);
            string text2 = System.IO.File.ReadAllText("PhoneCall.txt");
            Animations.TextAnimation(text2, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            mcm.PlacWybor();

        }
        public void VicitmHouse()
        {
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            Building bil = new Building();
            House hs1 = bil.DisplayInfo(22);
            WriteLine(hs1 + "\n");
            string text = System.IO.File.ReadAllText("DomOfiary.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            mcm.VHouse();
        }
        public void Security()
        {
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            string text = System.IO.File.ReadAllText("BudkaOchroniaza.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            mcm.LockPick();

        }
        public void House1()
        {
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            Building bil = new Building();
            House hs1 = bil.DisplayInfo(21);
            WriteLine(hs1 + "\n");
            string text = System.IO.File.ReadAllText("Dom1.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            Witness ws = new Witness(22, "Kobieta", "idk", "Podejrzana", "Marry", "O'Brian", "Projektantka wnętrz");
            WriteLine(ws + "\n");
            string text2 = System.IO.File.ReadAllText("Dom12.txt");
            Animations.TextAnimation(text2, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            SecurityGuard sg = new SecurityGuard(24, "Mężczyzna", "idk", "Ochroniaż", "John", "Lawrence", "Podporucznik");
            WriteLine(sg);
            string text3 = System.IO.File.ReadAllText("Ochrioniarz2.txt");
            Animations.TextAnimation(text3, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            mcm.Miasteczko();
        }
        public void House2()
        {
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            Building bil = new Building();
            House hs1 = bil.DisplayInfo(23);
            WriteLine(hs1 + "\n");
            string text = System.IO.File.ReadAllText("Dom2.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            Witness ws = new Witness(29, "Mężczyzna", "idk", "Podejrzany", "Tobby", "Ross", "Menager ds. marketingu");
            WriteLine(ws + "\n");
            string text2 = System.IO.File.ReadAllText("Dom22.txt");
            Animations.TextAnimation(text2, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            mcm.Miasteczko();
        }
        public void Behind()
        {
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            string text = System.IO.File.ReadAllText("Behind.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            mcm.Wooden();
        }
        public void Inside()
        {
            Archivments.A1();
            string text = System.IO.File.ReadAllText("Inside.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            WriteLine("Wychodzisz z pomieszczenia i wracasz do obchodzenia domu. \n");
            Continue();
        }
        public void Continue()
        {
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            string text = System.IO.File.ReadAllText("Continue.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            Building bil = new Building();
            LivingRoom lr1 = (LivingRoom)bil.DisplayInfo3("Salon");
            WriteLine(lr1 + "\n");
            string text1 = System.IO.File.ReadAllText("Salon.txt");
            Animations.TextAnimation(text1, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            mcm.Salon();
        }
        public void Searching()
        {
            Archivments.A2();
            string text = System.IO.File.ReadAllText("Search.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            mcm.GoNext();
        }
        public void SearchingKuchnia()
        {
            string text = System.IO.File.ReadAllText("SearchKuchnia.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            mcm.KuchniaOut();
        }
        public void Łazienka()
        {
            Building bil = new Building();
            Bathroom lr1 = (Bathroom)bil.DisplayInfo3("Łazienka");
            WriteLine(lr1 + "\n");
            string text = System.IO.File.ReadAllText("Łazienka.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            mcm.Schody();
        }
        public void Sypialnia()
        {
            Building bil = new Building();
            Bedroom lr1 = (Bedroom)bil.DisplayInfo3("Sypialnia");
            WriteLine(lr1 + "\n");
            string text = System.IO.File.ReadAllText("Sypialnia.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            mcm.Sypialniav2();
        }
        public void SearchingBedroom()
        {
            string text = System.IO.File.ReadAllText("SearchBedroom.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            mcm.VHOut();
        }
        public void LockPicking()
        {
            Archivments.A4();
            Animations.FramesAnimation(Images.lockpicking, 4, 100);
            Clear();
            Animations.FramesAnimation(Images.locks, 1, 100);
            Clear();
            string text = System.IO.File.ReadAllText("Lock.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            mcm.Death1();
        }
        public void Guard()
        {
            SecurityGuard sg = new SecurityGuard(24, "Mężczyzna", "idk", "Ochroniaż", "John", "Lawrence", "Podporucznik");
            WriteLine(sg);
            string text = System.IO.File.ReadAllText("Guard.txt");
            Animations.TextAnimation(text, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            string text2 = System.IO.File.ReadAllText("Sekcja.txt");
            Animations.TextAnimation(text2, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            string text1 = System.IO.File.ReadAllText("Guard2.txt");
            Animations.TextAnimation(text1, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            mcm.Miasteczko();
        }
        public void Szyfrowanie()
        {
            Archivments.A7();
            string text = System.IO.File.ReadAllText("Szyfr.txt");
            Animations.TextAnimation(text, 5);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            foreach (string a in List.lista1)
                WriteLine(a);
            WriteLine("\n" + a);
            ReadKey();
            string text1 = System.IO.File.ReadAllText("Hmmm.txt");
            Animations.TextAnimation(text1, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            PlacSearch();
        }
        public void PlacSearch()
        {
            Archivments.A3();
            string text = System.IO.File.ReadAllText("SearchPlac.txt");
            Animations.TextAnimation(text, 20);
            Opcja1 op1 = new Opcja1();
            Znalezione z1 = new Znalezione(op1);
            WriteLine(z1.Uzyte(DzienTygodnia.Wtorek));
            string text2 = System.IO.File.ReadAllText("SearchPlac2.txt");
            Animations.TextAnimation(text2, 20);
            WriteLine("\n" + a);
            ReadKey();
            Clear();
            MultipleChoiceMenu mcm = new MultipleChoiceMenu();
            mcm.Miasteczko();
        }
    }
}
