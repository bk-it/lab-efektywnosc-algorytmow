using System;
using System.Collections.Generic;
using System.Text;

namespace lab_efektywnosc_algorytmow
{
    public class Generators
    {
        public int[] GenerateRandom(int size, int minVal, int maxVal)
        {
            var rand = new Random();
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = rand.Next(minVal, maxVal);
            }
            return a;
        }

        public int[] GenerateSorted(int size, int minVal, int maxVal)
        {
            int[] a = GenerateRandom(size, minVal, maxVal);
            Array.Sort(a);
            return a;
        }

        public int[] GenerateReversed(int size, int minVal, int maxVal)
        {
            int[] a = GenerateSorted(size, minVal, maxVal);
            Array.Reverse(a);
            return a;
        }

    }
}
