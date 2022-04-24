using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;
using System.Drawing;

namespace Menu
{
    interface ISosPomidorowy
    {
        public static void WritePomidorowy()
        {
            string pomidorowy = @"sos pomidorowy";
            Console.WriteLine(pomidorowy, Color.Cyan);
        }


    }
}
