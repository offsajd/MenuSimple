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
    interface ILogo
    {
        public static void WriteLogo()
        {
            string logo = @" 
  ===================================
||         PIZZERIA NAD WINEM        ||
||       _____________________       ||
||           _----  _----            ||
||          |     ||     |           ||
||          |_----||_----|           ||
||           _----  _----            ||
||          |     ||     |           ||
||          |_----||_----|           ||
||            WINO & VISTA           ||
||        _____________________      ||
||   Ulubiona Pizzeria Programistów  ||
||            Według Magdy G.        ||
||                                   ||
  =================================== ";
            Console.WriteLine(logo, Color.Cyan);
        }

    }
}
