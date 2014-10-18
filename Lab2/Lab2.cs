using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
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
                Console.WriteLine("A: Enter A for factorial operations(in the range [1,10])");
                Console.WriteLine("B: Enter B for Person class");
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
                    FactorialOps();
                    break;
                }
                if (myChar == 'B')
                {
                    PersonClass();
                    break;
                }
                else
                {
                    Console.WriteLine("\n\nInvalid Entry. Please try again...");
                    break;
                }

            }
        }

        public static void PersonClass()
        {
            Console.Clear();
            Console.WriteLine("PERSON CLASS");

            Person person = new Person();
            Console.Write("Enter the person's first name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter the person's last name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter the email: ");
            person.Email = Console.ReadLine();

            Console.WriteLine("\nThe person's data is: ");
            Console.WriteLine(person);

        }

        public static void FactorialOps()
        {
            Console.Clear();
            Console.WriteLine("generates the product of all the numbers in the range [1, 10]  ");

            int[] myRange = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = 1;
            for (int i = 1; i <= 9; i++)
            {
                result *= i;
            }
            Console.WriteLine(" ");
            Console.WriteLine("1* 2* 3* 4* 5* 6* 7* 8* 9* 10 = " + result);

        }

    }
    public class Person
    {
        private string firstName;
        private string lastName;
        private string email;

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

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override string ToString()
        {
            return String.Format(this.FirstName +
                " " + this.LastName +
                " " + this.email + " ");
        }


    }

}

