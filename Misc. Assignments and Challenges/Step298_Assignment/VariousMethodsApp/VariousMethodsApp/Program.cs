using System;

namespace VariousMethodsApp
{
    internal class Program
    {
        static void Main()
        {
            //Establishes the intended code to run
            try
            {
                //Prints promts for the user to enter a number, then reads and establishes that input as an integer variable
                Console.WriteLine("Please enter a number to divide it by 2");
                int UserInt1 = Convert.ToInt32(Console.ReadLine());
                //Instanitates divideOperation as an object of the MathOperations, then calls the DivideByTwo method, passing
                // in the user input
                MathOperations divideOperation = new MathOperations();
                divideOperation.DivideByTwo(UserInt1);

                //Prints a promt for the user to enter one or two numbers, then reads those inputs and establishes them as a 
                // integer variable for the first input and a string fro the second (in case the user doesn't enter a second
                // number
                Console.WriteLine("Please enter one or two numbers to see if the total is equal to or under 21, " +
                    "you can skip the second number by clicking enter");
                int UserInt2 = Convert.ToInt32(Console.ReadLine());
                string UserInt3 = Console.ReadLine();
                //Establishes that if the second input is empty, only the first input is passed to the pickANumber method in
                // the MathOperations class. The output is established as the boolean numbercheck variable.
                if (UserInt3 == "")
                {
                    bool numbercheck = MathOperations.pickANumber(UserInt2);
                    //The value of numbercheck value determines the output text
                    if (numbercheck)
                    {
                        Console.WriteLine("That is equal to or less than 21");
                    }
                    else
                    {
                        Console.WriteLine("That is more than 21");
                    }
                }
                //Establishes the same code block as above, but passes in the second input if the user enters a second number
                else
                {
                    bool numbercheck = MathOperations.pickANumber(UserInt2, UserInt3);
                    if (numbercheck)
                    {
                        Console.WriteLine("That is equal to or less than 21");
                    }
                    else
                    {
                        Console.WriteLine("That is more than 21");
                    }
                }

                //Prints a promt for the user to enter a number, then reads and establishes that input as an integer variable
                Console.WriteLine("Please enter a number to double it");
                int UserInt4 = Convert.ToInt32(Console.ReadLine());
                //Passes the input to the Double functio in the StaticMethods class
                StaticMethods.Double(UserInt4);
                
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
