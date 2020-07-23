using System;

namespace PowersTable
{
    class Program
    {

        // This method calculates the squares and cubes for a given number
        public static void DisplaySquaresAndCubes(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                double iSquared = Math.Pow(i, 2);
                double iCubed = Math.Pow(i, 3);
                //Console.WriteLine(i + "\t" + iSquared + "\t" + iCubed);
                Console.WriteLine("{0,-20} {1,-20} {2,-20}", i, iSquared, iCubed);
            }
        }
        static void Main(string[] args)
        {
            bool bOption = true;

            while (bOption)
            {
                // Get input from the user
                Console.WriteLine("Please enter an number to find Squares and Cubes");

                // Validate the user input
                int num;
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid Entry! Please enter another number");
                }

                // Display prompts
                //Console.WriteLine("Number" + "\t" + "Squared" + "\t" + "Cubed");
                //Console.WriteLine("======" + "\t" + "=======" + "\t" + "=====");

                Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Number", "Squared", "Cubed");
                Console.WriteLine("{0,-20} {1,-20} {2,-20}", "======",  "=======", "=====");

                // Find and display the square and cube for each number
                DisplaySquaresAndCubes(num);                              

                // Check if the user wants to continue with another number
                Console.WriteLine("Do you wish to continue with a new number? y/n");
                string option = Console.ReadLine().ToLower();

                //Exit pgm if the user doesn't want to continue
                if (option[0] == 'n')
                    bOption = false;
            }
        }
    }
}
