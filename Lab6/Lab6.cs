using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*
 * Write a program in which you would:
    1.  Generate 100 random integer values between 0 and 1000. Display the number of even values generated as well as the smallest, the largest, and the range of values. Output should be displayed in a Windows Messagebox.
    You can look at the Random class in C#.
 
    For example, in your Messagebox, there will be:
 
    Even numbers: 54
    Smallest number: 0
    Largest number:  993
    Range of numbers: 0 - 993
 
    2. Prompt the user for the length of three line segments as integers. If the three lines could form a triangle, print the integers and a
    message indicating that they can form a triangle. Otherwise print the integers and a message indicating that they can not form a triangle. Recall that the sum of the lengths of any two sides must be greater than the length of the third side to form a triangle. (What kind of loop should we use?)
 
    For example:
    *** You can be prompted to enter 3 integers which could possibly
    *** be the respective lengths of the three sides of a triangle.
 
    Please enter the first integer: 20
    Please enter the second integer: 1
    Please enter the third integer: 3
 
     * The numbers 20, 1, and 3 CANNOT represent sides of the same triangle. *
 
    Would you like to try 3 numbers?
      Please enter 'y' for yes or another letter for no: y
 
    Please enter the first integer: 10
    Please enter the second integer: 6
    Please enter the third integer: 8
 
     * The numbers 10, 6, and 8 CAN represent sides of the same triangle. *
 
 
    Would you like to try 3 numbers?
      Please enter 'y' for yes or another letter for no: n
 * 
 */
 
namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU\n\n");

                Console.WriteLine("Please Choose the option you would like to run: ");
                Console.WriteLine("A: Enter A to generate 100 Random Integers     :A");
                Console.WriteLine("B: Enter B to perform Triangle Operations      :B");
                Console.WriteLine("X: Enter X to exit and Close this window       :X");

                ConsoleKeyInfo key = Console.ReadKey();
                char myChar = char.ToUpper(key.KeyChar);

                if (myChar == 'X')
                {
                    Console.WriteLine("\n\n\tGood-Bye.");
                    break;
                }
                if (myChar == 'A')
                {
                    randomHundred();
                    break;
                }
                if (myChar == 'B')
                {
                    triangleOps();
                    break;
                }
                else
                {
                    Console.WriteLine("\n\nInvalid Entry. Please try again...");
                    break;
                }
            }



            }

        private static void randomHundred()
        {
                Console.Clear();
                Console.WriteLine("\tGenerate 100 Random Integers");
                int evenNumbers = 0;
                int min = Int32.MaxValue;
                int max = Int32.MinValue;
                Random a = new Random();
                for (int i = 0; i < 100; i++)
                {
                    int n = a.Next(1000);
                    min = Math.Min(min, n);
                    max = Math.Max(max, n);

                    if (n % 2 == 0)
                    {
                        evenNumbers++;
                    }
                    Console.Write(n + " ");
                }
                String range = min + " - " + max;
                String Result = "even numbers: " + evenNumbers + "\n"
                           + "smallest number: " + min + "\n"
                           + "largest number: " + max + "\n"
                           + "range of numbers: " + range;


                MessageBox.Show(Result);
            }
private static void triangleOps()
{
    try
    {
        Console.Clear();
        Console.WriteLine("\tTriangle Operation");
        Console.Write("Please enter Side 1: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("Please enter Side 2: ");
        int b = Int32.Parse(Console.ReadLine());
        Console.Write("Please enter Side 3: ");
        int c = Int32.Parse(Console.ReadLine());
        Boolean isPosible = a < (b + c) && b < (a + c) && c < (b + a);
        if (isPosible) Console.WriteLine("The numbers {0}, {1}, and {2} CAN represent sides of the same triangle", a, b, c);
        else Console.WriteLine("The numbers {0}, {1}, and {2} CANNOT represent sides of the same triangle.", a, b, c);
        Console.Write("\nWould you like to try 3 numbers?\n   Please enter 'Y' for YES or another letter for NO: ");
        ConsoleKeyInfo key = Console.ReadKey();
        char myChar = char.ToUpper(key.KeyChar);
        while (myChar == 'Y')
        {
            Console.Write("\nPlease enter Side 1: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter Side 2: ");
            int e = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter Side 3: ");
            int f = Int32.Parse(Console.ReadLine());
            Boolean isValid = d < (e + f) && e < (d + f) && f < (e + d);
            if (isPosible) Console.WriteLine("The numbers {0}, {1}, and {2} CAN represent sides of the same triangle", d, e, f);
            else Console.WriteLine("The numbers {0}, {1}, and {2} CANNOT represent sides of the same triangle.", d, e, f);
            Console.Write("\nWould you like to try 3 numbers?\n   Please enter 'Y' for YES or another letter for NO: ");
            key = Console.ReadKey();
            myChar = char.ToUpper(key.KeyChar);
        }
        if(myChar != 'Y'){
            Console.WriteLine("\n\nUser does not want to enter any more measurements\n\n\n\n");
        }
       
    }
    catch (Exception e)
    {
        triangleOps();
    }

}

    }
}



