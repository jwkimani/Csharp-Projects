using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Please enter an integer( to calculate by recursion): ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The calculation by recursion is: {0}",calculation_r(a));
            Console.Write("\nPlease enter an integer( to calculate by iteration): ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The calculation by iteration is: {0}\n",calculation_nr(b));
        }
        static double calculation_r(int n)
        {
            if (n == 1)
                return 1.0 / 2; 
            else
                return calculation_r(n - 1) + (n * 1.0 / (n + 1)); 
        }
        static double calculation_nr(int n)
        {
            double a = 0;
            for (int i = 1; i <= n; i++)
            {
                a = a + (i / (i + 1.0));
            }
            return a;
        }

    }
}
