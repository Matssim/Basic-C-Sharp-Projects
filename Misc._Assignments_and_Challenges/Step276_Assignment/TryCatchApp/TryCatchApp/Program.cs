using System;
using System.Collections.Generic;

namespace TryCatchApp
{
    internal class Program
    {
        static void Main()
        {
            //Establishes the intended code to run
            try
            {
                //Establishes a list of integers as dividends, asks the user to enter a number for the divisor and 
                // establishes the user input as the integer variable "divisor"
                List<int> numlist = new List<int>() { 2, 4, 6, 8 };
                Console.WriteLine("Please add a divisor for the list");
                int divisor = Convert.ToInt32(Console.ReadLine());
                //Divides each number in the list by the user input and prints the result of each division
                foreach (int num in numlist)
                {
                    int result = num / divisor;
                    Console.WriteLine(result);
                }
            }
            //Cathes any execption and assign is to the variable "ex"
            catch (Exception ex)
            {
                //Prints the message corresponding to the error and a custom error message
                Console.WriteLine(ex.Message + "\nPlease enter a whole number above zero");
            }
            //Establishes an end statement that will print regardless of the error handling 
            finally
            {
                Console.WriteLine("This is the end of the program");
                Console.ReadLine();
            }
        }
    }
}
