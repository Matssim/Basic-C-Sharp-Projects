using System;
using System.Collections.Generic;

namespace ListAndArrayApp
{
    internal class Program
    {
        static void Main()
        {
            //Establishes a 3-string long array of capitals and assigns a string for each index
            string[] capitals = new string[3];
            capitals[0] = "London";
            capitals[1] = "Oslo";
            capitals[2] = "Tokyo";
            //Prints a promt for the user to enter an index corresponding the country and capital, then reads the input and converts it to an integer
            Console.WriteLine("Please select the index of the countries listed below to see what it's capital city is \n0 = United Kingdom \n1 = Norway \n2 = Japan");
            int countryIndex = Convert.ToInt32(Console.ReadLine());
            //Establishes an if/else statement that prints the corresponding string to the index or an error message if the user selects an invalid index
            if (countryIndex > 2)
            {
                Console.WriteLine("That is not a valid index");
            }
            else
            {
                Console.WriteLine(capitals[countryIndex]);
            }

            //Establishes an integer array and adds integers 1-6 to the corresponding indexes 0-5
            int[] numArray = new int[] { 1, 2, 3, 4, 5, 6 };
            //Prints a promt for the user to enter an index corresponding to a value of 1 more than the index, then reads the input and converts it to an integer
            Console.WriteLine("Please type a number between 0 and 5 to add it to 1");
            int numberIndex = Convert.ToInt32(Console.ReadLine());
            //Establishes an if/else statement that prints the corresponding integer value to the index or an error message if the user selects an invalid index
            if (numberIndex > 5)
            {
                Console.WriteLine("That is not a number between 0 and 5");
            }
            else
            {
                Console.WriteLine(numArray[numberIndex]);
            }

            //Establishes a list fo strings and adds a string to the first two indexes
            List<string> doors = new List<string>();
            doors.Add("That is not the correct door");
            doors.Add("That is the correct door, you win!");
            //Prints a promt for the user to enter an index corresponding to a one of the two populated indexes,then reads the input and converts it to an integer
            Console.WriteLine("Please type 0 or 1 to select a door and sse if you win");
            int doorIndex = Convert.ToInt32(Console.ReadLine());
            //Establishes an if/else statement that prints the corresponding string value to the index or an error message if the user selects an invalid index
            if (doorIndex > 1)
            {
                Console.WriteLine("No door by that number");
            }
            else
            {
                Console.WriteLine(doors[doorIndex]);
            }
        }
    }
}
