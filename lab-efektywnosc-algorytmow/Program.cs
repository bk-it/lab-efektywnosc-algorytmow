using System;
using static lab_efektywnosc_algorytmow.SortingAlgorithms;

namespace lab_efektywnosc_algorytmow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gr = new Generators();
            SortingAlgorithms.InsertionSort ob = new InsertionSort();
            SortingAlgorithms.MergeSort om = new MergeSort();
            SortingAlgorithms.QuickSort oq = new QuickSort();
            SortingAlgorithms.ArraySort asq = new ArraySort();

            Console.WriteLine();
            Console.WriteLine("IS");
            //INSERTION SORT
            int[] arr = gr.GenerateRandom(20, 1, 30);
            ob.sort(arr);
            ob.printArray(arr);


            Console.WriteLine();
            Console.WriteLine("MS");
            // MERGE SORT
            int[] arr2 = gr.GenerateRandom(20, 1, 30);
            om.sort(arr2, 0, arr2.Length - 1);
            om.printArray(arr2);


            Console.WriteLine();
            Console.WriteLine("QS");
            //QUICKSORT
            int[] arr3 = gr.GenerateRandom(20, 1, 30);
            int n = arr3.Length;
            oq.quickSort(arr3, 0, n - 1);
            oq.printArray(arr3, n);


            Console.WriteLine();
            Console.WriteLine("AS");
            //ARRAYSORT
            int[] intArray = gr.GenerateRandom(20, 1, 30);
            asq.sort(intArray);
            asq.printArray(intArray);


            Console.WriteLine();
            Console.WriteLine("RANDOM");
            //RANDOM
            
            var arrgiv = gr.GenerateReversed(50, 1, 30);
            foreach(int i in arrgiv)
            {
                Console.Write(i + " ");
            }

        }
    }
}
