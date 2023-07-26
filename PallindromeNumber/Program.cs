// See https://aka.ms/new-console-template for more information
using System;
namespace PallindromeNumber
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 0, rev = 0, n1=n;
            while(n1> 0) 
            {
                r = n % 10;
                rev = rev * 10 + r;
                n1 = n1 / 10;
            }
            if(n==rev) 
            {
                Console.WriteLine("Pallindrome Number");
            }
            else
            {
                Console.WriteLine("Not a Pallindrome Number");
            }
        }
    }
}
