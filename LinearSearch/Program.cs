// See https://aka.ms/new-console-template for more information
using System;
namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements in the array: ");
            int i, flag = 0, pos=0;
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the element to search: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for(i = 0; i < n; i++)
            {
                if (arr[i] == a)
                {
                    flag++;
                    pos = i;
                    break;
                }
            }
            if(flag == 1) 
            {
                Console.WriteLine("The element is found at position: " + pos);
            }
            else
            {
                Console.WriteLine("The element is not found in the array");
            }
        }
    }
}
