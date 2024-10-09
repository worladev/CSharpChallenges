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
            // SAMPLE DATA TYPES AND VARIABLE USAGE
            // NUMERIC
            Console.WriteLine("NUMERIC");

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
             * TYPE CONVERSION USAGE
             *
             *
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

            if (validFirstNumber && validSecondNumber) {
                result2 = value + value2;
                Console.WriteLine(result2);
            }
            else {
                if (!validFirstNumber || !validSecondNumber) {
                    Console.WriteLine("first or second number is invalid.");
                }
            }


            /*
             * OPERATORS
             * 
             */


            /*
             * MATHS CLASS METHODS 
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
             * STRING
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
            
            for (int i = 0; i < message.Length; i++) {
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
            foreach (string car in cars) {
                Console.WriteLine(car);
            }


            //ARRAYS - immutable

            Console.WriteLine();
            Console.WriteLine("ARRAYS");

            //Declaration
            //  dataType[] arrayName = new dataType[arraySize];
            
            //Array.Sort() usage
            int[] num = new int[] { 4, 2, 7, 1, 3 };
            Array.Sort(num);
            foreach (int i in num) {
                Console.WriteLine(i);
            }

            //sort usage 2
            Console.WriteLine();
            string[] letters = new string[] { "a", "i", "f", "y" };
            Array.Sort(letters);
            foreach (string letter2 in letters) {
                Console.Write($"{letter2}, ");
            }

            //Array.Reverse() usage
            Console.WriteLine();
            string[] words = new string[] { "one", "two", "four", "five" };
            Array.Reverse(words);
            foreach (string word in words) {
                Console.WriteLine(word);
            }

            //indexOf usage
            int[] numbers = new int[] { 5, 10, 15, 20, 25 };
            int searchInput = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(numbers, searchInput);

            if (position > -1)
            {
                Console.WriteLine($"Number {searchInput} has been found at positon {position}");
            }
            else
            {
                Console.WriteLine("Number not found.");
            }



            //string[] cars2 = { "Monday", "Wednesday", "Friday" };
            //cars2 = {"Monday", "Wednesday", "Friday"};



            /*
             * LISTS - mutable and dynamic
             * 
             */
            Console.WriteLine("LIST");

            //Declaration
            //  List<dataType> listName = new List<dataType>();
            //  sample how to
            List<string> names = new List<string>();
            List<int> ages = new List<int>();
            int counter = 3;

            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("Enter first name: ");
                names.Add(Console.ReadLine());

                Console.WriteLine("Enter age: ");
                ages.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"{names[i]} is {ages[i]} years old.");
            }



            Console.ReadKey();
        }
    }
}
