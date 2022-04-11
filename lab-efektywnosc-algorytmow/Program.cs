using System;
using static lab_efektywnosc_algorytmow.SortingAlgorithms;

namespace lab_efektywnosc_algorytmow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("IS");
            //INSERTION SORT
            int[] arr = { 12, 11, 13, 5, 6 };
            SortingAlgorithms.InsertionSort ob = new InsertionSort();
            ob.sort(arr);
            ob.printArray(arr);


            Console.WriteLine();
            Console.WriteLine("MS");
            // MERGE SORT
            int[] arr2 = { 12, 11, 13, 5, 6, 7 };
            SortingAlgorithms.MergeSort om = new MergeSort();
            om.sort(arr2, 0, arr2.Length - 1);
            om.printArray(arr2);


            Console.WriteLine();
            Console.WriteLine("QS");
            //QUICKSORT
            int[] arr3 = { 10, 7, 8, 9, 1, 5 };
            SortingAlgorithms.QuickSort oq = new QuickSort();
            int n = arr3.Length;
            oq.quickSort(arr3, 0, n - 1);
            oq.printArray(arr3, n);


            Console.WriteLine();
            Console.WriteLine("AS");
            //ARRAYSORT
            int[] intArray = new int[5] { 8, 10, 2, 6, 3 };
            SortingAlgorithms.ArraySort asq = new ArraySort();
            asq.sort(intArray);
            asq.printArray(intArray);

        }
    }
}
