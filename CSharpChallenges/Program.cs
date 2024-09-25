using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Main Challenges Solution Project.");

            /* TASK    TASK    TASK
             * 
             * TIMES TABLE
             * Ask the user for a number x. Write a program to print x times table up to the 12th value.
             */

            // a default boolean variable to keep track of a valid number input.
            bool isValid = true;

            // a while loop to continue asking for number until a valid number is entered.
            while (isValid)
            {
                Console.WriteLine("Enter a number to print it's time table.");
                string userInput = Console.ReadLine();

                // an if statement to check if the number entered is valid using the TryParse function
                if (int.TryParse(userInput, out int value))
                {
                    // a for loop to print the times table
                    for (int i = 1; i <= 12; i++)
                    {
                        Console.WriteLine($"{i} * {value} = {value * i}");
                    }

                    // set the boolean value to false to terminate the while loop
                    isValid = false;
                }
                else
                {
                    Console.WriteLine("Invalid Number Entered.");
                }
            }



            /*
             * TASK     TASK    TASK
             * 
             * THE FIZZ BUZZ GAME
             */
            // FizzBuzz Game
            Console.WriteLine("WELCOME TO THE FIZZBUZZ GAME");

            // string userInput = Console.ReadLine();
            // int.TryParse(userInput, out int limit);

            // variable declaration
            int limit = 15;
            bool threeDiv;
            bool fiveDiv;

            for (int i = 1; i <= limit; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }



            /*
             * TASK     TASK    TASK
             * 
             * REVERSE A STRING
             * A program to accept a string from the user. Use a loop to print the string, and
             * print it's reverse.
             *
             */
            Console.WriteLine("Enter any string.");

            //accept string form user
            string message = Console.ReadLine();

            //use a for loop to display the string
            for (int i = 0; i <= message.Length; i++)
            {
                Console.Write(message[i]);
            }

            Console.WriteLine();

            //use a for loop to print the string in reverse
            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
                Thread.Sleep(500);
            }



            /*
             * TASK     TASK    TASK
             * 
             * RIGHT ANGLE TRIANGLE VALIDATOR
             * A program to accept 3 angles from the user, store them in an array.
             * Sum them up and check if the sum is a valid right angle triangle or not
             * 
             * HINT: use a for loop to accept and store the angle and a foreach loop
             * to sum them up.
             */
            int angleCount = 3;
            //int[] angles = new int[angleCount];
            int angleSum = 0;

            for (int i = 0; i < angleCount; i++)
            {
                Console.WriteLine($"Enter angle {i - 1}");
                int angleInput = Convert.ToInt32(Console.ReadLine());
                //angles.Append(angleInput);

                // add new angle value to angleSum value
                angleSum += angleInput;
            }

            // check if the total sum of angleSum is equal to 180 to confirm the
            // angles form a right angle triangle. 
            if (angleSum == 180)
            {
                Console.WriteLine("Angles form a right angle triangle.");
            }
            else
            {
                Console.WriteLine("Angles do not form a right angle triangle.");
            }



            Console.ReadKey();
        }
    }
}
