// See https://aka.ms/new-console-template for more information
using System;
namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 0, rev = 0;
            while (n > 0) 
            {
                r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            Console.WriteLine("The number in reversed form: " + rev);
        }
    }
}
