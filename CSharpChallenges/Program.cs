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



            Console.ReadKey();
        }
    }
}
