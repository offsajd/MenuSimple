using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Start";
            ILogo.WriteLogo();
            Console.WriteLine("      Witamy w naszej Pizzeri");
            Console.ReadKey(true);
            MainMenu.Menu();

        }
    }
}
