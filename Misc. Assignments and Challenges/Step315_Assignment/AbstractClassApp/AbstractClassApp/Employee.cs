using System;

namespace AbstractClassApp
{
    //Creates the public class Employee, that inherits the properties of the Person class
    public class Employee: Person
    {
        //Calls and overrides the SayName method from the Person class, giving it functionality and the ability to be
        // instantiated within the context of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
