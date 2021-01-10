using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NarutoEP
{
    class Misc
    {
        public static int num1;
        public static void text(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n#>");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" " + text);
        }
        public static void appName()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("naruto");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(".smart");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("]");

        }
        public static void option(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n#");
            Console.ForegroundColor = ConsoleColor.White;
            num1++;
            Console.Write(num1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" "+text);
        }
        public static void reset()
        {
            num1 = 0;
        }
        public static void tAnimation(string text , int speed = 40)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n#>");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
        }



    }
}
