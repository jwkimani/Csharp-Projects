using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Assignment One
 * Please write a program to:
 * 1. read 10 double values from the user input, and output max and min of them
 * 2. read the radius from the user input, and calculate and output the circumference of a circle. 
 *    Declare a constant variable for pi with a value of 3.14159. Display the result with 3 digits 
 *    on the right side of the decimal point
 * 3. read the amount of cents from the user input, and output the maximum numbers of quarters, dimes,
 *    nickels, and pennies that a customer should get back as change. For example, if user inputs 43, 
 *    your program should output 1 quarter, 1 dime, 1 nickel, and 3 pennies.
 */
 
namespace AssignmentOne
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
                Console.WriteLine("A: Enter A for max and min operations     :A");
                Console.WriteLine("B: Enter B for circumference of a circle  :B");
                Console.WriteLine("C: Enter C for money operations           :C");
                Console.WriteLine("X: Enter X to exit and Close this window  :X");

                ConsoleKeyInfo key = Console.ReadKey();
                char myChar = char.ToUpper(key.KeyChar);

                if (myChar == 'X')
                {
                    Console.WriteLine("\n\n\tGood-Bye.");
                    break;
                }
                if (myChar == 'A')
                {
                    maxminOps();
                    break;
                }
                if (myChar == 'B')
                {
                    circleOps();
                    break;
                }
                if (myChar == 'C')
                {
                    moneyOps();
                    break;
                }
                else
                {
                    Console.WriteLine("\n\nInvalid Entry. Please try again...");
                    break;
                }

            }

        }

        private static void maxminOps()
        {
            String message = "Please enter a double: ";
            double[] numbers = new double[10];
            Console.Clear();
            Console.WriteLine("\a\tMAXIMUM AND MINIMUM OPERATIONS\n");
            //Read, convert and add the values into the new array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(message);
                String entry = Console.ReadLine();
                Double cValue = Convert.ToDouble(entry);
                numbers[i] = cValue;
               
            }
            //find the maximum and the minimum value
            double max = numbers[0];
            double min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                    max = numbers[i];
                if (min > numbers[i])
                    min = numbers[i];
            }
            String output = "The array is: ";
            //output the array
            for (int i = 0; i < numbers.Length; i++)
            {
                output += numbers[i] + " ";

            }
            Console.WriteLine(output);
            Console.WriteLine("The minimum value is: {0:f}", min);
            Console.WriteLine("The maximum value is: {0:f}", max);
            
        }
         private static void circleOps()
        {
            const double PI = 3.1415;
            Console.Clear();
            Console.WriteLine("\a\tCircumference of a circle\n");
            Console.Write("Please enter the Radius of circle: ");
            String radiusInput = Console.ReadLine();
            Double radius = Convert.ToDouble(radiusInput);
            //perimeter = 2piR = piD
            Double perimeter = 2 * radius * PI;
            //Area = piRR
            double area = PI * radius * radius;
            Console.WriteLine("\nThe circle of radius {0:f} has the perimeter = {1:f3} and the area = {2:f3}\n", radius, perimeter, area);

        }
        private static void moneyOps()
        {
            const int QUARTER = 25;
            const int DIME = 10;
            const int NICKEL = 5;
            const int PENNY = 1;
            Console.Clear();
            Console.WriteLine("\a\tMoney Operations\n");
            Console.Write("How many cents do you have? ");
            String inputCash =  Console.ReadLine();
            int cash = Convert.ToInt32(inputCash);

            int hmQuarters = 0;
            int hmDimes = 0;
            int hmNickels = 0;
            int hmPennies = 0;
            //check if the cash entered is greater than or equal to a quarter. 
            if (cash >= QUARTER)
            {
                hmQuarters = (int)(cash/QUARTER);
                int modQuarters = cash % QUARTER;
                hmDimes = (int)(modQuarters / DIME);
                int modDimes = modQuarters % DIME;
                hmNickels = (int)(modDimes / NICKEL);
                int modNickels = modDimes % NICKEL;
                hmPennies = (int)(modNickels / PENNY);
                Console.WriteLine("{0} cents gives you a change of {1} Quarter(s), {2} Dime(s), {3} Nickel(s) and {4} Pennie(s)\n", cash, hmQuarters, hmDimes, hmNickels, hmPennies);
            }
            //check if cash entered is less than a quarter and greater than or equal to a dime
            if (cash >= DIME && cash < QUARTER)
            {
                hmDimes = (int)(cash / DIME);
                int modDimes = cash % DIME;
                hmNickels = (int)(modDimes / NICKEL);
                int modNickels = modDimes % NICKEL;
                hmPennies = (int)(modNickels / PENNY);
                Console.WriteLine("{0} cents gives you a change of {1} Quarter(s), {2} Dime(s), {3} Nickel(s) and {4} Pennie(s)\n", cash, hmQuarters, hmDimes, hmNickels, hmPennies);

            }
            //check if cash entered is less than a dime but greater than or equal to a nickel
            if (cash >= NICKEL && cash < DIME)
            {
                hmNickels = (int)(cash / NICKEL);
                int modNickels = cash % NICKEL;
                hmPennies = (int)(modNickels / PENNY);
                Console.WriteLine("{0} cents gives you a change of {1} Quarter(s), {2} Dime(s), {3} Nickel(s) and {4} Pennie(s)\n", cash, hmQuarters, hmDimes, hmNickels, hmPennies);

            }
            //check if cash entered is less than a nickel but greter than or equal to a penny
            if (cash >= PENNY && cash < NICKEL)
            {
                hmPennies = (int)(cash / PENNY);
                Console.WriteLine("{0} cents gives you a change of {1} Quarter(s), {2} Dime(s), {3} Nickel(s) and {4} Pennies\n",cash, hmQuarters, hmDimes, hmNickels, hmPennies);

            }

        }

       

        
    }
}
