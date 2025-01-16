using System;

namespace InheritanceApp
{
    internal class Program
    {
        static void Main()
        {
            //Instantiates an object of the Employee class called sampleStudent, inherits the FirstName and Lastname 
            // properties, which it assigns the values "Sample" and "Student" to respectively. 
            Employee sampleStudent = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Calls the SayName method of the Person class on the Employee object sampleStudent to print the full name
            sampleStudent.SayName();
            Console.ReadLine();
        }
    }
}
