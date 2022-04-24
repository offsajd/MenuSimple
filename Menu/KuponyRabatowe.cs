using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class KuponyRabatowe
    {
        public static void getKupony()
        {
            Console.Clear();
            Console.WriteLine("Jezeli tu zajrzałeś pewnie jesteś nowym klientem.");
            Console.WriteLine("\t");
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("aktualne promocje dla klientów:");
            Console.WriteLine("Dla nowo zarejestrowanych -10% do każdego zamówienia");
            Console.WriteLine("Dla obecznych klientów -10% + duży napój Kofola 2l. Gratis!");

            Console.WriteLine("\t");
            Console.WriteLine("_____________________________________________");
            Console.ReadLine();
        }
    }
}
