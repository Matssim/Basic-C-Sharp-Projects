using System; //Calls the base class library

namespace DailyReport //Organizes the following code in the DailyReport namespace
{
    internal class Program //Creates a class as a console application
    {
        static void Main() //Tells the compiler to run the following code, without instantiating the class or returning a value
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report"); //Displays the headers on separate lines 
            Console.WriteLine("What is your name?"); //Displays the name question
            string userName = Console.ReadLine(); //Reads the user input and saves it as the string variable "userName"
            Console.WriteLine("What course are you on?"); //Displays the course question
            string courseName = Console.ReadLine(); //Reads the user input and saves it as the string variable "courseName"
            Console.WriteLine("What page number?"); //Displays the page number question
            string pageInput = Console.ReadLine(); //Reads the user input and saves it as the string variable "pageInput"
            int pageNumber = Convert.ToInt32(pageInput); //Converts the pageInput variable to the integer variable "PageNumber"
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"."); //Displays the help question, requesting a valid boolean input
            string helpInput = Console.ReadLine(); //Reads the user input and saves it as the string variable "helpInput"
            bool needHelp = Convert.ToBoolean(helpInput); //Converts the pageInput variable to the boolean variable "needHelp"
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics."); //Displays the positive experiences question
            string positiveExperiences = Console.ReadLine(); //Reads the user input and saves it as the string variable "positiveExperiences"
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific."); //Displays feedback question
            string feedback = Console.ReadLine(); //Reads the user input and saves it as the string variable "feedback"
            Console.WriteLine("How many hours did you study today?"); //Displays the hours question
            string hoursInput = Console.ReadLine(); //Reads the user input and saves it as the string variable "hoursinput"
            byte hoursStudied = Convert.ToByte(hoursInput); //Converts the pageInput variable to the byte variable "hoursStudied"
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!"); //Displays the exit statement 
        }
    }
}
