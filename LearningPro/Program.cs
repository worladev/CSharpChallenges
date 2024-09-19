using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
             */


            /*
             * STRING
             * variable.Length
             * variable.ToUpper()
             * variable.ToLower()
             * variable.IndexOf(character)
             * variable.Substring(index) - returns a new string starting from a specified location
             * 
             * 
             * 
             * Concatenation - + or string.Concat()
             * Interpolation - $""
             */
            string name = "Worla"; // double quote is used
            char letter = 'a'; // a single quote is used
            Console.WriteLine($"The last letter in {name} is {letter}.");

            Console.WriteLine("Choose a Username.");
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}");


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
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("I am a while loop.");
                i++;
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
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }


            /*
             * ARRAYS - store multiple values in a single variable
             * 
             */
            string[] cars2 = { "Monday", "Wednesday", "Friday" };
            //cars2 = {"Monday", "Wednesday", "Friday"};

            double videoPauseTime = 1.37;
            Console.ReadKey();
        }
    }
}
