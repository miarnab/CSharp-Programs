// See https://aka.ms/new-console-template for more information
using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements in the array: ");
            int i, j, temp = 0;
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i = 0; i < n; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("The sorted array: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}


