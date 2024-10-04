using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NUMERIC");
            /*
             * VARIABLES AND DATA TYPES
             * 
             * int - [4 bytes] stores integers (whole numbers), without decimals, from -2,147,483,648 to 2,147,483,647
             * long - [8 bytes] stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
             * float - [4 bytes] stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
             * double - [8 bytes] stores fractional numbers. Sufficient for storing 15 decimal digits
             ** decimal - 
             * char - [2 bytes] stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
             * string - [2 bytes] stores text, such as "Hello World". String values are surrounded by double quotes
             * bool - [1 bit ] stores values with two states: true or false
             * 
             * const - declaring a variable as constant, unchangeable and read only
             * 
             * 
             * 
             * ** NUMERIC
             */

            int age = 35;
            Console.WriteLine(age);

            long bigNumber = 90000000L;
            Console.WriteLine(bigNumber);

            double bigNumber2 = 55.3;
            Console.WriteLine(bigNumber2);
            double bigNumber3 = 43.9D;
            Console.WriteLine(bigNumber3);

            float bigNumber4 = 233.05F; // the F to differentiate from a double.
            Console.WriteLine(bigNumber4);

            decimal bigNumber5 = 15.44M;
            Console.WriteLine(bigNumber5);

            /*
             * TYPE CONVERSION -> in-built methods
             * Convert.ToInt32()
             * Convert.ToInt64()
             * Convert.ToFloat()
             * Convert.ToDouble()
             * Convert.ToString()
             * 
            */




            /*
             * TryParse function - better alternative for converting string to integer
             * 
             */
            Console.WriteLine();

            int result2;
            Console.WriteLine("Enter first number.");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Enter second number.");
            string userInput2 = Console.ReadLine();

            bool validFirstNumber = int.TryParse(userInput1, out int value);
            bool validSecondNumber = int.TryParse(userInput2, out int value2);

            if (validFirstNumber && validSecondNumber)
            {
                result2 = value + value2;
                Console.WriteLine(result2);
            }
            else
            {
                if (!validFirstNumber || !validSecondNumber)
                {
                    Console.WriteLine("first or second number is invalid.");
                }
            }




            /*
             * OPERATORS
             * Arithmetic - +, -, *, /, %, ++, -- 
             * Assignment - =, +=, -=, *=, /=, %=, &=, |=, ^=, >>=, <<=
             * Comparison - ==, !=, >, <, >=, <=
             * Logical - &&, ||, ! 
             *
             */




            /*
             * MATHS CLASS METHODS
             * Math.Max()
             * Math.Min()
             * Math.Sqrt()
             * Math.Abs()
             * Math.Round()
             * Math.Pow()
             * 
             * 
             * ** NUMERIC FORMATTING
             */
            // Numeric formatting (Decimal)
            Console.WriteLine();
            Console.WriteLine("Numeric formatting (decimal)");

            double result = 12000D / 17.54;
            Console.WriteLine(string.Format("{0:0}", result));
            Console.WriteLine(string.Format("{0:0.0}", result));
            Console.WriteLine(string.Format("{0:0.#}", result));
            Console.WriteLine(string.Format("{0:0.00}", result));

            //Numeric formatting (Currency)
            Console.WriteLine();
            Console.WriteLine("Numeric formatting (currency)");

            double money = 10D / 3D;
            //Console.WriteLine(string.Format("{0:0.00}", result));
            Console.WriteLine(money.ToString("C"));

            // Using globalization
            //      use the location of the server on which the program is running on (
            //      not efficent if the program runs in different geographical locations.)
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));

            //      use specific geographical locations.
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));

            //      research on using user location to format currency.




            /*
             * ** STRING
             *
             * variable.Length
             * variable.ToUpper()
             * variable.ToLower()
             * variable.IndexOf(character)
             * variable.Substring(index) - returns a new string starting from a specified location
             * string.Empty
             * string.IsNullOrEmpty(variable)
             * variable.Equals(otherVariable) // compares references in memory
             * variable.Contains(character)
             * 
             * 
             * 
             * Concatenation - + or string.Concat(comma separated values)
             * Interpolation - $""
             * Using back slash for quotation within a string
             *  e.g., "Michael said "Come here"" ==> "Michael said \"Come here\""
             *      or C:\Users\CodeWorl\Desktop\c#_tuts ==> C:\\Users\\CodeWorl\\Desktop\\c#_tuts
             *      or Verbatim: @"C:\Users\CodeWorl\Desktop\c#_tuts"
             *                   @"Michael said "Come here""
             * 
             * 
             */
            Console.WriteLine();
            Console.WriteLine("STRING");

            string name = "Worla"; // double quote is used for string
            char letter = 'a'; // a single quote is used for single characters
            Console.WriteLine($"The last letter in {name} is {letter}.");

            Console.WriteLine("Choose a Username.");
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}");

            //String iteration

            string message = "C# is Awesome";
            
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(500);
            }






            /*
             * CONDITIONS AND IF STATEMENTS
             * Ternary: variable = (condition) ? expressionTrue :  expressionFalse;
             * 
             */



            /*
             * SWITCH
             * switch (expression) {
             *      case x:
             *          code block
             *          break;
             *      case y:
             *          code block;
             *          break;
             *      default case:
             *          code block
             *          break;
             * }
             */


            /*
             * LOOPS
             * 
             * WHILE LOOP 
             * while (condition) {
             *      code block
             * }
             */
            Console.WriteLine();
            Console.WriteLine("CONDITIONALS AND IF STATEMENTS");

            int loopCounter = 0;
            while (loopCounter < 5)
            {
                Console.WriteLine("I am a while loop.");
                loopCounter++;
            }


            /*
             * DO WHILE LOOP
             * 
             * do {
             *  code block
             * } while (condition)
             * 
             * FOR LOOP
             * for (loop variable; condition; increment/decrement) {
             *      code block
             * }
             * 
             * NESTED LOOP
             * 
             * FOR EACH LOOP - loops through elements in an array or other data sets
             * 
             * 
            */
            Console.WriteLine();
            Console.WriteLine("LOOPS");

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }


            /*
             * ARRAYS - store multiple values in a single variable
             * 
             * LOOPING
             * for each(dataType variableName in arrayName){}
             * 
             * METHODS
             * Array.sort(arrayName)
             * Array.Reverse(arrayName)
             * Array.IndexOf(arrayName, value)
             *      Usage: int variableName = Array.IndexOf(arrayName, value)
             * Array.LastIndexOf(arrayName, value)
             *      Usage: int variableName = Array.LastIndexOf(arrayName, value)
             * Array.Copy(sourceArray, destinationArray, length)
             * Array.Clear(arrayName, startIndex, length)
             * Array.Resize(ref arrayName, newSize)
             * Array.Find(arrayName, condition)
             * Array.FindAll(arrayName, condition)
             * Array.ForEach(arrayName, action)
             * Array.Exists(arrayName, condition)
             * Array.TrueForAll(arrayName, condition)
             *      Usage: bool match = Array.TrueForAll(arrayName, condition)
             * 
             * PROPERTIES
             * arrayName.Length()
             * arrayName.Rank()
             * 
             * 
             */
            Console.WriteLine();
            Console.WriteLine("ARRAYS");

            //Array.Sort() usage
            int[] num = new int[] { 4, 2, 7, 1, 3 };
            Array.Sort(num);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

            //sort usage 2
            Console.WriteLine();
            string[] letters = new string[] { "a", "i", "f", "y" };
            Array.Sort(letters);
            foreach (string letter2 in letters)
            {
                Console.Write($"{letter2}, ");
            }

            //Array.Reverse() usage
            Console.WriteLine();
            string[] words = new string[] { "one", "two", "four", "five" };
            Array.Reverse(words);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }


            string[] cars2 = { "Monday", "Wednesday", "Friday" };
            //cars2 = {"Monday", "Wednesday", "Friday"};


            double videoPauseTime = 3.37;
            Console.ReadKey();
        }
    }
}
