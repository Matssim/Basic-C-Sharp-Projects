using System;

namespace MainMethodApp
{
    //Establishes "MathOperations" as a public class, which makes it accessible accross the namespace
    public class MathOperations
    {
        //Establishes the "SubtractTwo()" method as: public, to make to as it accessible accross the namespace; static, as  
        // it is not an object of MathOperations, but a method; and with an integer return type. The UserInt variable is 
        // passed in
        public static int SubtractTwo(int UserInt)
        {
            //Subtracts 2 from UserInt and establishes the result as an integer variable that is returned from the method
            int subtractionResult = UserInt - 2;
            return subtractionResult;
        }

        //Establishes the "IncreaseNumber()" method as: public, to make to as it accessible accross the namespace; static,  
        // as it is not an object of MathOperations, but a method; and with an decimal return type. The UserDec variable is
        // passed in
        public static decimal IncreaseNumber(decimal UserDec)
        {
            //Multiplies UserDec by 1.2 and establishes the result as an decimal variable that is returned from the method
            decimal multiplicationResult = UserDec * 1.2m;
            return multiplicationResult;
        }

        //Establishes a second version of the "IncreaseNumber()" method, but instead of the UserDec variable it passes in 
        // the multiplicationResult variable from the method above and the UserMult variable
        public static int IncreaseNumber(decimal multiplicationResult, string UserMult)
        {
            //Converts the Usermult string and the multiplicationResult decimal to integers, multipies them by each other
            // and returns the result as the integer variable increaseMulitplied
            int increaseMulitplied = Convert.ToInt32(multiplicationResult) * Convert.ToInt32(UserMult);
            return increaseMulitplied;
        }
    }
}
