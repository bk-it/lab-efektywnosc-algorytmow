using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using static lab_efektywnosc_algorytmow.SortingAlgorithms;

namespace lab_efektywnosc_algorytmow
{
    internal class Master
    {
        Stopwatch stopWatch = new Stopwatch();
        Generators generator = new Generators();
        SortingAlgorithms.InsertionSort IS = new InsertionSort();
        SortingAlgorithms.MergeSort MS = new MergeSort();
        SortingAlgorithms.QuickSort QS = new QuickSort();
        SortingAlgorithms.ArraySort AS = new ArraySort();

        public void getAttempt(int type, int size, int minVal = 0, int maxVal = 0, int almost = 0)
        {
            int[] a = new int[size];

            TimeSpan[] timeIS = new TimeSpan[10];
            TimeSpan[] timeMS = new TimeSpan[10];
            TimeSpan[] timeQS = new TimeSpan[10];
            TimeSpan[] timeAS = new TimeSpan[10];

            TimeSpan timeISavg = new TimeSpan();
            TimeSpan timeQSavg = new TimeSpan();
            TimeSpan timeMSavg = new TimeSpan();
            TimeSpan timeASavg = new TimeSpan();

            switch (type)
            {
                case 1:
                    a = generator.GenerateRandom(size, minVal, maxVal);
                    break;
                case 2:
                    a = generator.GenerateSorted(size, minVal, maxVal);
                    break;
                case 3:
                    a = generator.GenerateReversed(size, minVal, maxVal);
                    break;
                case 4:
                    a = generator.GenerateAlmost(size, minVal, maxVal, almost);
                    break;
                case 5:
                    a = generator.GenerateFewUnique(size);
                    break;
            }

            for (int f = 0; f < 4; f++)
            {
                for (int i = 0; i < 10; i++)
                {
                    int[] a1 = (int[])a.Clone();
                    stopWatch.Start();
                    if(f == 0) { IS.sort(a1); }
                    if (f == 1) { MS.sort(a1, 0, a1.Length - 1); }
                    if (f == 2) { QS.sort(a1, 0, a1.Length - 1); }
                    if (f == 3) { AS.sort(a1); }
                    stopWatch.Stop();
                    if (f == 0) { timeIS[i] = stopWatch.Elapsed; }
                    if (f == 1) { timeMS[i] = stopWatch.Elapsed; }
                    if (f == 2) { timeQS[i] = stopWatch.Elapsed; }
                    if (f == 3) { timeAS[i] = stopWatch.Elapsed; }
                }

                for(int x = 0; x < 10; x++)
                {
                    if (f == 0) { timeISavg = timeISavg.Add(timeIS[x]); }
                    if (f == 1) { timeMSavg = timeMSavg.Add(timeMS[x]); }
                    if (f == 2) { timeQSavg = timeQSavg.Add(timeQS[x]); }
                    if (f == 3) { timeASavg = timeASavg.Add(timeAS[x]); }
                }

            }

            timeISavg = timeISavg / 10;
            timeMSavg = timeMSavg / 10;
            timeQSavg = timeQSavg / 10;
            timeASavg = timeASavg / 10;


            Console.WriteLine("InsertionSort: t = " + timeISavg.TotalMilliseconds.ToString() + " +/- " + arrDeviation(timeIS).ToString());
            
            Console.WriteLine("MergeSort: t = " + timeMSavg.TotalMilliseconds.ToString() + " +/- " + arrDeviation(timeMS).ToString());
            
            Console.WriteLine("QuickSort: t = " + timeQSavg.TotalMilliseconds.ToString() + " +/- " + arrDeviation(timeQS).ToString());
            
            Console.WriteLine("ArraySort: t = " + timeASavg.TotalMilliseconds.ToString() + " +/- " + arrDeviation(timeAS).ToString());

            Console.WriteLine();
        }

        private double arrDeviation(TimeSpan[] t)
        {
            List<double> intList = new List<double> { };
            for (int i = 0; i < t.Length; i++)
            {
                intList.Add(Convert.ToDouble(t[i].TotalMilliseconds));
            }

            double average = intList.Average();
            double sumOfDerivation = 0;
            foreach (double value in intList)
            {
                sumOfDerivation += (value) * (value);
            }
            double sumOfDerivationAverage = sumOfDerivation / (intList.Count - 1);
            double deviation = Math.Sqrt(sumOfDerivationAverage - (average * average));
            return Math.Round(deviation, 6);
        }
    }
}
