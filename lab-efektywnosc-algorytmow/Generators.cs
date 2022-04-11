using System;
using System.Collections.Generic;
using System.Text;

namespace lab_efektywnosc_algorytmow
{
    public class Generators
    {
        Random rand = new Random();
        public int[] GenerateRandom(int size, int minVal, int maxVal)
        {
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

        public int[] GenerateAlmost(int size, int minVal, int maxVal, int reversePairs)
        {
            int[] a = GenerateSorted(size, minVal, maxVal);

            for (int i = 0; i < reversePairs; i++)
            {
                int x = rand.Next(0, size);
                int y = rand.Next(0, size);
                int xbefore = a[x];
                int ybefore = a[y];
                a[x] = ybefore;
                a[y] = xbefore;
            }

            return a;
        }

        public int[] GenerateFewUnique(int size)
        {
            int maxVal = size / 10;
            int[] a = GenerateRandom(size, 0, maxVal);
            return a;
        }
    }
}
