using System; //Calls the base class library

namespace mathAndComparisonApp //Organizes the following code in the mathAndComparisonApp namespace
{
    internal class Program //Creates a class as a console application
    {
        static void Main() //Tells the compiler to run the following code, without instantiating the class or returning a value
        {
            Console.WriteLine("Please enter a number to multiply by 50"); //Prints the math problem to promt user input
            string multInput = Console.ReadLine(); //Turns the user input into a string variabel called multInput
            int multOutput = Convert.ToInt32(multInput) * 50; //Turns the multInput variable into an integer, mulitplies it by 50 and establishes the output as the integer variable multOutput
            Console.WriteLine(multInput + " times 50 = " + multOutput); //Prints the full problem and answer using the input and output variables

            Console.WriteLine("Please enter a number to add to 25"); //Prints the math problem to promt user input
            string addInput = Console.ReadLine(); //Turns the user input into a string variabel called addInput
            int addOutput = Convert.ToInt32(addInput) + 25; //Turns the addInput variable into an integer, adds 25 to it and establishes the output as the integer variable addOutput
            Console.WriteLine(addInput + " + 25 = " + addOutput); //Prints the full problem and answer using the input and output variables

            Console.WriteLine("Please enter a number to divide by 12.5"); //Prints the math problem to promt user input
            string divInput = Console.ReadLine(); //Turns the user input into a string variabel called divInput
            double divOutput = Convert.ToDouble(divInput) / 12.5; //Turns the divInput variable into a double, divides it by 12.5 and establishes the output as the double variable divOutput
            Console.WriteLine(divInput + " divided by 12.5 = " + divOutput); //Prints the full problem and answer using the input and output variables

            Console.WriteLine("Please enter a number to see if it's greater than 50"); //Prints the math problem to promt user input
            string greaterInput = Console.ReadLine(); //Turns the user input into a string variabel called greaterInput
            bool greaterOutput = Convert.ToDouble(greaterInput) > 50; //Turns the greaterInput variable into an double, states that it is greater than 50 and establishes the output as the boolean variable greaterOutput
            Console.WriteLine("Is " + greaterInput + " greater than 50?: " + greaterOutput); //Prints the full problem and answer using the input and output variables

            Console.WriteLine("Please enter a number to get it's remainder when divided by 7"); //Prints the math problem to promt user input
            string modInput = Console.ReadLine(); //Turns the user input into a string variabel called modInput
            double modOutput = Convert.ToDouble(modInput) % 7; //Turns the modInput variable into an double, divides it by 7, returns the remainder and establishes the output as the double variable modOutput
            Console.WriteLine("The remainder of " + modInput + " is " + modOutput + " when divided by 7"); //Prints the full problem and answer using the input and output variables

            Console.ReadLine(); //Makes the console keep displaying the last operation after it is completed
        }
    }
}
