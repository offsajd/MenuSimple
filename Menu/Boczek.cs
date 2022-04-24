using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Drawing;
using System.Threading;

namespace Menu
{
    class Boczek : ISosPomidorowy, ISer, ISzynka, ICiastoPizza
    {

        public static void boczek()
        {
            Console.Clear();

            int koszt = 21;

            ICiastoPizza.WriteCiastoPizza();
            ISosPomidorowy.WritePomidorowy();
            ISer.WriteSer();
            ISzynka.WriteSzynka();

            System.Console.WriteLine("\t");

            System.Console.WriteLine("koszt pizzy to: {0} zł", koszt);

            System.Console.WriteLine("\t");
            System.Console.WriteLine("\t");

            Console.Write("Niebieskie\n", Color.Cyan);
            System.Console.WriteLine("Bez przeciwskazan żywnościowych");
            System.Console.WriteLine("\t");
            Console.Write("Żółte\n", Color.Yellow);
            System.Console.WriteLine("Nie dla wegan");
            System.Console.WriteLine("\t");
            Console.Write("Czerwone\n", Color.Red);
            System.Console.WriteLine("Nie dla wegan i wegetarian");
            System.Console.WriteLine("\t");
            Console.ReadLine();
            Thread.Sleep(2000);



        }


    }

}
