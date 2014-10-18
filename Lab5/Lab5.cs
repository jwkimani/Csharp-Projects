using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void arrayListOps()
        {
            Console.Clear();
            Console.WriteLine("ArrayList Operations:");
            Console.WriteLine("\nThis method  output the ordered list of the input (with duplicate values, either integers, or doubles)\n\n");

            int number = 0;
            int total = 0;


            ArrayList aList = new ArrayList();
            //System.Collections.ArrayList aList = new System.Collections.ArrayList();

            while (true)
            {
                Console.Write("Enter -1 to quit: ");
                number = Convert.ToInt32(Console.ReadLine());
                aList.Add(number);

                while (number != -1)
                {
                    total += number;


                    Console.Write("Enter number or -1 to quit: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    aList.Add(number);
                }
                if (aList.Count == 0)
                {
                    Console.WriteLine("No numbers were entered.");
                }
                // Displays the values of the ArrayList.
                Console.WriteLine("The ArrayList initially contains the following values:");
                PrintValues(aList);

                // Sorts the values of the ArrayList.
                aList.Sort();


                Console.WriteLine("After sorting:");
                PrintValues(aList);

                //Calculate the median of the data inputted
                Double myMedian = 0;
                int ArrayLength = aList.Count;
                int myOddMedian = ArrayLength/2;
                int myEvenMedian1 = ArrayLength/2 ;
                int myEvenMedian2 = myEvenMedian1 - 1;


                Object[] objectArray = aList.ToArray();
                if (IsOdd(aList.Count))
                {
                    myMedian = (Int32)objectArray[myOddMedian];
                  
                }
                else
                {
                    myMedian = ((Int32)objectArray[myEvenMedian1] + (double)objectArray[myEvenMedian2]) / 2;
                    
                  
                }

                Console.WriteLine("The median of the data inputted is: " + myMedian);

                Console.WriteLine("\nEnter X to go back to MAIN MENU");

                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    char myChar = char.ToUpper(key.KeyChar);

                    if (myChar == 'X')
                    {
                        Main();
                        break;

                    }

                }

            }

        }
        static void cubeOps()
        {
            Console.Clear();
            Console.WriteLine("This method  calculate the cubes of int values up to 100. \nThe output should be in two columns: the first lists the value;\nthe second column contains the cube of that value. \n\n\n");
            int maxInt = 100;
            int maxLength = maxInt.ToString().Length;

            for (int i = 0; i <= maxInt; i++)
            {
                Console.WriteLine(i + " cubed = " + i * i * i);
            }
            Console.WriteLine("\nEnter X to go back to MAIN MENU");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                char myChar = char.ToUpper(key.KeyChar);

                if (myChar == 'X')
                {
                    Main();
                    break;
                }
            }
        }


        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU\n\n");

                Console.WriteLine("Please Choose the option you would like to run: ");
                Console.WriteLine("A: Enter a for perform ArrayList Operations.");
                Console.WriteLine("B: Enter b for Cubes calculation.");
                Console.WriteLine("X: Enter X to exit and Close this window.");

                ConsoleKeyInfo key = Console.ReadKey();
                char myChar = char.ToUpper(key.KeyChar);

                if (myChar == 'X')
                {
                    Console.WriteLine("\n\n\tGood-Bye.");
                    break;
                }
                if (myChar == 'A')
                {
                    arrayListOps();
                    break;
                }
                else if (myChar == 'B')
                {
                    cubeOps();
                    break;
                }
                else
                {
                    Console.WriteLine("\n\nInvalid Entry. Please try again...");
                    break;
                }
            }
        }
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.WriteLine("   {0}", obj);
            Console.WriteLine();

        }


        public static bool IsOdd(int intValue)
        {
            return ((intValue % 2) == 1);
        }
    }
}
