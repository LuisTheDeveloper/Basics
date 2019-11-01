using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

// Every application belongs to a class, all code needs to be defined in a class. Every class belongs to a namespace.
// A namespace is just a logical grouping of classes.
namespace BasicsCSharp
{
    class Program
    {
        // enum data type declaration
        enum Days { Sun, Mon, Tur, Wed, Thu, Fri, Sat };    

        static void Main(string[] args) 
        {
            Tutorial pTutor = new Tutorial();   // Create an object from the Tutorial class.
            pTutor.SetTutorial(1, ".Net");      // Calling the first method
            Console.WriteLine(pTutor.GetTutorial());

            pTutor.SetTutorial(".Net Core");    // Calling the second method
            Console.WriteLine(pTutor.GetTutorial());

            Guru99Tutorial pTutor2 = new Guru99Tutorial();
            pTutor2.RenameTutorial(".Net by Guru99");       // The child class renames the TutorialName field
            Console.WriteLine(pTutor2.GetTutorial());

            

            Int32[] elements;

            
            elements = new Int32[3];
            elements[0] = 1;
            elements[1] = 2;
            elements[2] = 3;
            
            // ObjString();
            // ObjMath();
            // CircleCalc();
            // BranchesLoops();
            // SumNumsDivisibleBy3();
            // ListCollections();
            // NewBranches();

            // Console.Write(Days.Sun);

            // Reading elements from the array
            foreach( Int32 n in elements)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }

        static void NewBranches()
        {
            Int32 value = 11;
            string value2 = "South Wales";

            switch (value)
            {
                case 1: 
                    Console.WriteLine("Value is 1");
                    break;
                case 11:
                    if (value2.Contains("Wales"))
                    {
                        Console.WriteLine($"the string contains {value2}");
                    }
                    break;
                default:
                    Console.WriteLine("Other Value");
                    break;
            }
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
            Int32 num = 30;
            Console.WriteLine(num);

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

        static void BranchesLoops()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            // The == symbol tests for equality. Using == distinguishes the test for equality from assignment
            // The && represents "and".
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10.");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is less than or equal to 10.");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

            int counter = 0;
            // The while loop tests the condition before executing the code
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;  // The ++ is the incrementer operator, it adds 1.
            }

            // The do ... while loop executes the code first, and then checks the condition.
            counter = 1;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 1);

            // The for loop has 3 parts: initializer, condition and iterator.
            for (counter = 0; counter < 3; counter++)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }

        }

        static void SumNumsDivisibleBy3()
        {
            int remainder = 0;
            int number = 0;
            int totsum = 0;

            for (number = 0; number<21; number++)
            {
                remainder = number % 3;
                if (remainder == 0)
                    totsum += number;
            }

            Console.WriteLine($"The sum of the all integers less than 21 that are divisible by 3 is: {totsum}");
        }

        static void ListCollections()
        {
            // Creating a list - it uses the List<T> type.
            var names = new List<string> { "Luis", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            names.Add("Mary");
            names.Add("Annie");
            names.Remove("Felipe");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }

    }
}
