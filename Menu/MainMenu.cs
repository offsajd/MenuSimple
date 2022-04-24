using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System;

namespace Menu
{
    class MainMenu : ILogo
    {
        public static void Menu()
        {
            for (; ; )
            {
                Console.Clear();
                ILogo.WriteLogo();
                Say("1", "- MENU naszej pizzeri ");
                Say("2", "- Stwórz własną pizze");
                Say("3", "- Program lojalnościowy");
                Say("4", "- Kontakt z nami");
                Say("5", "- Kupony rabatowe dla stałych klientów");
                Say("6", "- Zamówienie Pizzy");
                Say("7", "- Wyjdź");

                string option = Console.ReadLine();
                if (option == "1")
                {
                    MenuPizza.menuPizza();
                }
                else if (option == "2")
                {

                }
                else if (option == "3")
                {

                }
                else if (option == "4")
                {
                    OpenUrl("https://www.youtube.com/watch?v=qk1nnAHI1mI");
                    Console.Clear();
                    ILogo.WriteLogo();
                    Console.WriteLine("otworzono link ");
                    Console.WriteLine(" aby kontynuować naciśnij dowolny klawisz");
                    Console.ReadKey(true);
                }
                else if (option == "5")
                {

                }
                else if (option == "6")
                {

                }
                else if (option == "7")
                {
                    Console.Beep(120, 1020);
                    Environment.Exit(0);

                }
                else
                {
                    System.Console.WriteLine("    Błąd   !!! wybierz poprawną opcje !!!", Color.Red);
                    Thread.Sleep(2000);
                }

            }






        }
        public static void OpenUrl(string url)
        {
            if (!url.Contains("://")) url = "https://" + url;
            {
                Process.Start("przeglądarka", url);
            }

        }
        public static void Say(string prefix, string message)
        {
            Console.Write("[");
            Console.Write(prefix, Color.Gold);
            Console.WriteLine("]" + message);
        }

//        public static void WriteLogo()
//        {
//            string logo = @" 
//  ===================================
//||         PIZZERIA NAD WINEM        ||
//||       _____________________       ||
//||           _----  _----            ||
//||          |     ||     |           ||
//||          |_----||_----|           ||
//||           _----  _----            ||
//||          |     ||     |           ||
//||          |_----||_----|           ||
//||            WINO & VISTA           ||
//||        _____________________      ||
//||   Ulubiona Pizzeria Programistów  ||
//||            Według Magdy G.        ||
//||                                   ||
//  =================================== ";
//            Console.WriteLine( logo, Color.Cyan );
//        }
    }
}
