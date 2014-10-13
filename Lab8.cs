using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class Program
    {
        
        static void print_r(string s)
        {
            if (s.Length > 0)
                print_r(s.Substring(1,s.Length - 1));
            else
                return;
            Console.Write(s[0]);
        }
        static void print_rn(string s)
        {

            for (int i = s.Length - 1; i >= 0; i-- )
            {
                Console.Write(s[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Enter a string to be reversed by recursion: ");
            String s = Console.ReadLine();
            Console.Write(s + " reversed by recursion is: ");
            print_r(s);
            Console.WriteLine();
            Console.Write("Enter a string to be reversed by iteration: ");
            String a = Console.ReadLine();
            Console.Write(a + " reversed by iteration is: ");
            print_rn(a);
            Console.WriteLine();

        }
    }
}
