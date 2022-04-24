using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Drawing;

namespace Menu
{
    interface ISzynka
    {

        public static void WriteSzynka()
        {
            string szynka = @"szynka";
            Console.WriteLine(szynka, Color.Red);
        }
    }
}
