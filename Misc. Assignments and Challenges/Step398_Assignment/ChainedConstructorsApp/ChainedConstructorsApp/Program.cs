using System;
using System.Collections.Generic;

namespace ChainedConstructorsApp
{
    internal class Program
    {
        static void Main()
        {
            //Creates a constant string variable and prints it
            const string welcomeMessage = "Welcome to the app";
            Console.WriteLine(welcomeMessage + "\n");

            //Promts the user to enter their first and last names, then turns those inputs into string variables
            Console.WriteLine("What is your first name?");
            string firstNameInput = Console.ReadLine();
            Console.WriteLine("And what is your last name?");
            string lastNameInput = Console.ReadLine();

            //Instantiates two User objects and passes in just the first name input or both inputs respectively. Two
            // messages are then printed to exemplify that when calling the lastName property on an object that only
            // has one paramter passed in, it will output the default value.
            User user1 = new User(firstNameInput, lastNameInput);
            User user2 = new User(firstNameInput);
            Console.WriteLine("Hello " + user1.firstName + " " + user2.lastName);
            Console.WriteLine("I believe your last name is actually " + user1.lastName);
            
            //Instantiates a dictionary with the inputs and decleares it implicity as the fullNames variable. A 
            // foreach loop is then used to identify the KVP in the dictionary and print it
            var fullNames = new Dictionary<string, string>() { { firstNameInput, lastNameInput } };
            foreach (var fullName in fullNames)
            {
                Console.WriteLine(fullName);
            }
        }
    }
    public class User
    {
        //Establishes two public string properties to be called upon by subclasses
        public string firstName;
        public string lastName;

        //Creates a User class that takes in the first name input and chains to the overloaded class that take in both
        // inputs. For the lastName string it assigns a default value regradless of the input
        public User(string firstNameInput) : this(firstNameInput, "<insert last name>") { }

        //Creates a User class that takes in both inputs and establishes their values as the values of the two public 
        // properties
        public User(string firstNameInput, string lastNameInput) 
        {
            this.firstName = firstNameInput;
            this.lastName = lastNameInput;
        }
    }
}
