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

            // Solution 1 - regular
            const int angleCount = 3;
            int angleSum = 0;

            for (int i = 0; i < angleCount; i++)
            {
                Console.WriteLine($"Enter angle {i - 1}");
                int angleInput = Convert.ToInt32(Console.ReadLine());
                
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

            //// Solution 2 - using array ////
            int[] angles2 = new int[angleCount];
            int angleSum2 = 0;

            // a for loop to accept and save angles inside an array
            for (int i = 0; i < angleCount; i++)
            {
                Console.WriteLine($"Enter angle {i + 1}");
                int angleInput2 = Convert.ToInt32(Console.ReadLine());

                // store angles in an array
                angles2[i] = angleInput2;

                // add new angle value to angleSum value
                //angleSum += angles[i];
            }

            // a foreach loop to sum the angles stored in the array
            foreach (int angle2 in angles2)
            {
                angleSum2 += angle2;
            }

            // check if the total sum of angleSum is equal to 180 to confirm the
            // angles form a right angle triangle. 
            if (angleSum2 == 180)
            {
                Console.WriteLine("Angles form a right angle triangle.");
            }
            else
            {
                Console.WriteLine("Angles do not form a right angle triangle.");
            }



            /*
             * TASK     TASK    TASK
             * 
             * PASSWORD VALIDATOR
             * Write a program that asks the user to enter a password.
             * If the user enters the right password,the program should
             * tell them they are logged in to the system.
             * Otherwise, the program should ask them to re-enter the password.
             * The user should only get five tries to enter the password, after which point
             * the program should tell them that they are kicked off of the system.
             * 
             * HINTS
             * Take the user's input dynamically by asking them to enter it.
             * You can write two functions: one that handles the password checking and one that checks
             * if the password is correct and displays the message accordingly.
             * 
             * RULES FOR THE PASSWORD
             * The password must be at least 6 characters long.
             * The password must contain at least one uppercase letter (A–Z).
             * The password must contain at least one lowercase letter (a–z).
             * The password must contain at least one digit (0–9).
             */



            Console.ReadKey();
        }
    }
}
