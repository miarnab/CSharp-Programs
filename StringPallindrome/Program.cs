// See https://aka.ms/new-console-template for more information
using System;

namespace StringPallindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string/sentence/word: ");
            String s = Console.ReadLine();
            String s1 = "";
            int i;
            for (i = s.Length-1; i >= 0; i--)
            {
                s1 += s[i].ToString();
            }
            if( s == s1 ) 
            {
                Console.WriteLine("Pallindrome String");
            }
            else
            {
                Console.WriteLine("Not a Pallindrome String");
            }
        }
    }
}

