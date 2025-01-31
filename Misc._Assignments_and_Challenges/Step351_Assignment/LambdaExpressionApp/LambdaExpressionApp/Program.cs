using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionApp
{
    internal class Program
    {
        static void Main()
        {
            //Instantiates the Employee class as the employees list, then adds 10 distinct items
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, FirstName = "Joe", LastName = "Johnson" });
            employees.Add(new Employee { Id = 2, FirstName = "Nancy", LastName = "Drew" });
            employees.Add(new Employee { Id = 3, FirstName = "Jill", LastName = "Jillian" });
            employees.Add(new Employee { Id = 4, FirstName = "Jack", LastName = "Jackson" });
            employees.Add(new Employee { Id = 5, FirstName = "Joe", LastName = "Doe" });
            employees.Add(new Employee { Id = 6, FirstName = "Matt", LastName = "Mattson" });
            employees.Add(new Employee { Id = 7, FirstName = "Eva", LastName = "Evans" });
            employees.Add(new Employee { Id = 9, FirstName = "Ruth", LastName = "Rutherford" });
            employees.Add(new Employee { Id = 10, FirstName = "Kara", LastName = "Karachev" });

            //Instantiates another list of the Employee class, forEachJoeList. Then, a foreach loop iterates over the items
            // of the employees list and adds every item where the the FirstName property has the value of "Joe" to the 
            // forEachJoeList list
            List<Employee> forEachJoeList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    forEachJoeList.Add(employee);
                }
            }

            //Instantiates another list of the Employee class, lambdaJoeList. Then a lambda expression identifies the items
            // where the the FirstName property has the value of "Joe" and adds them to the lambdaJoeList list
            List<Employee> lambdaJoeList = new List<Employee>(employees.Where(employee => employee.FirstName == "Joe"));

            //Instantiates another list of the Employee class, lambdaIdFiveList. Then a lambda expression identifies the
            // items where the Id property has a value higher than 5 and adds them to the lambdaIdFiveList list
            List<Employee> lambdaIdFiveList = new List<Employee>(employees.Where(employee => employee.Id > 5));

            //Prints a string header, then a foreach loop iterates over a concatenated list of the three filtered lists, to
            // print the first- and last names of each employee in the filtered lists
            Console.WriteLine("The names in all my filtered lists are:");
            foreach (Employee employee in forEachJoeList.Concat(lambdaJoeList).Concat(lambdaIdFiveList))
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
            Console.ReadLine();
        }
    }

    //Creates the Employee class with an integer Id attribute and two string attributes of FirstName and LastName
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
