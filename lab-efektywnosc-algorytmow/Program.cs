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
            var main = new Main();
            main.getAttempt(1, 10, 0, 100);

        }

        public void printTime(Stopwatch stopWatch)
        {
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
