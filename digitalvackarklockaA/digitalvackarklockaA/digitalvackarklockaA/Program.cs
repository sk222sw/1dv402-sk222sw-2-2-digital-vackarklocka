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
            string horizontalLine;      //Skapar en sträng som används med metoden ViewTestHeader.

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║           Väckarklockan              ║ ");
            Console.WriteLine(" ║        BEEP BEEP BEEP BEEP           ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine();

            //Testfest:

            //Test 1:
            AlarmClock time = new AlarmClock();
            horizontalLine = "\n════════════════════════════════════════\n\nTest 1.\nTest av standardkonstruktorn.";
            ViewTestHeader(horizontalLine);
            Console.WriteLine("\n{0}\n", time);

            //Test 2:
            AlarmClock time2 = new AlarmClock(9, 42);
            horizontalLine = "\n════════════════════════════════════════\n\nTest 2.\nTest av konstruktorn med två parametrar, <9, 42>.";
            ViewTestHeader(horizontalLine);
            Console.WriteLine("\n{0}\n", time2);

            //Test 3:
            AlarmClock time3 = new AlarmClock(13, 24, 7, 35);
            horizontalLine = "\n════════════════════════════════════════\n\nTest 3.\nTest av konstruktorn med fyra parametrar, <13, 24, 7, 35>.";
            ViewTestHeader(horizontalLine);
            Console.WriteLine("\n{0}\n", time3);

            //Test 4:
            AlarmClock time4 = new AlarmClock(23, 58, 7, 35);
            horizontalLine = "\n════════════════════════════════════════\n\nTest 4.\nTest av konstruktorn med fyra parametrar, <23, 58, 7, 35>.\n";
            ViewTestHeader(horizontalLine);
            Run(time4, 13);

            //Test 5:
            AlarmClock time5 = new AlarmClock(6, 12, 6, 15);
            horizontalLine = "\n════════════════════════════════════════\n\nTest 5.\nTest av konstruktorn med fyra parametrar, <6, 12, 6, 15>.\n";
            ViewTestHeader(horizontalLine);
            Run(time5, 6);

            //Test 6:
            horizontalLine = "\n════════════════════════════════════════\n\nTest 6.\nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.\n";
            ViewTestHeader(horizontalLine);
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

            //Test 7:
            horizontalLine = "\n════════════════════════════════════════\n\nTest 7.\nTestar konstruktorerna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.\n";
            ViewTestHeader(horizontalLine);
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

        private static void Run(AlarmClock time, int minutes)       //Kör klockan och skriver ut tiden och eventuellt drar igång alarmet. 
        {
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

        private static void ViewErrorMessage(string message)        //Hämtar felmeddelanden från egenskaperna i AlarmClock.cs
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string message)      //Används för att skriva ut meddelanden under testkörningen.
        { 
            Console.WriteLine(message);
        }
    }
}
