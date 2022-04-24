using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Drawing;

namespace Menu
{
    interface ISer
    {

        public static void WriteSer()
        {
            string ser = @"ser ";
            Console.WriteLine(ser, Color.Yellow);
        }
       
    }
}
