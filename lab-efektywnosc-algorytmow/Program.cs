using System;
using static lab_efektywnosc_algorytmow.SortingAlgorithms;

namespace lab_efektywnosc_algorytmow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INSERTION SORT
            int[] arr = { 12, 11, 13, 5, 6 };
            SortingAlgorithms.InsertionSort ob = new InsertionSort();
            ob.sort(arr);
            ob.printArray(arr);

            // MERGE SORT
            int[] arr2 = { 12, 11, 13, 5, 6, 7 };
            SortingAlgorithms.MergeSort om = new MergeSort();
            Console.WriteLine("Given Array");
            om.printArray(arr2);
            om.sort(arr2, 0, arr2.Length - 1);
            Console.WriteLine("\nSorted array");
            om.printArray(arr2);


            Console.WriteLine();
            Console.WriteLine("QS");
            //QUICKSORT
            int[] arr3 = { 10, 7, 8, 9, 1, 5 };
            SortingAlgorithms.QuickSort oq = new QuickSort();
            int n = arr3.Length;
            oq.quickSort(arr3, 0, n - 1);
            Console.Write("Sorted array: \n");
            oq.printArray(arr3, n);

        }
    }
}
