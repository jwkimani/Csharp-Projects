using System;

namespace Lab4Application
{
    public class Lab4
    {
        
        public static void MaximumMinimum()
        {
            Console.Clear();
            Console.WriteLine("Maximum and Minimum.\n");
            Console.Write("Enter number: ");

            string num = Console.ReadLine();
            double max = Convert.ToDouble(num);
            double min = Convert.ToDouble(num);

            while (num != "")
            {
                if (max < Convert.ToDouble(num))
                    max = Convert.ToDouble(num);
                if (min > Convert.ToDouble(num))
                    min = Convert.ToDouble(num);
                Console.Write("Enter number: ");
                num = Console.ReadLine();
            }

            Console.WriteLine("\nThe Maximum is: {0:f3}.", max);
            Console.WriteLine("The Minimum is: {0:f3}.", min);
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

        public static void Circumference()
        {
            Console.Clear();
            Console.WriteLine("Calculate the circumference of a circle.\n");
            Console.Write("Enter the radius: ");

            double radius = Convert.ToDouble(Console.ReadLine());
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine("\nThe Circumference of the radius entered is: {0:f3}.", circumference);
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

        public static void MaximumChange()
        {
            const int QUARTERS = 25;
            const int DIMES = 10;
            const int NICKELS = 5;
            const int PENNIES = 1;

            Console.Clear();
            Console.WriteLine("MAXIMUM CHANGE CALCULATION.\n");
            int quarters, dimes, nickels, pennies;
            Console.Write("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            quarters = amount / QUARTERS;
            int quart = amount % QUARTERS;
            dimes = quart / DIMES;
            int dim = quart % DIMES;
            nickels = dim / NICKELS;
            int nick = dim % NICKELS;
            pennies = nick / PENNIES;

            Console.WriteLine("The result is: {0} quarter(s), {1} dime(s), {2} nickel(s), {3} penny(ies).",
                quarters, dimes, nickels, pennies);
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

        public static void TestStudent()
        {
            Console.Clear();
            Console.WriteLine("STUDENT CLASS");

            Student student = new Student();
            Console.Write("Enter the student's first name: ");
            student.FirstName = Console.ReadLine();

            Console.Write("Enter the student's last name: ");
            student.LastName = Console.ReadLine();

            Console.Write("Enter the KSU ID: ");
            student.KsuID = Console.ReadLine();

            Console.WriteLine("\nThe student data is: ");
            Console.WriteLine(student);
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
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("Please Choose the option you would like to run: ");
                Console.WriteLine("\n\ta: Press a to compute the maximum and minimum of a group of data.");
                Console.WriteLine("\tb: Press b to Calculate the circumference of a circle.");
                Console.WriteLine("\tc: Press c to print the maximum change a customer should get back..");
                Console.WriteLine("\td: Press d to test the Student class.");
                Console.Write("\tx: Press x to exit application and Close this window: ");

                ConsoleKeyInfo key = Console.ReadKey();
                char myChar = char.ToUpper(key.KeyChar);

                if (myChar == 'X')
                {
                    break;
                }
                if (myChar == 'A')
                {
                    MaximumMinimum();
                }
                else if (myChar == 'B')
                {
                    Circumference();
                }
                else if (myChar == 'C')
                {
                    MaximumChange();
                }
                else if (myChar == 'D')
                {
                    TestStudent();
                }
                else
                {
                    Console.WriteLine("\nInvalid Entry. Please try again...");
                }
                Console.WriteLine();
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

        

    public class Student
    {
        private string firstName;
        private string lastName;
        private string ksuID;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string KsuID
        {
            get { return ksuID; }
            set { ksuID = value; }
        }

        public override string ToString()
        {
            return String.Format(this.FirstName +
                " " + this.LastName +
                " " + this.KsuID);
        }
    }
}