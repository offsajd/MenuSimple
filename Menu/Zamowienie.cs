using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Console = Colorful.Console;
using System.Drawing;

namespace Menu
{
    class Zamowienie : IRozmowa1
    {
        public static void GetZamowienie()
        {
            Console.Clear();
            IRozmowa1.Rozmowa();
            Thread.Sleep(1000);
            Say3("1", "- złóż zamówienie ");
            Say3("2", "- anuluj");

            string option = Console.ReadLine();
            if (option == "1")
            {
                Console.WriteLine("jeszcze tego nie przerobiiłem");
            }
            else if (option == "2")
            {
                MainMenu.Menu();
            }
            else
            {
                Console.WriteLine("    Błąd   !!! wybierz poprawną opcje !!!", Color.Red);
                Thread.Sleep(2000);
            }
        }
        public static void Say3(string prefix, string message)
        {
            Console.Write("[");
            Console.Write(prefix, Color.Green);
            Console.WriteLine("]" + message);
        }
    }
    
}
