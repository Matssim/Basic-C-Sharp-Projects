using System;

namespace MainMethodApp
{
    internal class Program
    {
        static void Main()
        {
            //Establishes the intended code to run
            try
            { 

                //Prints a promt for the user to enter a number
                Console.WriteLine("Please enter a number to subtract two from it");
                //Reads the user input and establishes it as the integer variable "UserInt"
                int UserInt = Convert.ToInt32(Console.ReadLine());
                //Instantiates the MathOperations class as subtractionResult, calling in the SubtractTwo method, passing
                // in the UserInt interger and prints the result
                int subtractionResult = MathOperations.SubtractTwo(UserInt);
                Console.WriteLine(UserInt + " - 2 = " + subtractionResult);

                //Prints a promt for the user to enter a number
                Console.WriteLine("Please enter a decimal number to increase it by 20%");
                //Reads the user input and establishes it as the decimal variable "UserDec"
                decimal UserDec = Convert.ToDecimal(Console.ReadLine());
                //Instantiates the MathOperations class as increasedDec, calling in the IncreaseNumber method, passing
                // in the UserDec decimal and prints the result
                decimal increasedDec = MathOperations.IncreaseNumber(UserDec);
                Console.WriteLine("if you increase " + UserDec + " by 20%, you get " + increasedDec);

                //Prints a promt for the user to enter a number
                Console.WriteLine("Please enter a whole number to multiply the increased number by");
                //Reads the user input and establishes it as the string variable "UserMult"
                string UserMult = Console.ReadLine();
                //Instantiates the MathOperations class as finalResult, calling in the IncreaseNumber method, passing
                // in the UserDec decimal and the UserMult string. Then, the result is printed
                int finalResult = MathOperations.IncreaseNumber(UserDec, UserMult);
                Console.WriteLine(increasedDec + " * " + UserMult + " = " + finalResult);
            }

            //Cathes any execption and assign is to the variable "ex"
            catch (Exception ex)
            {
                //Prints the message corresponding to the error and a custom error message
                Console.WriteLine(ex.Message + "\nPlease enter values as instructed");
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
