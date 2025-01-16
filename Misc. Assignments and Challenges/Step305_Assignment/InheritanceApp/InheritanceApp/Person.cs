using System;

namespace InheritanceApp
{
    //Creates the public Person class
    public class Person
    {
        //Creates two string variables, FirstName and LastName, that can be assisgned values when an object of the class 
        // is instantiated
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Creates a method that does not return anything, but prints the instantiated values to a string
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
