using System;

namespace BasicsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjString();
            ObjMath();

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
        }
    }
}
