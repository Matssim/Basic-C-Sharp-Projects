using System;

namespace InterfaceApp
{
    //Creates the public class Employee, that inherits the properties of the Person class
    public class Employee: Person, IQuittable
    {
        //Calls and overrides the SayName method from the Person class, giving it functionality and the ability to be
        // instantiated within the context of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        //Calls the Quit method from the IQuittable interface and assigns it the functionality of printing the FirstName
        // and LastName properties of a IQuittable interface object by inheriting the properties of the Employee class, 
        // which in turn inherits those properties from the Person class
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit");
        }
    }
}
