using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Drawing;

namespace Menu
{
    class IRozmowa
    {
        public static void Rozmowa()
        {
            Console.Clear();
            Console.Write("dryń dryń..."); System.Threading.Thread.Sleep(1000); Console.Write("..."); System.Threading.Thread.Sleep(2000); Console.Write("..."); System.Threading.Thread.Sleep(2000); Console.Write("...");

            Console.WriteLine("\t");
            Console.WriteLine("K: Halo, gdzie się dodzwoniłem?...", Color.Green);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Witamy w Pizzeri pod Winem", Color.Yellow);
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("K: O! świetnie, organizujemy impreze informatyków...", Color.Green);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("K: Brakło nam jedzenia... przez co nie możemy programować...", Color.Green);
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("W naszym menu na pewno znajdzie kazdy coś dla siebie.", Color.Yellow);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Proszę wybrać jedną z poniższych opcji:", Color.Yellow);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("[1] - Pizza Śląska");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("[2] - Pizza Margaritha");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("[3] - Pizza Z Jajem");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("[4] - Pizza Boczek");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("[5] - Pizza góralska");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("[6] - Pizza Calzone");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Lub skomponować własną pizze wybierając: ");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("[7] - Pizza własna");
            Console.ReadLine();

        }

    }
}
