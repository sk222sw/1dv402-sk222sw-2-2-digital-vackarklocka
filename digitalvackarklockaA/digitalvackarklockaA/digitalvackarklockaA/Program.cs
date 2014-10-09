using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalvackarklockaA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instansiera objekt av klassen AlarmClock - 
            //testa konstruktorerna, egenskaperna och metoderna.
            string horizontalLine = "════════════════════════════════════════════════════════════════════════════";

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║           Väckarklockan              ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine();

            //Testfest

            AlarmClock time = new AlarmClock();
            Console.WriteLine("Test 1.");
            Console.WriteLine("Test av standardkonstruktorn.\n");
            Console.WriteLine(time);
            Console.WriteLine("\n{0}\n", horizontalLine);


            AlarmClock time2 = new AlarmClock(9, 42);
            Console.WriteLine("Test 2.");
            Console.WriteLine("Test av konstruktorn med två parametrar, <9, 42>.\n");
            Console.WriteLine(time2);
            Console.WriteLine("\n{0}\n", horizontalLine);


            AlarmClock time3 = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine("Test 3.");
            Console.WriteLine("Test av konstruktorn med fyra parametrar, <13, 24, 7, 35>.\n");
            Console.WriteLine(time3);
            Console.WriteLine("\n{0}\n", horizontalLine);

            AlarmClock time4 = new AlarmClock(23, 58, 7, 35);
            Console.WriteLine("Test 4.");
            Console.WriteLine("Ställer klockan till 23:58 och låter den gå 13 minuter. \n");
            Run(time4, 13);
            Console.WriteLine("\n{0}\n", horizontalLine);
        }

        private static void Run(AlarmClock time, int minutes)
        {
            //Två parametrar. 1 - referens till AlarmClock-objekt
            //                2 - Antalet minuter som AlarmClock-objektet ska gå.
            //                      genom att låta ett AlarmClock-objekt göra upprepade anrop av metoden TickTock()

            for (int i = 0; i < minutes; i++)
            {
                Console.WriteLine(time);
                time.TickTock();
            }
            

            //Console.WriteLine(time.ToString());
        }

        private static void ViewErrorMessage()
        { 
            //Skriver ut felmeddelanden
        }

        private static void ViewTestHeader()
        { }
    }
}
