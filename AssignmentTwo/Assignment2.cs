using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Enter a string to check if it is a palindrome(by recursion): ");
            String s1 = Console.ReadLine();
            Boolean a = Palindrome_r(s1);
            Console.WriteLine(s1 + ": " + a);
            Console.WriteLine();
            Console.Write("Enter a string to check if it is a palindrome(by iteration): ");
            String s2 = Console.ReadLine();
            Boolean b = Palindrome_nr(s2);
            Console.WriteLine(s2 + ": " + b);
            Console.WriteLine();
        }
        //check if a string s is a Palindrome by recursion
        static bool Palindrome_r(string s)
        {
            //base case
            if (s.Length == 0 || s.Length == 1)
                return true;    
            else if (s[0] == s[s.Length - 1])
               return Palindrome_r(s.Substring(1, s.Length - 2));
            else
                return false;
                
        }
        //check if a string s is a Palindrome by iteration
        static bool Palindrome_nr(string s)
        {
            Boolean check = true;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                    check = false;

            }    
            return check;
        }
    }
}
