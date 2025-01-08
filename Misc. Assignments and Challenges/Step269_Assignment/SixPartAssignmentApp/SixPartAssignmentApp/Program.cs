using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignmentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PART ONE ASSIGNMENT
            //Establishes an array of strings
            string[] baseStrings =
            {
                "The input was: ",
                "The user wrote: ",
                "The following was added to each string in the array: ",
            };
            //Prints a promt for the user to provide an input, then reads that input and turns it into a string variable
            Console.WriteLine("Please type something to add to each string in the array");
            string stringInput = Console.ReadLine();
            //Establishes a loop that iterates over the array strings and concatenates each of them with the input variable 
            foreach (string baseString in baseStrings)
            {
                string[] newStrings = { Convert.ToString(baseString + stringInput) };
                //Establishes a loop that prints each of the concatenated array strings one at the time
                foreach (string newstring in newStrings)
                {
                    Console.WriteLine(newstring);
                }
            }


            //PART TWO ASSIGNMENT
            //Establishes an array of three integers 
            int[] numbArray = { 0, 1, 2 };
            //Establishes a for loop that creates variable for the index "i", of each item in the array. It stops incrementing
            // when the number of indexes matches the length of the array/number of items
            for (int i = 0; i < numbArray.Length; i++)
            {
                //The below loop makes the console print one the first array item infinitely because the index "i" variable
                // is always more than -1, so the "while" condition is always met
                //--INFINITE LOOP--
                //while (numbArray[i] > -1)
                //{
                //    Console.WriteLine(numbArray[i]);
                //}
                //--END INFINITE LOOP--

                //The below statement corrects the infinite loop by using a conditional if statement that only prints the 
                // array items that have an index over -1. Since the above for loop only increments the index variable as 
                // long at it is less than the lenght of the array/number of items, the if condition is no longer met when 
                // there are no more indexes to compare to the condition (> -1). Therefore, it only prints the items in the 
                // array that have an index.
                if (numbArray[i] > -1)
                {
                    Console.WriteLine(numbArray[i]);
                }
            }


            //PART THREE ASSIGNMENT
            //Prints a promt for the user to enter a number higher than 5, reads the input an turns it into the integer
            // variable "numberInput"
            Console.WriteLine("Please pick a number higher than 5");
            int numberInput = Convert.ToInt32(Console.ReadLine());
            //Establishes a while loop that will run as long as the input is lower than 6. The nested switch statement prints
            // a promt for the user to enter a another number, reads and turns that input into the new value of the 
            // numberInput variable, which then again will either satisfy the while condition and continue the loop, or not
            // which will end the loop and print a confirmation that the input is indeed higher than 5
            while (numberInput < 6) 
            {
                switch (numberInput)
                {
                    default:
                        Console.WriteLine("That is not higher than 5, try again:");
                        numberInput = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.WriteLine(numberInput + " is higher 5!");

            //Prints a promt for the user to enter their birthyear, reads the input an turns it into the integer variable
            // "yearInput"
            Console.WriteLine("Please enter your birthyear");
            int yearInput = Convert.ToInt32(Console.ReadLine());
            //Establishes a while loop that will run as long as the input is higher 2026 or higher (and therefore in the  
            // future). he nested switch statement prints a promt for the user to enter a another year, reads and turns 
            // that input into the new value of the yearInput variable, which then again will either satisfy the while 
            // condition and continue the loop, or not which will end the loop and print a confirmation of the users 
            // birthyear
            while (2026 <= yearInput)
            {
                switch (yearInput)
                {
                    default:
                        Console.WriteLine("That is in the future, please enter a valid year:");
                        yearInput = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.WriteLine(yearInput + " is your birthyear");


            //PART FOUR ASSIGNMENT
            //Establishes as list of months as a class and instantiates the list of months in the year as an object
            List<string> months = new List<string>()
            {
                "JANUARY",
                "FEBRUARY",
                "MARCH",
                "APRIL",
                "MAY",
                "JUNE",
                "JULY",
                "AUGUST",
                "SEPTEMBER",
                "OCTOBER",
                "NOVEMBER",
                "DECEMBER"
            };
            //Promts the user to enter a month 
            Console.WriteLine("Please enter a month");
            //Establishes the boolean variable monthMatched and gives it the value of false, and uses that as the condition for  
            // the following while loop, so it will only end once the user has given input that matches an item in the list
            bool monthMatched = false;
            while (!monthMatched)
            {
                //Reads the user input and establishes as a string variable and then establishes a new string variable that 
                // converts the former to all uppercase letters, so that it can match the case of the items in the list
                string monthInput = Console.ReadLine();
                string queriedMonth = monthInput.ToUpper();
                //Establishes a loop that iterates through the items in the list, and a nested if statement that if the user's
                // input matches one of the items(months), switches the vaule of the monthMatched to true (effectively ending
                // the parent while loop). It then prints a confrimation with the index matching the users input and breaks
                // the foreach iteration loop
                foreach (string month in months)
                {
                    if (month == queriedMonth)
                    {
                        monthMatched = true;
                        Console.WriteLine("You selected " + month);
                        break;
                    }
                }
                //Establishes that if the user input does not change the condition of the while loop, it prints the user's 
                // input as invalid before circling back to the start of the loop
                if (!monthMatched)
                {
                    Console.WriteLine(queriedMonth + " is not listed, please try again");
                }
            }


            //PART FIVE ASSIGNMENT
            //Establishes as list of days as a class and instantiates the list of days as an object, with Monday listed twice
            List<string> days = new List<string>()
            {
                "MONDAY",
                "TUESDAY",
                "WEDNESDAY",
                "THURSDAY",
                "FRIDAY",
                "SATURDAY",
                "SUNDAY",
                "MONDAY"
            };
            //Promts the user to enter a day, reads the user input and establishes as a string variable and then establishes a new 
            // string variable that converts the former to all uppercase letters, so that it can match the case of the items in 
            // the list
            Console.WriteLine("Please enter a day in the week");
            string dayInput = Console.ReadLine();
            string queriedDay = dayInput.ToUpper();
            //Establishes the boolean variable dayGuessed and gives it the value of false, and uses that as the condition for  
            // the following while loop, so it will only end once the user has given an input  
            bool dayGuessed = false;
            while (!dayGuessed)
            {
                //Establishes a loop that iterates through the items in the list, and a nested if statement that if the user's
                // input matches one or more of the items(days) prints a confrimation with the index(es) matching the users input.
                // It then switches the vaule of the dayGuessed to true (effectively ending the parent while loop).
                foreach (string day in days)
                {
                    if (day == queriedDay)
                    {
                        Console.WriteLine("You selected " + day);
                        dayGuessed = true;
                    }
                }
                //Establishes that if the user input does not match any of the items in the list, it prints the user's input as 
                // invalid and switches the vaule of the dayGuessed to true (effectively ending the parent while loop).
                if (!dayGuessed)
                {
                    Console.WriteLine(queriedDay + " is not listed");
                    dayGuessed = true;
                }
            }


            //PART SIX ASSIGNMENT
            List<string> fruits = new List<string>() { "apple", "orange", "pineapple", "apple" };

            //--FIRST ATTEMPT--
            foreach (string fruit in fruits)
            {
                string queriedFruit = fruit;
                if (queriedFruit != fruit)
                {
                    fruit.Concat(" - this item is unique");
                }
                else if (queriedFruit == fruit)
                {
                    fruit.Concat(" - this item is a duplicate");
                }
            }
            Console.WriteLine(fruits);

            //--SECOND ATTEMPT--
            bool fruitsMatched = false;
            while (!fruitsMatched)
            {
                foreach (string fruit in fruits)
                {
                    string queriedFruit = fruit;

                    if (queriedFruit != fruit)
                    {
                        fruit.Concat(" - this item is unique");
                        Console.WriteLine(fruit);
                    }
                    else if (queriedFruit == fruit)
                    {
                        fruit.Concat(" - this item is a duplicate");
                        Console.WriteLine(fruit);
                    }
                    fruitsMatched = true;
                }
            }
            Console.WriteLine(fruits);

            //--THIRD ATTEMPT--
            List<string> checkedFruits = new List<string>();
            foreach (string fruit in fruits)
            {
                string queriedFruit = fruit;
                foreach (string checkedFruit in checkedFruits)
                { 
                    if (queriedFruit != checkedFruit)
                    {
                        checkedFruits.Add(queriedFruit + " - this item is unique");
                    }
                    if (queriedFruit == checkedFruit)
                    {
                        checkedFruits.Add(queriedFruit + " - this item is a duplicate");
                    }
                }
            }
            Console.WriteLine(checkedFruits);


            Console.ReadLine();
        }
    }
}
