using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyShapes
{
    public class Lab1
    {

        public enum eShape
        {
            Square,
            Rectangle,
            Triangle,
            Quit
        }

        static void Main(string[] args)
        {
            while (true)
            {
                eShape s = getShapeFromUser();
                switch (s)
                {
                    case eShape.Quit:
                        return;
                    case eShape.Triangle:
                        myTriangle();
                        break;

                    case eShape.Rectangle:
                        myRectangle();
                        break;

                    case eShape.Square:
                        mySquare();
                        break;
                }
            }
        }

        static eShape getShapeFromUser()
        {
            Console.Clear();
            Console.WriteLine("MY SHAPES");
            Console.WriteLine(" Enter S to draw a square ");
            Console.WriteLine(" Enter R to draw a rectangle");
            Console.WriteLine(" Enter T to draw a triangle");
            Console.WriteLine(" Enter Q to Quit");
            while (true)
            {
                String selection = Console.ReadLine().Trim();
                switch (selection)
                {
                    case "S":
                    case "s":
                        return eShape.Square;
                    case "R":
                    case "r":
                        return eShape.Rectangle;
                    case "T":
                    case "t":
                        return eShape.Triangle;
                    case "Q":
                    case "q":
                        return eShape.Quit;
                    default:
                        Console.WriteLine("Your selection is not valid! Please try again.");
                        break;
                }
            }
        }

        static void mySquare()
        {
            Console.Clear();
            Console.WriteLine("SQUARE\n");
            Console.WriteLine("Please enter the square's side length:");
            Int32 sideLength = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (int i = 0; i < sideLength; i++)
            {
                writeNChars('*', sideLength);
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static void myRectangle()
        {
            Console.Clear();
            Console.WriteLine("RECTANGLE\n");
            Console.WriteLine("Please enter the rectangle's height:");
            Int32 h = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the rectangle's width:");
            Int32 w = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (int i = 0; i < h; i++)
            {
                writeNChars('*', w);
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static void myTriangle()
        {
            Console.Clear();
            Console.WriteLine("TRIANGLE");
            Console.WriteLine("Please enter the triangle's base:");
            Int32 b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the triangle's height:");
            Int32 h = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (int i = 1; i <= h; i++)
            {
                writeNChars('*', (int)Math.Ceiling((double)b * (double)i / (double)h));
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static void writeNChars(char c, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(c);
        }
    }
}

