using System;

namespace ParsingEnumsApp
{
    internal class Program
    {
        static void Main()
        {
            //Establishes the intended code to run
            try
            {
                //Prints a promt for the user to enter a day in the week
                Console.WriteLine("Please enter a day in the week");
                //Creates the booelean variable dayMatched and gives it the value of false, which is passed to the 
                // following while loop. The nested code will run until the user enters a string value that either
                // matches a day or an input that triggers an exception
                bool dayMatched = false;
                while (!dayMatched)
                {
                    //Reads the user input and assigns it as the string value of the input variable
                    string input = Console.ReadLine();
                    //Creates a foreach loop that iterates over each constant in the Days enum by name
                    foreach (string day in Enum.GetNames(typeof(Days)))
                    {
                        //Creates an if statement that converts the input and each constant in the Days enum to 
                        // uppercase (to account for case) and triggers the following code if the input matches
                        // a constant 
                        if (input.ToUpper() == day.ToUpper())
                        {
                            //Parses the underlying value of the enum for the matching constant, converts it to 
                            // an integer, establishes it as the dayMatch variable and adds 1 to account for the
                            // first value starting at 0. It then prints both the value and name of the matching
                            // constant to a string, declares dayMatched as true, effectively ending the loop  
                            // and breaks the statement
                            int dayMatch = Convert.ToInt32(Enum.Parse(typeof(Days), day)) + 1;
                            Console.WriteLine(day + " is day number " + dayMatch + " in the week");
                            dayMatched = true;
                            break;
                        }
                    }
                    //Prints another promt for the user to enter a day in the week if the user input does not 
                    // match a constant in the enum and the while loop continues
                    if (!dayMatched)
                    {
                        Console.WriteLine("Please enter an actual day of the week");
                    }
                }
            }
            //Cathes any execption and assign is to the variable "ex"
            catch (Exception ex)
            {
                //Prints the message corresponding to the error and a custom error message
                Console.WriteLine(ex.Message + "\nPlease enter an actual day of the week");
            }
            //Establishes an end statement that will print regardless of the error handling 
            finally
            {
                Console.WriteLine("This is the end of the program");
                Console.ReadLine();
            }
        }
    }

    //Creates the enum Days and establishes each day of a week as a constant
    public enum Days
    {
        Monday, 
        Tuesday, 
        Wednesday,
        Thursday,
        Friday, 
        Saturday,
        Sunday
    }
}
