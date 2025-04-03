using System;

namespace ShippingQuoteCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduces the shipping service with a welcoming statement
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Retrieves the package weight information from the customer
            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());

            // Checks the package against the maximum weight restriction
            if (weight > 50)
            {
                // Delivers a message indicating the package is too heavy for shipping
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the application due to weight violation
            }

            // Asks for and stores the width of the package
            Console.WriteLine("Please enter the package width:");
            float width = Convert.ToSingle(Console.ReadLine());

            // Asks for and stores the height of the package
            Console.WriteLine("Please enter the package height:");
            float height = Convert.ToSingle(Console.ReadLine());

            // Asks for and stores the length of the package
            Console.WriteLine("Please enter the package length:");
            float length = Convert.ToSingle(Console.ReadLine());

            // Validates the package against dimensional constraints
            if (width + height + length > 50)
            {
                // Provides feedback that the package dimensions are unsuitable
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Terminates the application due to size violation
            }

            // Processes the shipping rate calculation for the package
            float quote = (height * width * length * weight) / 100;

            // Communicates the shipping cost to the customer in currency format
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Suspends program termination until user input is received
            Console.ReadKey();
        }
    }
}