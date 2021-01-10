using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NarutoEP
{
    class FillerCheck
    {
        public static void newT(string text)
        {


            Misc.text("");
            string Mixed = text;
            char[] cMixed = Mixed.ToArray();
            foreach (char c in cMixed)
            {
                if (c == '1')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '2')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '3')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '4')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '5')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '6')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '7')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '8')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '9')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '0')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(c);
                }
            }
        }
        public static void nenwFiller(string text)
        {
            Misc.text("");
            string t = text;
            char[] cMixed = t.ToArray();
            foreach (char c in cMixed)
            {
                if (c == '1')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '2')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '3')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '4')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '5')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '6')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '7')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '8')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '9')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == '0')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
                else if (c == 'F')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(c);
                }
                else if (c == 'l')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(c);
                }
                else if (c == 'e')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(c);
                }
                else if (c == 'r')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(c);
                }
                else if (c == 'i')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(c);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(c);
                }
            }
        }
        public static void NetflixSeasonCheck()
        {
            Console.Clear();
            Misc.appName();
            Misc.text("Please enter your season...");
            Misc.reset();
            Console.WriteLine();
            Misc.option("");
            Misc.option("");
            Misc.option("");
            Misc.option("");
            Misc.option("");
            Misc.option("");
            Misc.option("");
            Misc.option("");
            Misc.option("");
            Console.WriteLine();
            Misc.text("Enter a number : ");
            var answer = Console.ReadLine();
            if (answer.Length == 1)
            {
                if (answer == "1")
                {
                    Console.Clear();
                    Misc.appName();
                    Console.WriteLine();
                    Misc.text("Season One");
                    Console.WriteLine();
                    FillerCheck.newT("Mixed Canon/Filler Episodes:  7 ,  9 ,  14-16 , 18-21 , 23-24");
                    FillerCheck.nenwFiller("Filler Ep: None");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("26");
                    Console.WriteLine();
                    Misc.text("Press any key to check other seasons...");
                    Console.ReadKey();
                    NetflixSeasonCheck();
                }
                else if (answer == "2")
                {
                    Console.Clear();
                    Misc.appName();
                    Console.WriteLine();
                    Misc.text("Season Two");
                    Console.WriteLine();
                    FillerCheck.newT("Mixed Canon/Filler Episodes: 1-4 ,  11-15 , 17-21 , 23 , 26 ");
                    FillerCheck.nenwFiller("Filler Ep: None");
                    Console.WriteLine();
                    Misc.text("Press any key to check other seasons...");
                    Console.ReadKey();
                    NetflixSeasonCheck();
                }
                else if (answer == "3")
                {
                    Console.Clear();
                    Misc.appName();
                    Console.WriteLine();
                    Misc.text("Season Three");
                    Console.WriteLine();
                    FillerCheck.newT("Mixed Canon/Filler Episodes: 1-8 , 11 , 14, 17-20");
                    FillerCheck.nenwFiller("Filler Ep: None");
                    Console.WriteLine();
                    Misc.text("Press any key to check other seasons...");
                    Console.ReadKey();
                    NetflixSeasonCheck();
                }
                else if (answer == "4")
                {
                    Console.Clear();
                    Misc.appName();
                    Console.WriteLine();
                    Misc.text("Season Four");
                    Console.WriteLine();
                    FillerCheck.newT("Mixed Canon/Filler Episodes: 3 , 18-20 , 14, 17-20");
                    FillerCheck.nenwFiller("Filler Ep : 17 , 21-26");
                    Console.WriteLine();
                    Misc.text("Press any key to check other seasons...");
                    Console.ReadKey();
                    NetflixSeasonCheck();
                }
                else if (answer == "5")
                {
                    Console.Clear();
                    Misc.appName();
                    Console.WriteLine();
                    Misc.text("Season Five");
                    Console.WriteLine();
                    FillerCheck.newT("Mixed Canon/Filler Episodes: 1-8 , 11 , 14, 17-20");
                    FillerCheck.nenwFiller("Filler Ep: None");
                    Console.WriteLine();
                    Misc.text("Press any key to check other seasons...");
                    Console.ReadKey();
                    NetflixSeasonCheck();
                }
                else if (answer == "6")
                {
                    Console.Clear();
                    Misc.appName();
                    Console.WriteLine();
                    Misc.text("Season Six");
                    Console.WriteLine();
                    FillerCheck.newT("Mixed Canon/Filler Episodes: 6-7");
                    FillerCheck.nenwFiller("Filler Ep: 1-4 , 8-25");
                    Console.WriteLine();
                    Misc.text("Press any key to check other seasons...");
                    Console.ReadKey();
                    NetflixSeasonCheck();
                }
                else if (answer == "7")
                {
                    Console.Clear();
                    Misc.appName();
                    Console.WriteLine();
                    Misc.text("Season Seven");
                    Console.WriteLine();
                    FillerCheck.newT("Mixed Canon/Filler Episodes: None");
                    FillerCheck.nenwFiller("Filler Ep: 1-26 ");
                    Console.WriteLine();
                    Misc.text("Press any key to check other seasons...");
                    Console.ReadKey();
                    NetflixSeasonCheck();
                }
                else if (answer == "8")
                {
                    Console.Clear();
                    Misc.appName();
                    Console.WriteLine();
                    Misc.text("Season Eight");
                    Console.WriteLine();
                    FillerCheck.newT("Mixed Canon/Filler Episodes: None");
                    FillerCheck.nenwFiller("Filler Ep: 1-26 ");
                    Console.WriteLine();
                    Misc.text("Press any key to check other seasons...");
                    Console.ReadKey();
                    NetflixSeasonCheck();
                }
                else
                {
                    Console.Clear();
                    Misc.appName();
                    Console.WriteLine();
                    Misc.text("Season Nine");
                    Console.WriteLine();
                    FillerCheck.newT("Mixed Canon/Filler Episodes: 8");
                    FillerCheck.nenwFiller("Filler Ep: 1-7 ");
                    Console.WriteLine();
                    Misc.text("Press any key to check other seasons...");
                    Console.ReadKey();
                    NetflixSeasonCheck();
                }
            }
            else
            {
                Misc.text("Sorry Couldn't find that season , going back in 5 seconds");
                Thread.Sleep(5000);
                NetflixSeasonCheck();
            }


        }
        public static void RegularNar()
        {
            Console.Clear();
            Misc.appName();
            Console.WriteLine();
            FillerCheck.newT("Mixed Canon/Filler Episodes: Episodes 7, 9, 14-16, 18-21, 23-24, 27-30, 37-41, 43-47, 49, 52-60, 63, 66, 69-72, 74, 83, 98-100, 112-114, 126-127, 130-131, 141-142, 220");
            Console.WriteLine();
            FillerCheck.newT("Filler Episodes: Episodes 26, 97, 101-106, 136-140, 143-219");
            Console.WriteLine();
            Misc.text("Press any key to check again...");
            Console.ReadKey();
            RegularNar();
        }
    }
}
