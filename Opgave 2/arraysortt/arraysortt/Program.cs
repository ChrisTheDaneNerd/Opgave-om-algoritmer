using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysortt
{
    internal class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 8, 6, 2, 3, 9, 7, 5 };
            InsertionSort ob = new InsertionSort();
            ob.sort(arr);
            printarray(arr);
            Console.WriteLine(arr[0]);
            Console.ReadKey();




        }

        void sort(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while(j >= 0&& arr[j]<key) {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j+1] = key;
            }
        }
        static void printarray(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i < n;i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine("\n\n");
        }
    }
}
