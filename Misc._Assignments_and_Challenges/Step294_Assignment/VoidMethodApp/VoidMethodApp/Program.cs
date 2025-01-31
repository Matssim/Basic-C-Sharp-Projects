using System;

namespace VoidMethodApp
{
    internal class Program
    {
        static void Main()
        {
            //Prints promts for the user to enter 2 numbers, one at the time, then reads and establishes those inputs 
            // as integer variables
            Console.WriteLine("Please enter a number to add to five");
            int UserInt1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number to compare to the first number once it's added to five");
            int UserInt2 = Convert.ToInt32(Console.ReadLine());
            //Instantiates the mathOperations objects of the MathOperations class 
            MathOperations mathOperations = new MathOperations();
            //Uses the mathOperations object to call the AddToFiveAndCompare, passing in the user inputs as parameters
            mathOperations.AddToFiveAndCompare(UserInt1, UserInt2);
        }
    }
}
