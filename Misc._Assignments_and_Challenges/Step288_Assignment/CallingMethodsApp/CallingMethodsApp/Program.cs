using System;

namespace CallingMethodsApp
{
    internal class Program
    {
        static void Main()
        {
            //Prints a promt for the user to enter a number
            Console.WriteLine("Please enter a number to perform math operations on");
            //Reads the user input and establishes it as the integer variable "Userint"
            int Userint = Convert.ToInt32(Console.ReadLine());
            //Passes the Userint variable to the "AddToFive()" method in the "MathOperations" class and establishes the output
            // as the "additionResult" variable and prints it to a string outlining the math problem 
            int additionResult = MathOperations.AddToFive(Userint);
            Console.WriteLine(Userint + " + 5 = " + additionResult);
            //Passes the Userint variable to the "MultiplyByFive()" method in the "MathOperations" class and establishes the output
            // as the "multiplicationResult" variable and prints it to a string outlining the math problem 
            int multiplicationResult = MathOperations.MultiplyByFive(Userint);
            Console.WriteLine(Userint + " * 5 = " + multiplicationResult);
            //Passes the Userint variable to the "DivideByTwo()" method in the "MathOperations" class and establishes the output
            // as the "divisionResult" variable and prints it to a string outlining the math problem 
            int divisionResult = MathOperations.DivideByTwo(Userint);
            Console.WriteLine(Userint + " / 2 = " + divisionResult);
            Console.ReadLine();
        }
    }
}
