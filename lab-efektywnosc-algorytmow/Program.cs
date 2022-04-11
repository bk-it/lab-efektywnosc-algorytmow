using System;
using System.Diagnostics;
using System.Threading;
using static lab_efektywnosc_algorytmow.SortingAlgorithms;

namespace lab_efektywnosc_algorytmow
{
    internal class Progeneratoram
    {
        static void Main(string[] args)
        {
            var master = new Master();

            Console.WriteLine("Przypadek 1: próba mała (n = 10), random");
            master.getAttempt(1, 10, 0, 100);

            Console.WriteLine("Przypadek 2: próba mała (n = 10), sorted");
            master.getAttempt(2, 10, 0, 100);

            Console.WriteLine("Przypadek 3: próba mała (n = 10), reversed");
            master.getAttempt(3, 10, 0, 100);

            Console.WriteLine("Przypadek 4: próba mała (n = 10), almost sorted");
            master.getAttempt(4, 10, 0, 100, 2);

            Console.WriteLine("Przypadek 5: próba mała (n = 10), few unique");
            master.getAttempt(5, 10);

            Console.WriteLine("Przypadek 6: próba średnia (n = 1000), random");
            master.getAttempt(1, 1000, 0, 1000);

            Console.WriteLine("Przypadek 7: próba średnia (n = 1000), sorted");
            master.getAttempt(2, 1000, 0, 1000);

            Console.WriteLine("Przypadek 8: próba średnia (n = 1000), reversed");
            master.getAttempt(3, 1000, 0, 1000);

            Console.WriteLine("Przypadek 9: próba średnia (n = 1000), almost sorted");
            master.getAttempt(4, 1000, 0, 1000, 30);

            Console.WriteLine("Przypadek 10: próba średnia (n = 1000), few unique");
            master.getAttempt(5, 1000);

            Console.WriteLine("Przypadek 11: próba duża (n = 100000), random");
            master.getAttempt(1, 100000, 0, 1000);

            Console.WriteLine("Przypadek 12: próba duża (n = 100000), sorted");
            master.getAttempt(2, 100000, 0, 1000);

            Console.WriteLine("Przypadek 13: próba duża (n = 100000), reversed");
            master.getAttempt(3, 100000, 0, 1000);

            Console.WriteLine("Przypadek 14: próba duża (n = 100000), almost sorted");
            master.getAttempt(4, 100000, 0, 1000, 50);

            Console.WriteLine("Przypadek 15: próba duża (n = 100000), few unique");
            master.getAttempt(5, 100000);
        }

    }
}
