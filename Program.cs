using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NarutoEP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            First();
            void First()
            {
                Console.Title = "Naruto :))))))";
                Misc.appName();
                Misc.tAnimation(" Please press a key...");
                Console.WriteLine("");
                Misc.option("Netflix Filler Episodes");
                Misc.option("Other Filler Episodes (Episodes 1 - 400)");
                var keyPressed = Console.ReadKey();
                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                        FillerCheck.NetflixSeasonCheck();
                        break;
                    case ConsoleKey.D2:
                        FillerCheck.RegularNar();
                        break;

                }
                if (keyPressed.Key != ConsoleKey.D1 && keyPressed.Key != ConsoleKey.D2)
                {
                    Console.Clear();
                    Misc.appName();
                    Misc.text("Wrong key try again in 5 sec");
                    Thread.Sleep(5000);
                    First();
                }
            }


        }

    }
}
