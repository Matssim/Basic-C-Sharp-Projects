using System;

namespace InterfaceApp
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
            //Instatiates an object of the IQuittable interface called sampleEmployee, by calling the Employee class, 
            // which alows it to assign the FirstName and Lastname properties and popluate their values as "Sample" and
            // "Employee" respectively.
            IQuittable sampleEmployee = new Employee() { FirstName = "Sample", LastName = "Employee" };
            //Calls the Quit method of the Person class on the IQuittable object sampleEmployee to print the full name
            sampleEmployee.Quit();
            Console.ReadLine();
        }
    }
}
