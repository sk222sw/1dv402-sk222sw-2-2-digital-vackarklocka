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

            AlarmClock time5 = new AlarmClock(6, 12, 6, 15);
            Console.WriteLine("Test 5.");
            Console.WriteLine("Ställer klockan till 23:58 och låter den gå 13 minuter. \n");
            Run(time5, 6);
            Console.WriteLine("\n{0}\n", horizontalLine);


            Console.WriteLine("Test 6.");
            Console.WriteLine("Testar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden. \n");
            try
            {
                time5.Hour = -1;
            }
            catch (ArgumentException test6)
            {
                ViewErrorMessage(test6.Message);
            }
            try
            {
                time5.Minute = -1;
            }
            catch (ArgumentException test6)
            {
                ViewErrorMessage(test6.Message);
            }
            try
            {
                time5.AlarmHour = -1;
            }
            catch (ArgumentException test6)
            {
                ViewErrorMessage(test6.Message);
            }
            try
            {
                time5.AlarmMinute = -1;
            }
            catch (ArgumentException test6)
            {
                ViewErrorMessage(test6.Message);
            }
            Console.WriteLine("\n{0}\n", horizontalLine);

            Console.WriteLine("Test 7.");
            Console.WriteLine("Testar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden. \n");
            try
            {
                AlarmClock time7 = new AlarmClock(-1, -2);
            }
            catch (ArgumentException test7)
            {
                ViewErrorMessage(test7.Message);
            }
            try
            {
                AlarmClock time7 = new AlarmClock(-1, -2, -5, 4564);
            }
            catch (ArgumentException test7)
            {
                ViewErrorMessage(test7.Message);
            }
        }

        private static void Run(AlarmClock time, int minutes)
        {
            //Två parametrar. 1 - referens till AlarmClock-objekt
            //                2 - Antalet minuter som AlarmClock-objektet ska gå.
            //                      genom att låta ett AlarmClock-objekt göra upprepade anrop av metoden TickTock()

            for (int i = 0; i < minutes; i++)
            {


                if (time.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0} BEEP BEEP", time);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(time);
                }
            }
            
            
            //Console.WriteLine(time.ToString());
        }

        private static void ViewErrorMessage(string message)
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader()
        { }
    }
}
