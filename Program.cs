
/*
 * Find Pi to the n-th digit provided by the user
 */

namespace PiFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Pi as constant value
            const double pi = Math.PI;
            // Set limit/precision of what to find pi to
            const int maxPrecision = 15;
            // Valid input flag
            bool validInput = false;
            // Holds safe number entered by user
            int precision = 0;

            // Introduce the program and get the number
            do
            {
                Console.WriteLine("Find Pi to Nth digi");
                Console.WriteLine("Enter the number of decimal precision of pi (15 max): ");
                string input = Console.ReadLine();
                // Check the input was a number
                if (int.TryParse(input, out int value))
                {
                    if (value >= 0 && value <= maxPrecision)
                    {
                        precision = value;
                        validInput = true;
                    }
                }
            } while (!validInput);
            
            // Input was a safe number so we can generate pi now
            Console.WriteLine(Math.Round(pi, precision));
        }
    }
}