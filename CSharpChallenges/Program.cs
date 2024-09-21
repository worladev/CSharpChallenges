using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Main Challenges Solution Project.");

            /* TASK
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
             * TASK
             * 
             */
            Console.ReadKey();
        }
    }
}
