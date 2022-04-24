using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Drawing;

namespace Menu
{
    class Zjajem : ISosPomidorowy, ISer, ISzynka, ICiastoPizza
    {

        public static void zjajem()
        {
            Console.Clear();

            double koszt = 31.90;

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
        }


    }

}
