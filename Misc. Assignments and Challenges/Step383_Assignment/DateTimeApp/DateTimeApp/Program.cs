using System;

namespace DateTimeApp
{
    internal class Program
    {
        static void Main()
        {
            //Prints the current date and time
            Console.WriteLine(DateTime.Now);
            //Prints a promt for the user to enter a number
            Console.WriteLine("Enter an amount of hours to see what time it will be then");
            //Reads the user input and converts it into the double inputHours
            double inputHours = Convert.ToDouble(Console.ReadLine());
            //Executes the AddHours method on the Now attribute of Datetime, passing in inputHours, effectively adding 
            // the input as hours to the current date and time, then establishing that as the DateTime object outputTime
            DateTime outputTime = DateTime.Now.AddHours(inputHours);
            //Prints the inputHours and outputTime to a string
            Console.WriteLine("In " + inputHours + " hour(s)" + " the time will and date will be " + outputTime);
        }
    }
}
