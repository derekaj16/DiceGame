using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare all variables
            Random rnd = new Random();
            int numRolls;
            int dice1;
            int dice2;
            int total;
            int percent;
            int[] numRollsPerNum = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // Begin the game, ask user for the number of rolls they want to do
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");
            numRolls = Int32.Parse(Console.ReadLine());


            // Roll the dice
            for (int i = 0; i < numRolls; i++)
            {
                // Get number rolled
                dice1 = rnd.Next(1, 7);
                dice2 = rnd.Next(1, 7);
                total = dice1 + dice2;

                // Increment that number in its array spot [2,3,...12]
                numRollsPerNum[total - 2]++;
            }

            // Print results
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach \" * \" represents 1 % of the total number of rolls.\nTotal number of rolls = " + numRolls + ".\n");
            
            for(int i = 0; i < numRollsPerNum.Length; i++)
            {
                // Calculate percentage for a single number and print percentage in stars
                percent = Convert.ToInt32(Math.Round(Convert.ToDouble(numRollsPerNum[i]) / Convert.ToDouble(numRolls) * 100));
                string stars = new string('*', percent);
                Console.WriteLine((i + 2) + ": " + stars);
            }
        }
    }
}
