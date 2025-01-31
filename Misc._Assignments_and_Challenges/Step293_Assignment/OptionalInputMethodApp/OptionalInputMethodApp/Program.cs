using System;

namespace OptionalInputMethodApp
{
    internal class Program
    {
        static void Main()
        {
            //Establishes the intended code to run
            try
            {
                //Prints a promt for the user to enter a number, then reads and converts that input to the UserInt1 integer variable
                Console.WriteLine("Please enter a number to add to five");
                int UserInt1 = Convert.ToInt32(Console.ReadLine());
                //Prints another promt for the user to enter a number, or to just skip it, then reads and converts that input to the UserInput2
                // string variable
                Console.WriteLine("Please enter a number to add if you would like - If you don't want to add another number, just press enter");
                string UserInput2 = Console.ReadLine();
                //Establishes that if the user enters nothing for the second number, the integer variable UserInt2 is given the value of 0. The
                // AddToFive() method is then instanitated as additionResult, passing in UserInt1 and UserInt2. The result is then printed.
                if (UserInput2 == "")
                {
                    int UserInt2 = 0;
                    int additionResult = MathOperations.AddToFive(UserInt1, UserInt2);
                    Console.WriteLine("Your input + 5 = " + additionResult);

                }
                //Establishes that if the above if condition is not met, the same function runs, except the UserInput2 is converted into the 
                // UserInt2 variable
                else
                {
                    int UserInt2 = Convert.ToInt32(UserInput2);
                    int additionResult = MathOperations.AddToFive(UserInt1, UserInt2);
                    Console.WriteLine("Your input + 5 = " + additionResult);
                }
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
