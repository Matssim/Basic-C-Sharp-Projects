using System;

namespace VoidMethodApp
{
    public class MathOperations
    {
        //Establishes the AddToFiveAndCompare method in the MathOperations class, that taskes in the user input
        // varaibles. The operations it performs on those variables happens within the confines of the method as
        // it is void and therefore doesn't return anything
        public void AddToFiveAndCompare(int UserInt1, int UserInt2)
        {
            // Performs the math operation/adds to five the first user input. Then, based on the result of that 
            // operation, it prints a message commensurate to how the second input compares to the result.
            int additionResult = UserInt1 + 5;
            if (additionResult == UserInt2)
            {
                Console.WriteLine("When you add 5 to " + UserInt1 + ", it has the same value as " + UserInt2);
            }
            else if (additionResult > UserInt1)
            {
                Console.WriteLine("When you add 5 to " + UserInt1 + ", it has a larger value than " + UserInt2 + 
                    ", beacuse " + additionResult + " > " + UserInt2);
            }
            else
            {
                Console.WriteLine("When you add 5 to " + UserInt1 + ", it has a lower value than " + UserInt2 +
                    ", beacuse " + additionResult + " < " + UserInt2);
            }
            Console.ReadLine();
        }
    }
}
