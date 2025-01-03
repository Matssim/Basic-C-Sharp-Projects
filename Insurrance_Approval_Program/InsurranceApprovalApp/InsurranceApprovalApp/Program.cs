using System; //Calls the base class library

namespace InsurranceApprovalApp //Organizes the following code in the InsurranceApprovalApp namespace
{
    internal class Program //Creates a class as a console application
    {
        static void Main() //Tells the compiler to run the following code, without instantiating the class or returning a value
        {
            //Prints the program header/name
            Console.WriteLine("Please answer the questions below to apply for insurrance approval");

            //Prints the question, promting the user to enter their age 
            Console.WriteLine("What is your age?");
            //Reads the user input, converts it to an integer and establishes it as the applicantAge variable
            int applicantAge = Convert.ToInt32(Console.ReadLine());

            //Prints the question, promting the user to answer in a way that can be converted to boolean, whether they have have any DUIs 
            Console.WriteLine("Have you ever had a DUI? (Please answer \"true\" if you do and \"false\" if you don't)");
            //Reads the user input, converts it to a boolean and establishes it as the applicantDUI variable
            bool applicantDUI = Convert.ToBoolean(Console.ReadLine());

            //Prints the question, promting the user to enter the amount of speeding tickets they have recieved
            Console.WriteLine("How many speeding tickets do you have?");
            //Reads the user input, converts it to an integer and establishes it as the applicantTickets variable
            int applicantTickets = Convert.ToInt32(Console.ReadLine());

            //Establishes the booelan applicantQualified that is true if the user enters an age over 15, no DUIs and 3 tickets or less
            bool applicantQualified = applicantAge > 15 && applicantDUI == false && applicantTickets <= 3;
            //Prints the applicantQualified variable to indicate whether the user's input consitiute approval for insurrance
            Console.WriteLine("Qualified?\n" + applicantQualified);

            Console.ReadLine(); //Makes the console keep displaying the last operation after it is completed
        }
    }
}
