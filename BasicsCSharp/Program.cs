using System;

namespace BasicsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjString();
            ObjMath();
            CircleCalc();
        }

        static void ObjString()
        {
            // Declaring and using variables
            string wMessage = "World!";
            string FirstName = "Luis Pedro";
            string TrimmedString;

            var date = DateTime.Now;

            // String Composite Format
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", wMessage, DateTime.Now.DayOfWeek, DateTime.Now);
            // String Interpolation Format
            Console.WriteLine($"Hello, {wMessage}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

            // Work with strings
            Console.WriteLine($"The name {FirstName} has {FirstName.Length} letters");

            TrimmedString = FirstName.Trim();
            Console.WriteLine($"{TrimmedString}");

            FirstName = FirstName.Replace("Pedro", "Miguel");
            Console.WriteLine(FirstName);
            Console.WriteLine(FirstName.ToUpper());

            // Searching strings
            string devText = "We are more smart learning C# language";

            Console.WriteLine(devText.Contains("smart"));
            Console.WriteLine(devText.Contains("productive"));
        }

        static void ObjMath()
        {
            // Integer types variables
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"Example of overflow: {what}");

            // Double types variables
            double a1 = 19;
            double b1 = 23;
            double c1 = 8;
            double d1 = (a1 + b1) / c1;
            Console.WriteLine(d1);

            double dmax = double.MaxValue;
            double dmin = double.MinValue;
            Console.WriteLine($"The range of double is {dmin} to {dmax}");

            // Decimal types variables
            decimal ddmin = decimal.MinValue;
            decimal ddmax = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {ddmin} to {ddmax}");

            double a2 = 1.0;
            double b2 = 3.0;
            Console.WriteLine(a2 / b2);

            // The M suffix on the numbers is how you indicate that a constant should use the decimal type
            decimal c2 = 1.0M;
            decimal d2 = 3.0M;
            Console.WriteLine(c2 / d2);
        }

        static void CircleCalc()
        {
            double radius = 2.50;
            double wPI = Math.PI;
            //double SqrRadius = Math.Sqrt(radius);
            double SqrRadius = radius * radius;
            double area = SqrRadius * wPI;

            Console.WriteLine($"The area for a circle with a radius of {radius} is {area}");


        }

    }
}
