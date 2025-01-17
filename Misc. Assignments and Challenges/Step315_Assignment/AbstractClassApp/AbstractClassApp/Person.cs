
namespace AbstractClassApp
{
    //Creates the public Person class that cannot be directly instantiated (abstract)
    public abstract class Person
    {
        //Creates two string variables, FirstName and LastName, that can be assisgned values when an object of a child  
        // class (that is not abstract) is instantiated
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Creates a method that does not return anything and that is not instantiated(abstract)
        public abstract void SayName();
    }
}
