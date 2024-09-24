using System;
using System.Data.SqlTypes;
/*
namespace woow
{
    class Program
    {
        static void Second() 
        {
            // Takes in 2 inputs
            string? first = Console.ReadLine();
            string? second = Console.ReadLine();
            // Prints the inputted words, but in a reversed order
            Console.WriteLine($"{second}\n{first}");
            // The following lines contain a series of tests for uhh testing purposes
            int x = 12;
            int y = 2;
            x = x * 3 + y;
            Console.WriteLine(x);
        }
    }
}
*/
namespace maths
{
    class Program
    {
        public static void Main()
        {
            // Greeting/MOTD
            Console.WriteLine("Hello, and welcome to the Circle Area and Circumference Calculator!");
            // Take in the required parameters
            Console.WriteLine("Would you like to calculate the area or the circumference (type in 'a' or 'c')");
            string? what = Console.ReadLine();
            if  (what == "a")
            {
                // Take in the Radius
                Console.WriteLine("What is the radius? ");
                double radius = Convert.ToDouble(Console.ReadLine());
                // Calculate the area
                double area = Math.Pow(radius, 2) * Math.PI;
                // Return / print the result
                Console.WriteLine($"The area of the circle is {area}");
            }
            else if (what == "c")
            {   
                // Take in the Diameter
                Console.Write("What is the Diameter? ");
                double diameter = Convert.ToDouble(Console.ReadLine());
                // Calculate the Circumference
                double circumference = diameter * Math.PI;
                Console.WriteLine($"The Circumference is {circumference}");
            }
            else
            {
                Console.WriteLine("Please die, dyslexic scum");
            }
        }
    }
}