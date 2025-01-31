using System; //Calls the base class library

namespace DoWhileApp //Organizes the following code in the DoWhileApp namespace
{
    internal class Program //Creates a class as a console application
    {
        static void Main() //Tells the compiler to run the following code, without instantiating the class or returning a value
        {
            Console.WriteLine("What is 2 + 2?"); //Prints the math problem and promts user to input an answer
            int answer = Convert.ToInt32(Console.ReadLine()); //Reads the input and converts it to the integer variable "answer"
            bool input = answer == 4; //States that if the answer is 4, the boolean variable input is true

            do //Establishes a block of code to execute until the expression of the below while loop is met
            {
                switch (answer) //Establishes a switch statement for the different values of the answer variable
                {
                    case 4: //Establishes the execution case for when the answer is 4
                        Console.WriteLine("That is correct!"); //Prints the message to the console
                        input = true; //Changes the value of the input variable to true (effectively ending the while loop)
                        break; //Ends the execution of the switch block
                    default: //Establishes the execution for all cases that are not specified (i.e. when the answer is not 4)
                        Console.WriteLine("That is not correct, try again:"); //Prints a promt for user to input another answer
                        answer = Convert.ToInt32(Console.ReadLine()); //Reads the input and assigns it as the new value of "answer"
                        break; //Ends the execution of the switch block
                }
            }
            while (!input); //Establishes the while loop to keep running while the boolean value of "input" is false
            Console.ReadLine(); //Makes the console keep displaying the last operation after it is completed
        }
    }
}
