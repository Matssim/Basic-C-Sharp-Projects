using System;

namespace OverloadOperatorApp
{
    internal class Program
    {
        static void Main()
        {
            //Instantiates two objects of the Employee class with different values assigned to the attributes
            Employee sampleEmployee1 = new Employee() { Id = 1, FirstName = "Sample1", LastName = "Employee1" };
            Employee sampleEmployee2 = new Employee() { Id = 2, FirstName = "Sample2", LastName = "Employee2" };
            //Creates an if/else statement that deploys the overloaded == opertaor to compare only the Id property 
            // of the two Employee objects and prints the values to a string commensurate to that comparison
            if (sampleEmployee1 == sampleEmployee2)
            {
                Console.WriteLine(sampleEmployee1.FirstName + " " + sampleEmployee1.LastName + " and " + 
                    sampleEmployee2.FirstName + " " + sampleEmployee2.LastName + " has the same Id.");
            }
            else
            {
                Console.WriteLine(sampleEmployee1.FirstName + " " + sampleEmployee1.LastName + " and " +
                    sampleEmployee2.FirstName + " " + sampleEmployee2.LastName + " does not have the same Id.");
            }
            Console.ReadLine();
        }
    }
}
