// See https://aka.ms/new-console-template for more information
using System;

namespace StringUpperCase
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the string/sentence/word: ");
            String s = Console.ReadLine();
            int i;
            for(i=0; i<s.Length; i++) 
            {
                char c = s[i];
                if (c == 32) 
                {
                    c++;
                }
                else if (c >= 65 && c <= 90) 
                {
                    c += 32;
                }
            }
        }
    }
}
