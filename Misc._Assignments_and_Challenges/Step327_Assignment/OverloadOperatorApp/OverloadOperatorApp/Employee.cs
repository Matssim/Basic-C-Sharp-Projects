
namespace OverloadOperatorApp
{
    //Creates the public class Employee
    public class Employee
    {
        //Establishes three attributes for objects of the class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Overloads the == and != operators so that it only compares the Id attributes of the objects that are passed 
        // in and returns a boolean value denoting whether the Id's match 
        public static bool operator==(Employee sampleEmployee1, Employee sampleEmployee2)
        {
            if (sampleEmployee1.Id == sampleEmployee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator!=(Employee sampleEmployee1, Employee sampleEmployee2)
        {
            if (sampleEmployee1.Id != sampleEmployee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
