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
            int numSides;

            // Random Object
            Random dice = new Random();

            // User Prompt
            while (true)
            {
                // Input Validation
                while (true)
                {

                    try
                    {
                        // Choose how many sides the die is
                        Console.WriteLine("How many sides are on this die? (enter a number)");

                        numSides = Convert.ToInt32(Console.ReadLine());
                        break;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You must enter a valid number.");
                        continue;
                    }

                }

                Console.WriteLine($"Number of sides chosen is: {numSides}");

                Console.ReadKey();
            }

        }
    }
}
