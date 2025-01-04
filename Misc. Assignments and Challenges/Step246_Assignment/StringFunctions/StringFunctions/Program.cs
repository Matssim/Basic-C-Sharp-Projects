using System;
using System.Text;

namespace StringFunctions
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your preferred prefix?");
            string prefix = Console.ReadLine();
            prefix = prefix.ToUpper(); //Converts string to all uppercase letters
            Console.WriteLine("Please enter your email address:");
            string email = Console.ReadLine();

            Console.WriteLine("Hello, " + prefix + ". " + name + "\nWe'll reach out to you on " + email); //concatenates strings

            StringBuilder contact = new StringBuilder(); //adds each listed element to the "contact" string variable
            contact.Append("We have registered:\n");
            contact.Append(email);
            contact.Append("\nas your primary email address");

            Console.WriteLine(contact);
            Console.ReadLine();

        }
    }
}
