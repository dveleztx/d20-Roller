using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d20_Roller
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variables
            char repeat;
            int numSides, numDice, current, total;

            // Random Object
            Random dice = new Random();

            // User Prompt
            while (true)
            {
                // Initialize total to zero
                total = 0;

                // Pick number of sides on a die
                numSides = numberOfSides();

                Console.WriteLine($"Number of sides chosen is: {numSides}");

                // Pick how many dice to roll
                numDice = numberOfDice();

                // Roll the Dice
                for (int i = 0; i < numDice; i++)
                {
                    current = dice.Next(numSides) + 1;
                    Console.WriteLine($"Roll {i + 1}: {current}");
                    total += current;
                }

                // Print total output
                Console.WriteLine($"Total output is: {total}");

                // Check to Repeat
                repeat = Char.ToLower(loopCheck());

                if (repeat == 'y')
                {
                    continue;
                }
                else
                {
                    break;
                }
                
            }

            Console.ReadKey();

        }

        static int numberOfSides()
        {

            // Function Variable
            int sides;

            // Input Validation and Logic
            while (true)
            {

                try
                {
                    Console.WriteLine("How many sides are on this die? (enter a number)");

                    sides = Convert.ToInt32(Console.ReadLine());
                    break;

                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a valid number.");
                    continue;
                }

            }

            // Return number of sides
            return sides;

        }

        static int numberOfDice()
        {
            // Function Variable
            int number;

            // Input Validation and Logic
            while (true)
            {
                try
                {
                    Console.WriteLine($"How many of this die do you want to roll?");

                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a valid number.");
                    continue;
                }
            }

            // Return number
            return number;
        }

        static char loopCheck()
        {
            // Function Variable
            char checker;

            while (true)
            {
                try
                {
                    Console.WriteLine("Would you like to do a new roll? (y or n)");

                    checker = Convert.ToChar(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a valid entry");
                    continue;
                }
            }

            return checker;
        }
    }
}
