using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;
using System.Drawing;
using System.Threading;
using System.Diagnostics;

namespace Menu
{
    class MenuPizza: MainMenu
    {
        public static void menuPizza()
        {
            for (; ; )
            {
                Console.Clear();
                WriteLogoPizza();
                Say2("1", "- Margaritha ");
                Say2("2", "- Boczek");
                Say2("3", "- Calzone");
                Say2("4", "- Goralska");
                Say2("5", "- Slaska");
                Say2("6", "- Z jajem");
                Say2("7", "- Własna");
                Say2("8", "- powrót do menu głównego");

                string option = Console.ReadLine();
                if (option == "1")
                {
                    Margaritha.margaritha();
                }
                else if (option == "2")
                {
                    Boczek.boczek();
                }
                else if (option == "3")
                {
                    Calzone.calzone();
                }
                else if (option == "4")
                {
                    Goralska.goralska();
                }
                else if (option == "5")
                {
                    Slaska.slaska();
                }
                else if (option == "6")
                {
                    Zjajem.zjajem();
                }
                else if (option == "7")
                {

                }
                else if (option == "8")
                {
                    MainMenu.Menu();

                }
                else
                {
                    Console.WriteLine("    Błąd   !!! wybierz poprawną opcje !!!", Color.Red);
                    Thread.Sleep(2000);
                }

            }
        }
        

        public static void Say2(string prefix, string message)
        {
            Console.Write("[");
            Console.Write(prefix, Color.Cyan);
            Console.WriteLine("]" + message);
        }


        public static void WriteLogoPizza()
        {

        }
    }
}
