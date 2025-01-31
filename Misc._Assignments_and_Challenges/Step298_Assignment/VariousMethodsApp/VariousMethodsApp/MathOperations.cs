using System;

namespace VariousMethodsApp
{
    public class MathOperations
    {
        //Establishes the void method DivideByTwo, passing in UserInt1. The method is establishes under the non-static
        // class MathOperations, in order for an object to be instatiated using the DivideByTwo method
        public void DivideByTwo(int UserInt1)
        {
            // Divides UserInt1 by 2 and establishes the output as the divisionResult variable, then prints it concatenated 
            // to a string and UserInt1 to show the full statement
            int divisionResult = UserInt1 / 2;
            Console.WriteLine(UserInt1 + " Divided by 2 is " + divisionResult);

        }

        //Establishes the pickANumber method with a boolean return type, passing in the two user inputs 
        public static bool pickANumber(int Userint2, string UserInt3)
        {
            //Converts the second input to an integer and establishes the boolean numbercheck variable, which is given the
            // value of true if the combined inputs is less than or equal to 21. 
            if (Userint2 + Convert.ToInt32(UserInt3) <= 21)
            {
                bool numbercheck = true;
                return numbercheck;
            }
            else
            {
                bool numbercheck = false;
                return numbercheck;
            }
        }

        //Establishes a second pickANumber method that passes in only Userint2 to run the same comparison
        public static bool pickANumber(int Userint2)
        {
            if (Userint2 <= 21)
            {
                bool numbercheck = true;
                return numbercheck;
            }
            else
            {
                bool numbercheck = false;
                return numbercheck;
            }
        }
    }
}
