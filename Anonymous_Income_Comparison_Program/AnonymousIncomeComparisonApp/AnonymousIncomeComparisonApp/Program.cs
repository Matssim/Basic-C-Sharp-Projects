using System; //Calls the base class library

namespace AnonymousIncomeComparisonApp //Organizes the following code in the AnonymousIncomeComparisonApp namespace
{
    internal class Program //Creates a class as a console application
    {
        static void Main() //Tells the compiler to run the following code, without instantiating the class or returning a value
        {
            //Prints the program header/name
            Console.WriteLine("Anonymous Income Comparison Program");
            
            //Prints person 1 header and a promt for the  user to input person 1's hourly rate \n escape character to jump on line down
            Console.WriteLine("Person 1\nPlease enter the hourly rate");
            //Reads the user input, converts it (from a string) to a double and assigns it as the variable person1Rate
            double person1Rate = Convert.ToDouble(Console.ReadLine());
            //Prints a promt for the user to input person 1's hours worked per week
            Console.WriteLine("Please enter the hours worked per week");
            //Reads the user input, converts it (from a string) to a double and assigns it as the variable person1Hours
            double person1Hours = Convert.ToDouble(Console.ReadLine());
            //Multiplies the input rate, hours per week and 52(weeks of the year) to calculate person 1's total annual salary
            double person1Salary = person1Rate * person1Hours * 52;

            //The below block of code recreates the functionality in the above block of code to establish and calculate person 2's total annual salary
            Console.WriteLine("Person 2\nPlease enter the hourly rate");
            double person2Rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the hours worked per week");
            double person2Hours = Convert.ToDouble(Console.ReadLine());
            double person2Salary = person2Rate * person2Hours * 52;

            //Prints person 1's and person 2's total annual salaraies, respectively 
            Console.WriteLine("Annual salary of Person 1:\n" + person1Salary);
            Console.WriteLine("Annual salary of Person 2:\n" + person2Salary);

            //Establishes a boolean variable "salarycomparison" based on the statement that person 1's total annual salary is greater than person 2's total annual salary
            bool salarycomparison = person1Salary > person2Salary;
            //Prints the question of whether person 1 makes more than person 2 and adds the 
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + salarycomparison);

            Console.ReadLine(); //Makes the console keep displaying the last operation after it is completed
        }
    }
}
