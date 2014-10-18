using System;

public class Lab3
{
    static void temperatureconversion()
    {
        Console.Clear();
        Console.WriteLine("TEMPERATURE CONVERSION");


        while (true)
        {
            Console.WriteLine("Please Choose the conversion you would like to run: ");
            Console.WriteLine("\n\ta:.............. Press c to Convert from Celsius to Fahrenheit.");
            Console.WriteLine("\tb:.............. Press f to Convert from Fahrenheit to Celsius.");
            Console.Write("\tx:.............. Press x to go back to MAIN MENU: ");

            ConsoleKeyInfo key = Console.ReadKey();
            char myChar = char.ToUpper(key.KeyChar);

            if (myChar == 'X')
            {
                Main();
                break;
            }
            if (myChar == 'C')
            {
                Console.WriteLine();
                Console.Write("\nPlease enter the temperature in Celsius: ");
                string enteredcelsius = Console.ReadLine();
                double tempCelsius = Convert.ToDouble(enteredcelsius);
                double tempFahrenheit = ((double)9 / (double)5) * tempCelsius + 32;

                Console.WriteLine("\nThe temperature you entered is equivalent to {0:f2} degrees Fahrenheit.",
                        tempFahrenheit);
                break;
            }
            if (myChar == 'F')
            {
                Console.WriteLine();
                Console.Write("\nPlease enter the temperature in Fahrenheit: ");
                string enteredfar = Console.ReadLine();
                double tempFar = Convert.ToDouble(enteredfar);
                double tempCelsius = (double)5 / (double)9 * ((double)tempFar - 32);

                Console.WriteLine("\nThe temperature you entered is equivalent to {0:f2} degrees Celsius.",
                        tempCelsius);
                break;
            }
            else
            {
                Console.WriteLine("Invalid Entry: Please Enter a number");
                break;
            }
        }
    }

    static void SimpleArithmetic()
    {

        Console.Clear();
        Console.WriteLine("SIMPLE ARITHMETIC\n\n");


        double FirstNum;
        double SecondNum;
        double sum;
        double difference;
        double product;
        double quotient;
        double remainder;

        Console.Write("\tEnter First Number: ");
        string input1 = Console.ReadLine();
        FirstNum = Convert.ToDouble(input1);

        Console.Write("\tEnter Second Number: ");
        string input2 = Console.ReadLine();
        SecondNum = Convert.ToDouble(input2);

        Console.WriteLine();
        Console.WriteLine("The numbers entered were: {0} and {1}.", FirstNum, SecondNum);
        Console.WriteLine();

        sum = FirstNum + SecondNum;
        Console.WriteLine("Their sum is: \t\t{0}.", sum);

        difference = FirstNum - SecondNum;
        Console.WriteLine("Their difference is: \t{0}.", difference);

        product = FirstNum * SecondNum;
        Console.WriteLine("Their product is: \t{0}.", product);

        quotient = FirstNum / SecondNum;
        Console.WriteLine("Their quotient is: \t{0}.", quotient);

        remainder = FirstNum % SecondNum;
        Console.WriteLine("Their remainder is: \t{0}.", remainder);
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

    static void FormatCurrency()
    {
        Console.Clear();
        Console.WriteLine("CURRENCY CONVERSION\n\n");

        int number = 0;
        int total = 0;
        int counter = 0;
        while (true)
        {
            Console.Write("Enter number or -1 to go Back to MAIN MENU: ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number != -1)
            {
                total += number;
                counter++;

                Console.Write("Enter number or -1 to go back to MAIN MENU: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            if (number == -1)
            {
                Main();
                break;
            }
            if (counter == 0)
            {
                Console.WriteLine("No numbers were entered.");
            }
            Console.WriteLine("\nThe sum of the numbers entered is {0:c}.", total);
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

    static void ComputeAverage()
    {
        Console.Clear();
        Console.WriteLine("AVERAGE COMPUTATION\n\n");


        const int NUMBER_OF_EXAMS = 5;
        double exm1;
        double exm2;
        double exm3;
        double exm4;
        double exm5;
        double average;

        Console.Write("Enter the exam score for Exam One: ");
        string exam1 = Console.ReadLine();
        exm1 = Convert.ToDouble(exam1);

        Console.Write("Enter the exam score for Exam Two: ");
        string exam2 = Console.ReadLine();
        exm2 = Convert.ToDouble(exam2);

        Console.Write("Enter the exam score for Exam Three: ");
        string exam3 = Console.ReadLine();
        exm3 = Convert.ToDouble(exam3);

        Console.Write("Enter the exam score for Exam Four: ");
        string exam4 = Console.ReadLine();
        exm4 = Convert.ToDouble(exam4);

        Console.Write("Enter the exam score for Exam Five: ");
        string exam5 = Console.ReadLine();
        exm5 = Convert.ToDouble(exam5);

        average = (exm1 + exm2 + exm3 + exm4 + exm5) / (double)(NUMBER_OF_EXAMS);
        Console.WriteLine("\nThe average of the five exam scores entered is: {0:f3}", average);
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

    static void CalculateProduct()
    {
        Console.Clear();
        Console.WriteLine("PRODUCT CALCULATION:");
        Console.WriteLine("\nThis method generates the product of all the numbers in the range [1, 10].\n\n");
        int product = 1;

        for (int i = 1; i <= 10; i++)
        {
            product *= i;
            Console.WriteLine("Iteration {0}: \tProduct = {1}", i, product);
        }
        Console.WriteLine("\nThe product of all the numbers in the range [1,10] is {0}.", product);
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
            Console.WriteLine("a: Enter a for Temperature Conversion.");
            Console.WriteLine("b: Enter b for Simple Arithmetic.");
            Console.WriteLine("c: Enter c for Currency Formatting.");
            Console.WriteLine("d: Enter d for Average Computation.");
            Console.WriteLine("e: Enter e for Product Calculation.");
            Console.Write("x: Enter x to exit application and close this window: ");

            ConsoleKeyInfo key = Console.ReadKey();
            char myChar = char.ToUpper(key.KeyChar);

            if (myChar == 'X')
            {
                Console.WriteLine("\n\n\tGood-Bye.");
                break;
            }
            if (myChar == 'A')
            {
                temperatureconversion();
                break;
            }
            else if (myChar == 'B')
            {
                SimpleArithmetic();
                break;
            }
            else if (myChar == 'C')
            {
                FormatCurrency();
                break;
            }
            else if (myChar == 'D')
            {
                ComputeAverage();
                break;
            }
            else if (myChar == 'E')
            {
                CalculateProduct();
                break;
            }
            else
            {
                Console.WriteLine("\n\nInvalid Entry. Please try again...");
                break;
            }

        }
    }
}
