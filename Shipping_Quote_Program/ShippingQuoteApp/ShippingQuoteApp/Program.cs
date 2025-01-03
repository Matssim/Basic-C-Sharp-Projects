using System; //Calls the base class library

namespace ShippingQuoteApp //Organizes the following code in the ShippingQuoteApp namespace
{
    internal class Program //Creates a class as a console application
    {
        static void Main() //Tells the compiler to run the following code, without instantiating the class or returning a value
        {
            //Prints the program header/name
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //The below block prints a promt for the  user to input the package weight, read that input and converts it to the 
            // double variable "weight". It then deploys an if statement to print a message and end the program if the input
            // is above 50(lbs). Otherwise it continues executing the following else statement
            Console.WriteLine("Please enter the package weight (lbs):");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50.00)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            //The below block prints promts for the user to input the package width, height and lenght, respectively. It then 
            // reads those inputs and converts it to the commensurate double variables. It then adds together those variables 
            // to establish the total "dimension" variable. It then multiplies the individual dimension variables and weight, 
            // and divides that by 100, establishing the quote variable.
            else
            {
                Console.WriteLine("Please enter the package width:");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                double length = Convert.ToDouble(Console.ReadLine());
                double dimension = width + height + length;
                double quote = width * height * length * weight / 100;
                //The following nested if statement prints a message and ends the program if the total dimension variable is 
                // above 50. Otherwise it continues executing the following else statement
                if (dimension > 50.00)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                //The following statement prints a message along with the quote and ends the program
                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\nThank You!");
                    Console.ReadLine();
                }
            }
        }
    }
}
