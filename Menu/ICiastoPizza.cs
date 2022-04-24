using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Drawing;

namespace Menu
{
    interface ICiastoPizza
    {

        public static void WriteCiastoPizza()
        {
            string ser = @"Ciasto do pizzy ";
            Console.WriteLine(ser, Color.White);
        }
        public int cenaciasto() => 15;
        
    }
}
